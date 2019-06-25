using System.Collections.Generic;

namespace VehicleRentFleet
{
    class ClsSortByName : IComparer<ClsActivity>
    {
        public int Compare(ClsActivity activityOne, ClsActivity activityTwo)
        {
            return activityOne.ActivityName.CompareTo(activityTwo.ActivityName);
        }
    }
}
