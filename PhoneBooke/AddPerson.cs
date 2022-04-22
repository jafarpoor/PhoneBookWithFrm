using BussinesObject;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Windows.Forms;

namespace PhoneBooke
{
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }


        /// <summary>
        /// اضافه کردن مخاطب
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPerson_Click(object sender, EventArgs e)
        {

            PersonDAL person = new PersonDAL();
            Person p = new Person()
            {
                PersonType_ID = Convert.ToInt32(cmbPersonType.SelectedValue),
                Adress = txtAdress.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Emails = InserEmail(),
                Phones = InsertPerson(),

            };
            try
            {
                if (string.IsNullOrEmpty(txtNumber1.Text) || string.IsNullOrEmpty(txtFirstName.Text))
                {

                    MessageBox.Show("باید حداقل یک شماره تلفن و اسم وارد شود", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    person.Insert(p);
                    MessageBox.Show("با موفقیت ثبت شد", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// باز شدن شدن فرم اضافه شدن گروه مخاطب
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPersonType_Click(object sender, EventArgs e)
        {
            AddPersonType frm = new AddPersonType();
            frm.ShowDialog();
        }


        /// <summary>
        /// آپدیت کردن لیست بعداز اکتیو شدن فرم
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPerson_Activated(object sender, EventArgs e)
        {
            PersonTypeDAL PTD = new PersonTypeDAL();
            var q = from a in PTD.View()
                    select new { ID = a.ID, Title = a.Title };
            cmbPersonType.DataSource = q.ToList();
            cmbPersonType.DisplayMember = "Title";
            cmbPersonType.ValueMember = "ID";

        }


        /// <summary>
        /// تابع برای چک کردن تکس باکس ها و درنهایت در صورت خالی نبودن آن ها و اضافه کردن تلفن
        /// </summary>
        /// <returns></returns>
        public List<Phone> InsertPerson()
        {
            var phones = new List<Phone>();
            Phone phone1 = null;
            Phone phone2 = null;
            Phone phone3 = null;
            Phone phone4 = null;

            if (txtNumber1.Text != string.Empty)
            {
                phone1 = new Phone()
                {
                    PhoneType = cmbPhoneType1.SelectedIndex,
                    Number = txtNumber1.Text,

                };
            }
            if (txtNumber2.Text != string.Empty)
            {
                phone2 = new Phone()
                {
                    PhoneType = cmbPhoneType2.SelectedIndex,
                    Number = txtNumber2.Text,

                };
            }
            if (txtNumber3.Text != string.Empty)
            {
                phone3 = new Phone()
                {
                    PhoneType = cmbPhoneType3.SelectedIndex,
                    Number = txtNumber3.Text,

                };
            }
            if (txtNumber4.Text != string.Empty)
            {
                phone4 = new Phone()
                {
                    PhoneType = cmbPhoneType4.SelectedIndex,
                    Number = txtNumber4.Text,

                };
            }

            if (phone1 != null)
            {
                phones.Add(phone1);
            }

            if (phone2 != null)
            {
                phones.Add(phone2);
            }

            if (phone3 != null)
            {
                phones.Add(phone3);
            }

            if (phone4 != null)
            {
                phones.Add(phone4);
            }

            return phones;

        }


        /// <summary>
        /// تابع برای چک کردن تکس باکس ایمیل ها و در نهایت اضافه کردن آن ها
        /// </summary>
        /// <returns></returns>
        public List<Email> InserEmail()
        {
            var emails = new List<Email>();
            Email email1 = null;
            Email email2 = null;

            if (txtEmail1.Text != string.Empty)
            {
                email1 = new Email()
                {
                    EmailType = cmbEmail1.SelectedIndex,
                    Title = txtEmail1.Text,

                };
            }

            if (txtEmail2.Text != string.Empty)
            {
                email2 = new Email()
                {
                    EmailType = cmbEmail2.SelectedIndex,
                    Title = txtEmail2.Text,

                };
            }

            if (email1 != null)
            {
                emails.Add(email1);
            }

            if (email2 != null)
            {
                emails.Add(email2);
            }

            return emails;

        }

    }

      
    }

