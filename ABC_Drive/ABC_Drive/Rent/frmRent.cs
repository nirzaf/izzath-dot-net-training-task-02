using ABC_Drive.Driver;
using ABC_Drive.Model;
using ABC_Drive.Vehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Drive.Rent
{
    public partial class frmRent : Form
    {
        
        RentDbContext db = new RentDbContext();
        Model.Rent model = new Model.Rent();
        int VehicleID;

        public frmRent()
        {
            InitializeComponent();
        }

        private void frmRent_Load(object sender, EventArgs e)
        {
            dtpRentedDate.CustomFormat = "dd-MM-yyyy";
            dtpReturnedDate.CustomFormat = "dd-MM-yyyy";
            rbDriverNo.Checked = true;
        }
        private void RentCalculation()
        {
            double Days = 0;
            DateTime RentedDate = dtpRentedDate.Value;
            DateTime ReturnedDate = dtpReturnedDate.Value;
            bool driver = rbDriverYes.Checked;

            TimeSpan CountDays = ReturnedDate - RentedDate;
            Days = CountDays.TotalDays;

            var RatePerDay = db.Vehicles.Where(x => x.VehicleId == VehicleID).Select(u => u.RatePerDay).FirstOrDefault();
            var RatePerWeek = db.Vehicles.Where(x => x.VehicleId == VehicleID).Select(u => u.RatePerWeek).FirstOrDefault();
            var RatePerMonth = db.Vehicles.Where(x => x.VehicleId == VehicleID).Select(u => u.RatePerMonth).FirstOrDefault();

            var DriverRatePerDay = db.Drivers.Where(x => x.Id== 1).Select(u => u.DriverCost).FirstOrDefault();

            int Weeks = 0;
            int Months = 0;
            int WithoutWkDays = 0;

            int TotDayAmnt = 0;
            int TotWeekAmnt = 0;
            int TotMonthAmnt = 0;

            int DriverCharge = 0;

            float TotalRent = 0;

            //lblTotDays.Text = Convert.ToInt32(Days).ToString();

            if (Days > 7)
            {
                if (Days > 30)
                {
                    Months = Convert.ToInt32(Days / 30);
                    int CountWeeks = Convert.ToInt32(Days - (Months * 30));
                    Weeks = Convert.ToInt32(CountWeeks / 7);
                    WithoutWkDays = Convert.ToInt32(Days - (Weeks * 7) - (Months * 30));

                    TotDayAmnt = WithoutWkDays * RatePerDay;
                    TotWeekAmnt = Weeks * RatePerWeek;
                    TotMonthAmnt = Months * RatePerMonth;

                    TotalRent = TotMonthAmnt + TotWeekAmnt + TotDayAmnt;
                }
                else
                {
                    Weeks = Convert.ToInt32(Days / 7);
                    WithoutWkDays = Convert.ToInt32(Days - (Weeks * 7));

                    
                    TotDayAmnt = WithoutWkDays * RatePerDay;
                    TotWeekAmnt = Weeks * RatePerWeek;

                    TotalRent = TotWeekAmnt + TotDayAmnt;
                }
            }
            else
            {
                TotalRent = Convert.ToInt32(Days * RatePerDay);
                TotDayAmnt = Convert.ToInt32(TotalRent);
                WithoutWkDays = Convert.ToInt32( Days);
            }
            switch (driver)
            {
                case true:
                    DriverCharge = Convert.ToInt32(Days * DriverRatePerDay);
                    break;
                case false:
                    break;
                default:
                    break;
            }

            lblTotDays.Text = Convert.ToInt32(WithoutWkDays).ToString();
            lblTotWeeks.Text = Convert.ToInt32(Weeks).ToString();
            lblTotMonths.Text = Convert.ToInt32(Months).ToString();

            txtTotDaysAmnt.Text = Convert.ToInt32(TotDayAmnt).ToString();
            txtTotWeeksAmnt.Text = Convert.ToInt32(TotWeekAmnt).ToString();
            txtTotMonthsAmnt.Text = Convert.ToInt32(TotMonthAmnt).ToString();

            lblTotDriverCost.Text = Convert.ToInt32(DriverCharge).ToString();
            //lblTotRent.Text = Convert.ToInt32(TotalRent).ToString();
            int TotRentWithDriver = Convert.ToInt32(DriverCharge + TotalRent);
            lblTotRent.Text = Convert.ToInt32(TotRentWithDriver).ToString();

        }

        private void txtVehicleNo_TextChanged(object sender, EventArgs e)
        {
            if (txtVehicleNo.Text != "")
            {
                dgvVehicleList.Visible = dgvVehicleList.Rows.Count > 0;

                var result = (from Vehicle in db.Vehicles
                              where Vehicle.VehicleNo.Contains(txtVehicleNo.Text.ToString())
                              select new
                              {
                                  ID = Vehicle.VehicleId,
                                  VehicleNo = Vehicle.VehicleNo
                              }).ToList();
                dgvVehicleList.DataSource = result;
                dgvVehicleList.Columns[0].Visible = false;
            }
            else if (txtVehicleNo.Text == "")
            {
                dgvVehicleList.Visible = false;
            }
        }
        
        private void dgvVehicleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = this.dgvVehicleList.CurrentRow;
                VehicleID = Convert.ToInt32(dgv.Cells[0].Value);
                this.txtVehicleNo.Text = dgv.Cells[1].Value.ToString();
                dgvVehicleList.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpRentedDate_ValueChanged(object sender, EventArgs e)
        {
            if (txtVehicleNo.Text == String.Empty)
            {
                MessageBox.Show("Please type a Vehicle No first.");
                txtVehicleNo.Focus();
            }
            else if(db.Vehicles.Any(p => p.VehicleId != VehicleID))
            {
                MessageBox.Show("Please type Valid Vehicle No");
                txtVehicleNo.Focus();
            }
            else
            {
                RentCalculation();
            }
        }
        private void dtpReturnedDate_ValueChanged(object sender, EventArgs e)
        {
            if (txtVehicleNo.Text == String.Empty)
            {
                MessageBox.Show("Please type a Vehicle No first.");
                txtVehicleNo.Focus();
            }
            else if (db.Vehicles.Any(p => p.VehicleId != VehicleID))
            {
                MessageBox.Show("Please type Valid Vehicle No");
                txtVehicleNo.Focus();
            }
            else
            {
                RentCalculation();
            }
        }

        private void rbDriverYes_CheckedChanged(object sender, EventArgs e)
        {
            if (txtVehicleNo.Text == String.Empty)
            {
                MessageBox.Show("Please type a Vehicle No first.");
                txtVehicleNo.Focus();
            }
            else if (db.Vehicles.Any(p => p.VehicleId != VehicleID))
            {
                MessageBox.Show("Please type Valid Vehicle No");
                txtVehicleNo.Focus();
            }
            else
            {
                RentCalculation();
            }
        }

        private void rbDriverNo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            frmVehicle frmV = new frmVehicle();
            using (frmV)
            {
                if (frmV.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }

        private void txtVehicleNo_Leave(object sender, EventArgs e)
        {
            /*
            if (txtVehicleNo.Text != String.Empty)
            {
                if (db.Vehicles.Any(p => p.VehicleId != VehicleID))
                {
                    MessageBox.Show("Please type Valid Vehicle No");
                    txtVehicleNo.Focus();
                }
                else
                {
                    RentCalculation();
                }
            }*/
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            frmDriver frmD = new frmDriver();
            using (frmD)
            {
                if (frmD.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
