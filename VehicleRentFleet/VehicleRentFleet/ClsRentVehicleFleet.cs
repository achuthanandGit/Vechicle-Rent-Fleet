using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace VehicleRentFleet
{
    [Serializable]
    class ClsRentVehicleFleet
    {
        private static string _FileName = "D:\\GIT\\sdv601\\listbox over list view\\VehicleRentFleet\\vehicleRentFleetDictionary.dat";

        private static SortedDictionary<string, ClsVehicle> _FleetList = new SortedDictionary<string, ClsVehicle>();

        public static SortedDictionary<string, ClsVehicle> FleetList { get => _FleetList; set => _FleetList = value; }

        public static void SaveData()
        {
            using (FileStream lcFileStream = new FileStream(_FileName, FileMode.Create))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, FleetList);
            }
        }

        public static void RetrieveData()
        {
            using (FileStream lcFileStream = new FileStream(_FileName, FileMode.Open))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                FleetList = (SortedDictionary<string, ClsVehicle>)lcFormatter.Deserialize(lcFileStream);
            }
        }

        public static decimal CalculateFleetCashFlow()
        {
            decimal totalCashFlow = 0;
            decimal creditValue = 0;
            decimal debitValue = 0;
            List<ClsVehicle> vehicleList = FleetList.Values.ToList();
            if(vehicleList.Any())
            {
                foreach (ClsVehicle lcVehicle in vehicleList)
                {
                    foreach (ClsActivity lcActivity in lcVehicle.VehicleActvityList)
                    {
                        if ("Hiring" == lcActivity.typeOfActivity())
                            creditValue += lcActivity.ActivityCost;
                        else
                            debitValue += lcActivity.ActivityCost;
                    }
                }
            }
            totalCashFlow += creditValue - debitValue;
            return totalCashFlow;
        }
    }
}
