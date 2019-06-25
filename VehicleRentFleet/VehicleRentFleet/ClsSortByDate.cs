using System.Collections.Generic;

namespace VehicleRentFleet
{
    class ClsSortByDate : IComparer<ClsActivity>
    {
        public int Compare(ClsActivity activityOne, ClsActivity activityTwo)
        {
            return activityOne.ActivityUpdatedTime.CompareTo(activityTwo.ActivityUpdatedTime);
        }
    }
}
