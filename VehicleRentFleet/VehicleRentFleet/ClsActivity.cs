using System;

namespace VehicleRentFleet
{

    [Serializable]
    public abstract class ClsActivity
    {
        private DateTime _ActivityUpdatedTime;
        private string _ActivityName;
        private DateTime _ActivityDate;
        private decimal _ActivityCost;

        private static readonly string[] _ActivityType = { "Hiring", "Service", "Relocation" };
        private static readonly string[] _SortType = { "Activity Name", "Activity Date" };

        
        public string ActivityName { get => _ActivityName; set => _ActivityName = value; }
        public DateTime ActivityDate { get => _ActivityDate; set => _ActivityDate = value; }
        public decimal ActivityCost { get => _ActivityCost; set => _ActivityCost = value; }

        public static string[] ActivityType => _ActivityType;

        public static string[] SortType => _SortType;

        public DateTime ActivityUpdatedTime { get => _ActivityUpdatedTime; set => _ActivityUpdatedTime = value; }

        public static ClsActivity NewActivity(string activityType, int dailyCharge)
        {
            switch (activityType)
            {
                case "Service":
                    return new ClsServiceActivity();
                case "Relocation":
                    return new ClsRelocationActivity();
                default:
                    return new ClsHiringActivity(dailyCharge);
            }
        }

        public override string ToString()
        {
            return typeOfActivity() + (typeOfActivity() == "Relocation" ? "\t" : "\t\t") + ActivityName + "\t\t" + String.Format("{0:d}", _ActivityUpdatedTime) + "\t\t" + ActivityCost;
        }

        public abstract string typeOfActivity();

        public abstract bool ViewEditActivity();

        public abstract string GetQuickView();

        
    }
}
