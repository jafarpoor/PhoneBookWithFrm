
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace PhoneBooke
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int SelectedID = 0;

        PersonDAL PersonDAL = new PersonDAL();


        /// <summary>
        /// آپدیت کردن لیست افراد
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Activated(object sender, EventArgs e)
        {
            LoadData();

        }


        /// <summary>
        /// فرم افزودن مخاطب باز شود
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPerson_Click(object sender, EventArgs e)
        {
            AddPerson frm = new AddPerson();
            frm.ShowDialog();
            LoadData();


        }



        /// <summary>
        /// حذف مخاطب
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeletPerson_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مایلید مورد انتخاب شده حذف شود؟", "سوال(حذف)؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    if (SelectedID == 0)
                    {

                        MessageBox.Show("لطفا روی مخاطب مورد نظر کلیک کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                        return;
                    }


                    PersonDAL.Delet(SelectedID);

                    LoadData();
                    MessageBox.Show("مخاطب مورد نظر با موفقیت حذف گردید", "تبریک", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
 }
      


        /// <summary>
        /// دریافت ای دی وقتی بر روی فرد در دیتا گرید ویو کلیک می شود
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedID = Convert.ToInt32(gridPerson.CurrentRow.Cells["ID"].Value);
        }


        public void LoadData()
        {

           var list = PersonDAL.ViewPerson();
            gridPerson.DataSource = list;


        }

        private void Main_Load(object sender, EventArgs e)
        {
            gridPerson.AutoGenerateColumns = false;
            LoadData();
        }
    }
}

