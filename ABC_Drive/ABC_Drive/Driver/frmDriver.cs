using ABC_Drive.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Drive.Driver
{
    public partial class frmDriver : Form
    {
        Model.Driver model = new Model.Driver();
        RentDbContext db = new RentDbContext();
        public frmDriver()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDriverName.Text == String.Empty)
            {
                MessageBox.Show("Please type a Driver name");
            }
            else if (txtDriverCost.Text == String.Empty)
            {
                MessageBox.Show("Please type a Driver Cost per day");
            }
            else
            {
                Model.Driver model = new Model.Driver()
                {
                    DriverName = txtDriverName.Text,
                    DriverCost = Convert.ToInt32(txtDriverCost.Text)
                };
                db.Drivers.Add(model);
                db.SaveChanges();
                MessageBox.Show("Driver Details Saccessfully Saved");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
