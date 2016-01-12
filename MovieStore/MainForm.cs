using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButtonUser_Click(object sender, EventArgs e)
        {
            CustomersForm customer=new CustomersForm();
            customer.Show();
        }

        private void toolStripButtonDvd_Click(object sender, EventArgs e)
        {
            DVDsForm dvd=new DVDsForm();
            dvd.Show();
        }

        private void toolStripButtonRent_Click(object sender, EventArgs e)
        {
            RentalForm rental=new RentalForm();
            rental.Show();
        }
    }
}
