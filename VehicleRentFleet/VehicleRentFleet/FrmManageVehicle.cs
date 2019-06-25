using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VehicleRentFleet
{
    public partial class FrmManageVehicle : Form
    {
        private ClsVehicle _LcVehicle;
        private string _FunctionMode;
        private int _AllowedRegNumberSize = 6;
        private FrmActivityDashboard _ActivityDashboard = new FrmActivityDashboard();

        public FrmManageVehicle()
        {
            InitializeComponent();
            SetButtonToolTips();
        }

        private void SetButtonToolTips()
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.buttonViewActivity, "Vehicle Activity Log");
            ToolTip1.SetToolTip(this.buttonOk, "Save");
            ToolTip1.SetToolTip(this.buttonCancel, "Cancel");
        }

        public bool ShowDialog(ClsVehicle prVehicle)
        {
            _LcVehicle = prVehicle;
            UpdateFormData();
            return ShowDialog() == DialogResult.OK;
        }

        private void UpdateFormData()
        {
            if (string.IsNullOrEmpty(_LcVehicle.RegistrationNumber))
                UpdateFormForAdd();
            else
                UpdateFormForEdit();
        }

        private void UpdateFormForEdit()
        {
            buttonViewActivity.Show();
            _FunctionMode = "edit";
            textBoxRegNumber.Text = _LcVehicle.RegistrationNumber;
            textBoxRegNumber.Enabled = false;
            textBoxMake.Text = _LcVehicle.VehicleMake;
            textBoxModel.Text = _LcVehicle.VehicleModel;
            numericUpDownYear.Value = _LcVehicle.VehicleYear;
            numericUpDownHire.Value = _LcVehicle.DailyCharge;
        }

        private void UpdateFormForAdd()
        {
            buttonViewActivity.Hide();;
            _FunctionMode = "add";
            textBoxRegNumber.Enabled = true;
            textBoxRegNumber.Clear();
            labelInvalidRegNo.Text = string.Empty;
            textBoxMake.Clear();
            textBoxModel.Clear();
            numericUpDownYear.Value = numericUpDownYear.Minimum;
            numericUpDownHire.Value = numericUpDownHire.Minimum;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if ("edit" == _FunctionMode)
                CheckAnyDataChange();
            else
                CheckAnyDataExists(); 
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if ("add" == _FunctionMode)
                CheckAndPushNewData();
            else
                CheckAndPushEditData();
        }

        private void buttonViewActivity_Click(object sender, EventArgs e)
        {
            _ActivityDashboard.ShowDialog(_LcVehicle);
        }

        private void textBoxRegNumber_TextChanged(object sender, EventArgs e)
        {
            IsRegistrationNumberValid();
        }

        private void CheckAnyDataChange()
        {
            if (IsDataChanged())
            {
                if (DialogResult.Yes == MessageBox.Show("Data has been changed. Are you sure you want to cancel without saving?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    Close();
                }
            }
            else
                Close();
        }

        private  bool IsDataChanged()
        {
            return (textBoxMake.Text != _LcVehicle.VehicleMake ||
               textBoxModel.Text != _LcVehicle.VehicleModel ||
               numericUpDownYear.Value != _LcVehicle.VehicleYear ||
               numericUpDownHire.Value != _LcVehicle.DailyCharge);
        }

        private void CheckAnyDataExists()
        {
            if (CheckNonEmptyFields())
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to cancel?", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    Close();
            }           
            else
                Close();
        }

        private bool CheckNonEmptyFields()
        {
            return ((!string.IsNullOrEmpty(textBoxRegNumber.Text)) ||
                (!string.IsNullOrEmpty(textBoxMake.Text)) ||
                (!string.IsNullOrEmpty(textBoxModel.Text)));
        }

        private void CheckAndPushEditData()
        {
            if (IsDataChanged())
            {
                if(CheckRequiredFields())
                {
                    MessageBox.Show("Please input valid data. All data are required.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    UpdateFleetList();
                }
            } else
                MessageBox.Show("No changes to Save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CheckAndPushNewData()
        {
            if (CheckRequiredFields())
                MessageBox.Show("Please input valid data. All data are required.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string regNumber = textBoxRegNumber.Text;
                if (ClsRentVehicleFleet.FleetList.ContainsKey(regNumber))
                {
                    if (DialogResult.OK == MessageBox.Show("Vehicle Registration Number already exists. Registration Number should be Unique", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error))
                    {
                        textBoxRegNumber.Clear();
                        textBoxRegNumber.Focus();
                    }
                } 
                else
                    {
                    UpdateFleetList();
                    }
            }
        }

        private void UpdateFleetList()
        {
            pushFormData();
            MessageBox.Show("Vehicle details has been updated successfully", "Information",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void pushFormData()
        {
            _LcVehicle.RegistrationNumber = textBoxRegNumber.Text;
            _LcVehicle.VehicleMake = textBoxMake.Text;
            _LcVehicle.VehicleModel = textBoxModel.Text;
            _LcVehicle.VehicleYear = Convert.ToInt32(numericUpDownYear.Value);
            _LcVehicle.DailyCharge = Convert.ToInt32(numericUpDownHire.Value);
        }

        private bool CheckRequiredFields()
        {
            return ((string.IsNullOrEmpty(textBoxRegNumber.Text)) ||
                 (string.IsNullOrEmpty(textBoxMake.Text)) ||
                 (string.IsNullOrEmpty(textBoxModel.Text)) ||
                 (0 == numericUpDownHire.Value));
        }

        private bool IsRegistrationNumberValid()
        {
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (!(r.IsMatch(textBoxRegNumber.Text)))
            {
                labelInvalidRegNo.Text = "Invalid Registration Number. Only Alphanumeric allowed.";
                buttonOk.Enabled = false;
                return false;
            }
            else if (_AllowedRegNumberSize != textBoxRegNumber.Text.Length)
            {
                labelInvalidRegNo.Text = "Registration number is a 6 charcater phrase.";
                buttonOk.Enabled = false;
                return false;
            }
            else
                labelInvalidRegNo.Text = String.Empty;
            buttonOk.Enabled = true;
            return true;
        }

    }
}