using System;
using System.Windows.Forms;

namespace VehicleRentFleet
{
    public partial class FrmHiringActivity : VehicleRentFleet.FrmActivity
    {
        private ClsHiringActivity _Activity;
        public FrmHiringActivity()
        {
            InitializeComponent();
        }

        protected override void UpdateFormData()
        {
            _Activity = (ClsHiringActivity)_LcActivity;
            
            if(!String.IsNullOrEmpty(_Activity.ActivityName))
            {
                dateTimePickerDate.Value = _Activity.ActivityDate;
                dateTimePickerEndDate.Value = _Activity.HireEndDate;
                numericUpDownCharge.Value = _Activity.ActivityCost;
            }
            else
                numericUpDownCharge.Value = _Activity.DailyCharge;
            base.UpdateFormData();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            CheckHiringDate();
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            CheckHiringDate();
        }

        protected override string GetDataValidationMessage()
        {
            string lcValidationMessage = base.GetDataValidationMessage();
            if (String.IsNullOrWhiteSpace(lcValidationMessage))
            {
                if (DateTime.Compare(dateTimePickerDate.Value, dateTimePickerEndDate.Value) > 0)
                    return "Start date cannot be after End date.";
                else
                    return string.Empty;
            }else
                return lcValidationMessage;
        }
        
        protected override void PushFormData()
        {
            base.PushFormData();
            ClsHiringActivity lcActivity = (ClsHiringActivity)_LcActivity;
            lcActivity.HireEndDate = dateTimePickerEndDate.Value;
            lcActivity.ActivityCost = (numericUpDownCharge.Value);
            lcActivity.DailyCharge = lcActivity.DailyCharge;
        }
        
        private void CheckHiringDate()
        {
            if (DateTime.Compare(dateTimePickerDate.Value, dateTimePickerEndDate.Value) <= 0)
            {
                DateTime startDate = dateTimePickerDate.Value;
                DateTime endDate = dateTimePickerEndDate.Value;
                int daysDifference = ((TimeSpan)(endDate - startDate)).Days + 1;
                decimal totalCharge = daysDifference * _Activity.DailyCharge;
                labelHireCalculation.Text = _Activity.DailyCharge + " NZ$" + " * " + daysDifference + " = ";
                numericUpDownCharge.Value = totalCharge;
            }
            else
                MessageBox.Show("Start date cannot be after End date.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
