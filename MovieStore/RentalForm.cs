using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects.SqlClient;
using System.Data.Linq.SqlClient;
using System.Data.Entity;

namespace MovieStore
{
    public partial class RentalForm : Form
    {
        private DbRentalsContainer db;
        private CRentalValidationFlags rentalValFlags;

        public RentalForm()
        {
            InitializeComponent();

            this.db = new DbRentalsContainer();
            this.rentalValFlags = new CRentalValidationFlags();
        }
      

        private void buttonAddRental_Click(object sender, EventArgs e)
        {
            if (this.rentalValFlags.DvdNumber && this.rentalValFlags.UserCardNumber)
            {
                var userNumber = Int32.Parse(textBoxUserNumber.Text);
                var dvdNumber = Int32.Parse(textBoxDvdNumber.Text);

                DateTime currentDate = DateTime.Now;

                User queryUser = db.Users.Where(u => userNumber == u.CardNumber).FirstOrDefault();
                Dvd queryDvd = db.Dvds.Where(d => dvdNumber == d.DvdNumber).FirstOrDefault();

                if(queryDvd == null)
                {
                    MessageBox.Show("There is no such Dvd Number!");
                    return;
                }

                if (!(bool)queryDvd.Available)
                {
                    MessageBox.Show("Dvd is not available!");
                    return;
                }

                Rent rent = new Rent();

                rent.UserId = queryUser.UserId;
                rent.DueDate = currentDate;

                db.Rents.Add(rent);

                db.SaveChanges();

                textBoxUserNumber.Text = "";
                textBoxDvdNumber.Text = "";

                queryDvd.RentId = rent.RentId;
                queryDvd.Available = false;
                queryUser.Rents.Add(rent);

                rentalValFlags.DvdNumber = false;
                rentalValFlags.UserCardNumber=false;

                db.SaveChanges();

                MessageBox.Show("Rental added!");
            }
            else
            {
                MessageBox.Show("Some fields are incorrect!");
            }
        }

            
        private void tabControlRental_Click(object sender, EventArgs e)
        {

            rentsBindingSource.DataSource = db.Rents.ToList();

            DateTime? chargeGenerator = new DateTime(2016, 1, 15);
            DateTime? currentDate = DateTime.Now;

            var charges = from users in db.Users
                          join rents in db.Rents on users.UserId equals rents.UserId
                          join dvds in db.Dvds on rents.RentId equals dvds.RentId
                          where (DbFunctions.DiffDays(rents.DueDate, chargeGenerator) > 1)
                          select new CChargeViewer
                          {
                              FirstName = users.FirstName,
                              LastName = users.LastName,
                              Title = dvds.Title,
                              OverdueDays = DbFunctions.DiffDays(rents.DueDate, chargeGenerator),
                              Charge = (DbFunctions.DiffDays(rents.DueDate, chargeGenerator)) * (dvds.Price)
                          };

            dataGridViewShowCharges.DataSource = charges.ToList();

        }

        private void RentalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }

