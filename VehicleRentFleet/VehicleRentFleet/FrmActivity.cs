using System;
using System.Windows.Forms;

namespace VehicleRentFleet
{
    public partial class FrmActivity : Form
    {
        protected ClsActivity _LcActivity;
        public FrmActivity()
        {
            InitializeComponent();
            SetButtonToolTips();
        }
        
        private void SetButtonToolTips()
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.buttonOk, "Ok");
            ToolTip1.SetToolTip(this.buttonCancel, "Cancel");
        }

        public bool ShowDialog(ClsActivity prActivity)
        {
            _LcActivity = prActivity;
            UpdateFormData();
            return ShowDialog() == DialogResult.OK;
        }

        protected virtual void UpdateFormData()
        {
            textBoxName.Text = _LcActivity.ActivityName;
            if (!string.IsNullOrEmpty(_LcActivity.ActivityName))
                dateTimePickerDate.Value = _LcActivity.ActivityDate;
        }

        protected  void buttonOk_Click(object sender, EventArgs e)
        {
            SaveActivity();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveActivity()
        {
            string lcValidationMessage = GetDataValidationMessage();
            if (string.IsNullOrWhiteSpace(lcValidationMessage))
            {
                if (DialogResult.OK == MessageBox.Show("Activity is updated successfully.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    PushFormData();
                    DialogResult = DialogResult.OK;
                }
            }
            else
                MessageBox.Show(lcValidationMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected virtual string GetDataValidationMessage()
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
                return "Activity name cannnot be empty.";
            else if (numericUpDownCharge.Value == 0)
                return "Charge cannot be 0 NZ$.";
            else
                return string.Empty;
        }

        protected virtual void PushFormData()
        {
            _LcActivity.ActivityName = textBoxName.Text;
            _LcActivity.ActivityDate = dateTimePickerDate.Value;
        }
    }
}
