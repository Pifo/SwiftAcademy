using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Drawing.Imaging;

namespace MovieStore
{
    public partial class DVDsForm : Form
    {
        private DbRentalsContainer db;
        private CDvdValidationFlags dvdValFlags;
        private static long IMAGE_SUFIX = 1;


        public DVDsForm()
        {
            InitializeComponent();

            this.db = new DbRentalsContainer();
            this.dvdValFlags = new CDvdValidationFlags();
        }

        private void buttonAddDvd_Click(object sender, EventArgs e)
        {
            if (this.dvdValFlags.Title && this.dvdValFlags.DvdNumber && this.dvdValFlags.Price)
            {

                var dvd = new Dvd
                {
                    Title = textBoxTitel.Text,
                    DvdNumber = Int32.Parse(textBoxNumber.Text),
                    Available = checkBoxAvailable.Checked,
                    Price = decimal.Parse(textBoxPrice.Text),
                    Genre = (Genres)Enum.Parse(typeof(Genres), comboBoxGenre.Text)
                };

                db.Dvds.Add(dvd);
                db.SaveChanges();

                textBoxTitel.Text = "";
                textBoxNumber.Text = "";
                checkBoxAvailable.Checked = false;
                textBoxPrice.Text = "";

                MessageBox.Show("Dvd added!");

            }
            else
            {
                MessageBox.Show("Some fields are incorrect!");
            }
        }

        private void tabControlDvd_Click(object sender, EventArgs e)
        {
            dvdsBindingSource.DataSource = db.Dvds.ToList();

            var available = db.Dvds.Where(d => d.Available == true);
            var unavailable = db.Dvds.Where(d => d.Available == false);

            var returnDate = from rent in db.Rents
                             join dvd in db.Dvds on rent.RentId equals dvd.RentId
                             where (rent.DueDate != null)
                             select new CReturnDate
                             {
                                 Title = dvd.Title,
                                 DueDate = rent.DueDate.Value,
                                 ReturnDate = rent.ReturnDate.Value
                             };


            List<CReturnDate> returnDatedList = returnDate.ToList();

            for (int row = 0; row < returnDatedList.Count; row++)
            {
                returnDatedList[row].ReturnDate = returnDatedList[row].DueDate.Value.AddDays(1);
            }

            dvdsDataGridViewAvailable.DataSource = available.ToList();
            dvdsDataGridViewUnavailable.DataSource = unavailable.ToList();
            dataGridViewCustom.DataSource = returnDatedList;

           
        }

        private void DVDsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }

        private void buttonDelDvd_Click(object sender, EventArgs e)
        {
            int? dvdNum = Int32.Parse(textBoxDelDvd.Text);
            var qDelDvd = db.Dvds.Where(row => row.DvdNumber == dvdNum).FirstOrDefault();

            if (UtilityClass.ShowErrorMsg(qDelDvd, "There is no such Dvd!"))
            {
                return;
            }

            db.Dvds.Remove(qDelDvd);
            db.SaveChanges();

            textBoxDelDvd.Text = "";
            dvdsBindingSource.DataSource = db.Dvds.ToList();

            MessageBox.Show("Dvd deleted!");
        }

        private void textBoxTitel_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTitel.Text))
            {
                textBoxTitel.Focus();
                errorProviderDvd.SetError(textBoxTitel, "Title can not be empty!");
            }
            else
            {
                errorProviderDvd.SetError(textBoxTitel, "");
                dvdValFlags.Title = true;
            }
        }

        private void textBoxNumber_Validating(object sender, CancelEventArgs e)
        {
            int result;
            if (!(Int32.TryParse(textBoxNumber.Text, out result)))
            {
                textBoxNumber.Focus();
                errorProviderDvd.SetError(textBoxNumber, "Dvd Number must be integer value!");
            }
            else
            {
                errorProviderDvd.SetError(textBoxNumber, "");
                dvdValFlags.DvdNumber = true;
            }
        }

        private void textBoxPrice_Validating(object sender, CancelEventArgs e)
        {
            decimal result;
            if (!(Decimal.TryParse(textBoxPrice.Text, out result)))
            {
                textBoxPrice.Focus();
                errorProviderDvd.SetError(textBoxPrice, "Price must be decimal value!");
            }
            else
            {
                errorProviderDvd.SetError(textBoxPrice, "");
                dvdValFlags.Price = true;
            }
        }

        private void buttonEditDvd_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dvdsBindingSource.EndEdit();
            db.SaveChanges();

            MessageBox.Show("Dvd edited!");
        }

        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            using (var wc = new WebClient())
            {
                var json_data = string.Empty;

                string dvdTitle = this.textBoxDvdTitle.Text;
                var dvdList = db.Dvds.Select(row => row);


                if (UtilityClass.IsInMovieCatalog(dvdList, dvdTitle))
                {
                    try
                    {
                        json_data = wc.DownloadString(@"http://www.omdbapi.com/?t=" + dvdTitle);
                        JObject jo = (JObject)JsonConvert.DeserializeObject(json_data);


                        textBoxInfoTitle.Text = jo["Title"].ToString();
                        textBoxInfoYear.Text = jo["Year"].ToString();
                        dateTimePickerInfoRelease.Text = jo["Released"].ToString();
                        textBoxInfoRuntime.Text = jo["Runtime"].ToString();
                        textBoxInfoGenre.Text = jo["Genre"].ToString();
                        textBoxInfoDirector.Text = jo["Director"].ToString();
                        textBoxInfoActors.Text = jo["Actors"].ToString();

                        string uri = jo["Poster"].ToString();
                   

                        if (uri.Equals("N/A"))
                        {
                            this.pictureBoxInfoPoster.Image = null;
                        }
                        else
                        {
                            string file = "..\\..\\Resources\\poster" + IMAGE_SUFIX.ToString() + ".jpeg";
                            wc.DownloadFile(uri, file);

                            this.pictureBoxInfoPoster.Image = Image.FromFile(file);
                            IMAGE_SUFIX++;                          
                        }

                    }
                    catch (WebException ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                }
                else
                {
                    MessageBox.Show("There is no such Dvd in Movie Catalog!");
                    return;
                }

            }
        }
    }
}