        private void buttonDelRental_Click(object sender, EventArgs e)
        {
            if (this.rentalValFlags.DvdNumber)
            {
                var currentDvdNumber = int.Parse(textBoxDelNumber.Text);
                Dvd qDvd = db.Dvds.Where(d => d.DvdNumber == currentDvdNumber).FirstOrDefault();

                qDvd.Available = true;
                int? currentRent = qDvd.RentId;

                Rent qRent = db.Rents.Where(r => r.RentId == currentRent).FirstOrDefault();
                if (qRent == null)
                {
                    MessageBox.Show("Dvd "+currentDvdNumber.ToString() + " doesn't have charge!");
                    return;
                }

                DateTime returned = DateTime.Now;

                qRent.ReturnDate = returned;  //new DateTime(2016, 1, 15); test date for charges

                db.SaveChanges();

                DateTime? due = qRent.DueDate;
                DateTime? ret = qRent.ReturnDate;
                int? day = SqlMethods.DateDiffDay(due, ret);

                if (day > 1)
                {
                    qRent.Charge = day * qDvd.Price;
                    qRent.OverduedDays = day;

                    db.SaveChanges();

                    string msg = qRent.Charge.ToString() + " leva";

                    if (MessageBox.Show(msg, "Pay Charge", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        qDvd.RentId = null;
                        var user = db.Users.Where(row => row.UserId == qRent.UserId).FirstOrDefault();                       

                        user.NumberOfCharges++;
                        db.Rents.Remove(qRent);
                        db.SaveChanges();
                    };

                    textBoxDelNumber.Text = "";

                    return;
                }

                qDvd.RentId = null;
                db.Rents.Remove(qRent);
                db.SaveChanges();

                textBoxDelNumber.Text = "";

                MessageBox.Show("Dvd deleted!");

            }
            else
            {
                MessageBox.Show("Some fields are incorrect!");
            }
        }

        private void textBoxUserNumber_Validating(object sender, CancelEventArgs e)
        {
            int result;

            if (!(Int32.TryParse(textBoxUserNumber.Text, out result)))
            {
                textBoxUserNumber.Focus();
                errorProviderRental.SetError(textBoxUserNumber, "Enter Valid User Number!");
            }
            else
            {
                int parsedNum = Int32.Parse(textBoxUserNumber.Text);
                bool isNumber = db.Users.Any(row => row.CardNumber == parsedNum);

                if (!isNumber)
                {
                    errorProviderRental.SetError(textBoxUserNumber, "Enter Valid User Number!");
                    return;
                }

                errorProviderRental.SetError(textBoxUserNumber, "");
                rentalValFlags.UserCardNumber = true;
            }
        }

        private void textBoxDvdNumber_Validating(object sender, CancelEventArgs e)
        {
            int result;

            if (!(Int32.TryParse(textBoxDvdNumber.Text, out result)))
            {
                textBoxDvdNumber.Focus();
                errorProviderRental.SetError(textBoxDvdNumber, "Enter Valid Dvd Number!");
            }
            else
            {
                int parsedNum = Int32.Parse(textBoxDvdNumber.Text);
                bool isNumber = db.Dvds.Any(row => row.DvdNumber == parsedNum);

                if (!isNumber)
                {
                    errorProviderRental.SetError(textBoxDvdNumber, "Enter Valid Dvd Number!");
                    return;
                }

                errorProviderRental.SetError(textBoxDvdNumber, "");
                rentalValFlags.DvdNumber = true;
            }
        }

        private void textBoxDelNumber_Validating(object sender, CancelEventArgs e)
        {
            int result;

            if (!(Int32.TryParse(textBoxDelNumber.Text, out result)))
            {
                textBoxDelNumber.Focus();
                errorProviderRental.SetError(textBoxDelNumber, "Enter Valid Dvd Number!");
            }
            else
            {
                int parsedNum = Int32.Parse(textBoxDelNumber.Text);
                bool isNumber = db.Dvds.Any(row => row.DvdNumber == parsedNum);

                if (!isNumber)
                {
                    errorProviderRental.SetError(textBoxDelNumber, "Enter Valid Dvd Number!");
                    return;
                }

                errorProviderRental.SetError(textBoxDelNumber, "");
                rentalValFlags.DvdNumber = true;
            }
        }

        private void buttonEditRent_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rentsBindingSource.EndEdit();

            db.SaveChanges();

            MessageBox.Show("Rent edited!");
        }

        private void tabPageShowRentalWithoutCharges_Enter(object sender, EventArgs e)
        {
            var rentQ = from users in db.Users
                        join rents in db.Rents on users.UserId equals rents.UserId
                        join dvds in db.Dvds on rents.RentId equals dvds.RentId
                        where (rents.Charge != 0)
                        orderby rents.DueDate
                        select new CRentWithoutCharges
                        {
                            RentId = rents.RentId,
                            DueDate = (DateTime)rents.DueDate,
                            UserId = (int)rents.UserId,
                            UserCardNumber = rents.User.CardNumber,
                            MovieTitle = dvds.Title
                        };

            dataGridViewWithoutCharges.DataSource = rentQ.ToList();
        }         

    }
}
