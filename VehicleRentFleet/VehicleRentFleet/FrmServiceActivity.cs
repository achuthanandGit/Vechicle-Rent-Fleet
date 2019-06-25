using System;

namespace VehicleRentFleet
{
    public partial class FrmServiceActivity : VehicleRentFleet.FrmActivity
    {
        public FrmServiceActivity()
        {
            InitializeComponent();
        }

        protected override void UpdateFormData()
        {
            base.UpdateFormData();
            ClsServiceActivity lcActivity = (ClsServiceActivity)_LcActivity;
            if(string.IsNullOrWhiteSpace(lcActivity.ActivityName))
                richTextBoxServiceBrief.Text = string.Empty;
            else
                richTextBoxServiceBrief.Text = lcActivity.ServiceBrief;
            numericUpDownCharge.Value = Convert.ToDecimal(_LcActivity.ActivityCost);
        }

        protected override string GetDataValidationMessage()
        {
            string validationMessage = base.GetDataValidationMessage();
            if (String.IsNullOrWhiteSpace(validationMessage))
            {
                if (DateTime.Compare(dateTimePickerDate.Value, DateTime.Now) > 0)
                    return "Service Date cannot be a future date.";
                else if (string.IsNullOrEmpty(richTextBoxServiceBrief.Text))
                    return "Service brief cannot be empty.";
                else
                    return string.Empty;
            } else
            return validationMessage;
        }

        protected override void PushFormData()
        {
            ClsServiceActivity lcActivity = (ClsServiceActivity)_LcActivity;
            lcActivity.ServiceBrief = richTextBoxServiceBrief.Text;
            lcActivity.ActivityCost = numericUpDownCharge.Value;
            base.PushFormData();
        }
    }
}
