using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace MovieStore
{
    public partial class CustomersForm : Form
    {
        private DbRentalsContainer db;

        private SUserValidationFlags userValidation;

        public CustomersForm()
        {
            InitializeComponent();

            db = new DbRentalsContainer();
            userValidation = new SUserValidationFlags();
        }


        private void CustomersForm_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = db.Users.ToList();

            var userCharges = db.Users.Where(row => row.NumberOfCharges >= 1).OrderBy(row => row.NumberOfCharges);

            userDataGridViewUserCharges.DataSource = userCharges.ToList();
        }

        private void CustomersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.db.Dispose();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (userValidation.First && userValidation.Last && userValidation.Address
                && userValidation.CardNumber && userValidation.Email)
            {
                var user = new User
                {
                    FirstName = textBoxFirst.Text,
                    LastName = textBoxLast.Text,
                    Address = textBoxAddress.Text,
                    Phone = textBoxPhone.Text,
                    Email = textBoxEmail.Text,
                    CardNumber = Int32.Parse(textBoxCard.Text)
                };


                db.Users.Add(user);
                db.SaveChanges();
                userBindingSource.DataSource = db.Users.ToList();

                textBoxFirst.Text = "";
                textBoxLast.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxCard.Text = "";

                MessageBox.Show("User added!");
            }
            else
            {
                MessageBox.Show("Some fields are incorrect!");
            }

        }

        private void textBoxFirst_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(textBoxFirst.Text) || string.IsNullOrWhiteSpace(textBoxFirst.Text)
               || char.IsLower(textBoxFirst.Text.ToCharArray()[0]) || char.IsWhiteSpace(textBoxFirst.Text.ToCharArray()[0]))
            {
                textBoxFirst.Focus();
                errorProviderUser.SetError(textBoxFirst, "First Name must begin with capital letter!");
            }
            else
            {

                errorProviderUser.SetError(textBoxFirst, "");
                userValidation.First = true;
            }
        }

        private void textBoxLast_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxLast.Text) || string.IsNullOrWhiteSpace(textBoxLast.Text)
               || char.IsLower(textBoxLast.Text.ToCharArray()[0]) || char.IsWhiteSpace(textBoxLast.Text.ToCharArray()[0]))
            {
                textBoxLast.Focus();
                errorProviderUser.SetError(textBoxLast, "Last Name must begin with capital letter!");
            }
            else
            {
                errorProviderUser.SetError(textBoxLast, "");
                userValidation.Last = true;
            }
        }

        private void textBoxAddress_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxAddress.Text))
            {
                textBoxLast.Focus();
                errorProviderUser.SetError(textBoxAddress, "Field can not be blank!");
            }
            else
            {
                errorProviderUser.SetError(textBoxAddress, "");
                userValidation.Address = true;
            }
        }

        private void textBoxCard_Validating(object sender, CancelEventArgs e)
        {
            int result;
            if (!(Int32.TryParse(textBoxCard.Text, out result)))
            {
                textBoxCard.Focus();
                errorProviderUser.SetError(textBoxCard, "Card Number must be integer value!");
            }
            else
            {
                errorProviderUser.SetError(textBoxCard, "");
                userValidation.CardNumber = true;
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex rEMail = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b");

            if (!rEMail.IsMatch(textBoxEmail.Text))
            {
                textBoxEmail.Focus();
                errorProviderUser.SetError(textBoxEmail, "Enter valid Email (Example: user@something.com)!");
            }
            else
            {
                errorProviderUser.SetError(textBoxEmail, "");
                userValidation.Email = true;
            }
        }

        private void buttonDelUser_Click(object sender, EventArgs e)
        {
            int? cardNum = Int32.Parse(textBoxDelUser.Text);
            var qDelUser = db.Users.Where(row => row.CardNumber == cardNum).FirstOrDefault();

            if (UtilityClass.ShowErrorMsg(qDelUser, "There is no such Card Number!"))
            {
                return;
            }          

            db.Users.Remove(qDelUser);
            db.SaveChanges();

            textBoxDelUser.Text = "";
            userBindingSource.DataSource = db.Users.ToList();

            MessageBox.Show("User deleted!");
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            db.SaveChanges();

            MessageBox.Show("User edited!");
        }


    }
}
