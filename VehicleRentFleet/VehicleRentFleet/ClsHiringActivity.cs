using System;

namespace VehicleRentFleet
{

    [Serializable]
    class ClsHiringActivity : ClsActivity
    {
        private static FrmHiringActivity _Form = new FrmHiringActivity();
        private DateTime _HireEndDate;
        
        private int _DailyCharge;

        public ClsHiringActivity(int charge)
        {
            DailyCharge = charge;
        }

        public DateTime HireEndDate { get => _HireEndDate; set => _HireEndDate = value; }
        public int DailyCharge { get => _DailyCharge; set => _DailyCharge = value; }

        public override bool ViewEditActivity()
        {
            return _Form.ShowDialog(this);
        }

        public override string typeOfActivity()
        {
            return "Hiring";
        }
        
        public override string GetQuickView()
        {
            return "Actvity Name: " + this.ActivityName +
                  "\nStart Date: " + String.Format("{0:d}", this.ActivityDate) +
                  "\nEnd Data: " + String.Format("{0:d}", this.HireEndDate) +
                  "\nActivity Cost: " + this.ActivityCost + " NZ$";
        }
    }
}
