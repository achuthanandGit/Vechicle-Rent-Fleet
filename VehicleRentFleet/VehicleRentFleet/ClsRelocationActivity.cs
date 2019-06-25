using System;

namespace VehicleRentFleet
{
    [Serializable]
    class ClsRelocationActivity : ClsActivity
    {
        private static FrmRelocationActivity _Form = new FrmRelocationActivity();
        private Double _DistanceCovered;
        

        public Double DistanceCovered { get => _DistanceCovered; set => _DistanceCovered = value; }

        public override bool ViewEditActivity()
        {
            return _Form.ShowDialog(this);
        }

        public override string typeOfActivity()
        {
            return "Relocation";
        }

        public override string GetQuickView()
        {
            return "Actvity Name: " + this.ActivityName +
                    "\nActivity Date: " + String.Format("{0:d}", this.ActivityDate) +
                    "\nDistance covered: " + this.DistanceCovered + " KM" +
                    "\nActivity Cost: " + this.ActivityCost + " NZ$";
        }
    }
}
