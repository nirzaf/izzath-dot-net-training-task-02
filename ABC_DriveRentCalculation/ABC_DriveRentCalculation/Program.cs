using System;

namespace ABC_DriveRentCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Vechile No: ");
            string VechicleNo = Console.ReadLine();

            Console.Write("Enter Rented Date (MM-DD-YYYY): ");
            DateTime RentedDt = DateTime.Parse(Console.ReadLine());
            //DateTime RentedDate = DateTime.Parse(RentedDt.ToString("dd-MM-yyyy"));

            Console.Write("Enter Returned Date (MM-DD-YYYY): ");
            DateTime ReturnedDt = Convert.ToDateTime(Console.ReadLine());
            //DateTime ReturnedDate = DateTime.Parse(ReturnedDt.ToString("dd-MM-yyyy"));

            Console.Write("Driver (true or false): ");
            bool driver = Convert.ToBoolean(Console.ReadLine());

            TimeSpan CountDays = ReturnedDt - RentedDt;
            double Days = CountDays.TotalDays;
            Days += 1;
            //Console.WriteLine(Days);

            int RatePerDay = 5000;
            int RatePerWeek = 20000;
            int RatePerMonth = 90000;
            int DriverRatePerDay = 1000;

            int Weeks = 0;
            int Months = 0;
            int WithoutWkDays = 0;

            int TotDayAmnt = 0;
            int TotWeekAmnt= 0;
            int TotMonthAmnt = 0;

            int DriverCharge = 0;

            float TotalRent = 0;


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
            }


            switch (driver)
            {
                case true:
                    DriverCharge = Convert.ToInt32(Days * DriverRatePerDay);
                    break;
                case false:
                    break;
                default:
                    Console.WriteLine("Wrong input in Driver");
                    break;
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("Vechicle No: "+VechicleNo);
            Console.Write("Total Days: " + WithoutWkDays);
            Console.WriteLine(" Amount: "+TotDayAmnt);

            Console.Write("Total Weeks: " + Weeks);
            Console.WriteLine(" Amount: "+ TotWeekAmnt);

            Console.Write("Total Months: " + Months);
            Console.WriteLine(" Amount: " + TotMonthAmnt);

            Console.WriteLine("Total Rent Without Driver: " + TotalRent);

            Console.WriteLine("Driver Charge: "+DriverCharge);

            int TotRentWithDriver = Convert.ToInt32(DriverCharge + TotalRent);
            Console.WriteLine("Total Rent Amount: "+TotRentWithDriver);

        }
    }
}
