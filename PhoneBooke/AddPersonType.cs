using BussinesObject;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBooke
{
    public partial class AddPersonType : Form
    {
        PersonTypeDAL PTD = new PersonTypeDAL();

        int SelectedID = 0;

        public AddPersonType()
        {
            InitializeComponent();
        }

        /// <summary>
        /// اضافه کردن گروه افراد
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPersonType_Click(object sender, EventArgs e)
        {
            PersonTypeDAL PTD = new PersonTypeDAL();
            var PersonType = new PersonType()
            {

                Title = txtPersonType.Text,
            };

            try
            {
                if (string.IsNullOrEmpty(txtPersonType.Text))
                {
                    Exception ex = new Exception();
                    MessageBox.Show(ex.Message, "لطفا نام گروه را وارد کنید", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   PTD.Inset(PersonType);
                  grid.DataSource= PTD.View();
                    txtPersonType.Clear();
                    MessageBox.Show("با موفقیت ثبت شد", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// برای اینکه وقتی روی فرد در دیتا گرید ویو کلیک می شود ای دی را پیدا کنیم و با ان ای دی عملیات مورد نظر را انجام دهیم
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedID = Convert.ToInt32(grid.CurrentRow.Cells["ID"].Value);
        }


        /// <summary>
        /// حذف گروه افراد
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedID == 0)
            {

                MessageBox.Show("لطفا روی مخاطب مورد نظر کلیک کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                return;
            }

            using (var ctx= new MyContext())
            {
                var type = ctx.PersonTypes.Find(SelectedID);
                if (type != null)
                {
                   
                     PTD.Delet(SelectedID);
                   
                    MessageBox.Show("با موفقیت حذف شد", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid.DataSource = PTD.View();
                }
            }

        }


        /// <summary>
        /// لود کردن بعد از تغییرات اضاقه یا کم کردن در دیتا گرید ویو
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AddPersonType_Load(object sender, EventArgs e)
        {
            grid.AutoGenerateColumns = false;
            grid.DataSource = PTD.View();

        }
    }  

      
    }

