using System;
using System.Collections.Generic;

namespace VehicleRentFleet
{
    [Serializable]
    public class ClsVehicle
    {
        private static FrmManageVehicle _Form = new FrmManageVehicle();
        
        private string _RegistrationNumber;
        private string _VehicleMake;
        private string _VehicleModel;
        private int _VehicleYear;
        private int _DailyCharge;
        
        private List<ClsActivity> _VehicleActvityList = new List<ClsActivity>();
   
        
        public string RegistrationNumber { get => _RegistrationNumber; set => _RegistrationNumber = value; }
        public string VehicleMake { get => _VehicleMake; set => _VehicleMake = value; }
        public string VehicleModel { get => _VehicleModel; set => _VehicleModel = value; }
        public int VehicleYear { get => _VehicleYear; set => _VehicleYear = value; }
        public int DailyCharge { get => _DailyCharge; set => _DailyCharge = value; }
        
        public List<ClsActivity> VehicleActvityList { get => _VehicleActvityList; set => _VehicleActvityList = value; }

        public string GetQuickView()
        {
            return " Reg no: " + RegistrationNumber + "\n" +
               " Make: " + VehicleMake + "\n" +
               " Model: " + VehicleModel + "\n" +
               " Year: " + VehicleYear + "\n" +
               " Hire Value: " + DailyCharge + "NZ$";
        }


        public bool ViewEditVehicle()
        {
            return _Form.ShowDialog(this);
        }

        public decimal CalculateVehicleCashFlow()
        {
            decimal totalCashFlow = 0;
            decimal creditValue = 0;
            decimal debitValue = 0;
            foreach (ClsActivity lcActivity in VehicleActvityList)
            {
                if ("Hiring" == lcActivity.typeOfActivity())
                    creditValue += lcActivity.ActivityCost;
                else
                    debitValue += lcActivity.ActivityCost;
            }
            totalCashFlow += creditValue - debitValue;
            return totalCashFlow;
        }
    }
}

