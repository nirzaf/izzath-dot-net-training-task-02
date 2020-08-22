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

namespace ABC_Drive.Vehicle
{
    public partial class frmVehicle : Form
    {
        Model.Vehicle model = new Model.Vehicle();
        RentDbContext db = new RentDbContext();
        public frmVehicle()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtVehicleNo.Text == String.Empty)
            {
                MessageBox.Show("Please type Vehicle No");
            }
            else if(txtVehicleName.Text == String.Empty)
            {
                MessageBox.Show("Please type Vehicle Name");
            }
            else if (txtRatePerDay.Text == String.Empty)
            {
                MessageBox.Show("Please type Rate Per Day");
            }
            else if (txtRatePerWeek.Text == String.Empty)
            {
                MessageBox.Show("Please type rate per Week");
            }
            else if (txtRatePerMonth.Text == String.Empty)
            {
                MessageBox.Show("Please type rate per Month");
            }
            else
            {
                if (db.Vehicles.Any(p => p.VehicleNo == txtVehicleNo.Text))
                {
                    MessageBox.Show("This Vehicle No already Recorded. Please type Unique Vehicle No...");
                }
                else
                {
                    Model.Vehicle model = new Model.Vehicle()
                    {
                        VehicleNo = txtVehicleNo.Text,
                        VehicleName = txtVehicleName.Text,
                        RatePerDay = Convert.ToInt32(txtRatePerDay.Text),
                        RatePerWeek = Convert.ToInt32(txtRatePerWeek.Text),
                        RatePerMonth = Convert.ToInt32(txtRatePerMonth.Text)
                    };
                    db.Vehicles.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Vehicle details Successfully Saved");
                    this.Close();
                }
               
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
