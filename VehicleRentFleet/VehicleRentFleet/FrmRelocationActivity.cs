using System;

namespace VehicleRentFleet
{
    public partial class FrmRelocationActivity : VehicleRentFleet.FrmActivity
    {
        public FrmRelocationActivity()
        {
            InitializeComponent();
        }

        protected override void UpdateFormData()
        {
            base.UpdateFormData();
            ClsRelocationActivity lcActivity = (ClsRelocationActivity)_LcActivity;
            numericUpDownKmInvolved.Value = Convert.ToDecimal(lcActivity.DistanceCovered);
            numericUpDownCharge.Value = Convert.ToDecimal(_LcActivity.ActivityCost);
        }

        protected override string GetDataValidationMessage()
        {
            string lcValidationMessage = base.GetDataValidationMessage();
            if (String.IsNullOrWhiteSpace(lcValidationMessage))
            {
                if (DateTime.Compare(dateTimePickerDate.Value, DateTime.Now) > 0)
                    return "Relocation Date cannot be a future date.";
                else if (numericUpDownKmInvolved.Value == 0)
                    return "Distance covered cannot be 0 KM.";
                else
                    return string.Empty;
            } else
            return lcValidationMessage;
        }

        protected override void PushFormData()
        {
            base.PushFormData();
            ClsRelocationActivity lcActivity = (ClsRelocationActivity)_LcActivity;
            lcActivity.DistanceCovered = Convert.ToDouble(numericUpDownKmInvolved.Value);
            lcActivity.ActivityCost = numericUpDownCharge.Value;
        }
    }
}
