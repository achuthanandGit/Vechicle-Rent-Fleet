using System;

namespace VehicleRentFleet
{
    [Serializable]
    class ClsServiceActivity : ClsActivity
    {

        private static FrmServiceActivity _Form = new FrmServiceActivity();
        private string _ServiceBrief;

        

        public string ServiceBrief { get => _ServiceBrief; set => _ServiceBrief = value; }

        public override bool ViewEditActivity()
        {
            return _Form.ShowDialog(this);
        }

        public override string typeOfActivity()
        {
            return "Service";
        }
        
        public override string GetQuickView()
        {
            return "Actvity Name: " + this.ActivityName +
                    "\nActivity Date: " + String.Format("{0:d}", this.ActivityDate) +
                    "\nService Brief: " + this.ServiceBrief +
                    "\nActivity Cost: " + this.ActivityCost + " NZ$";
        }
    }
    
}
