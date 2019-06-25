using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace VehicleRentFleet
{
    public partial class FrmActivityDashboard : Form
    {
        private ClsVehicle _LcVehicle = new ClsVehicle();
        public FrmActivityDashboard()
        {
            InitializeComponent();
            SetButtonToolTips();
        }

        private void SetButtonToolTips()
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.buttonAddActivity, "Add New");
            ToolTip1.SetToolTip(this.buttonClose, "Close");
        }

        public void ShowDialog(ClsVehicle prVehicle)
        {
            _LcVehicle = prVehicle;
            LoadComboBoxValues();
            SetAllDefaultSettings();
            LoadActivityList(comboBoxSortBy.Text);
            ShowDialog();
        }

        private void LoadComboBoxValues()
        {
            comboBoxSortBy.DataSource = ClsActivity.SortType;
            comboBoxType.DataSource = ClsActivity.ActivityType;
        }

        private void SetAllDefaultSettings()
        {
            labelRegistrationNumber.Text = _LcVehicle.RegistrationNumber;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Text = "Hiring";
            comboBoxSortBy.Text = "Activity Name";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            ClsRentVehicleFleet.SaveData();
            richTextBoxViewActivity.Clear();
            Close();
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            AddActivity();
        }

        private void contextMenuActivity_Opening(object sender, CancelEventArgs e)
        {
            if (listBoxActivityList.SelectedItems.Count == 0)
                e.Cancel = true;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditActivity();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteActivity();
        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadActivityList(comboBoxSortBy.Text);
        }

        private void listBoxActivityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetQuickView();
        }

        private void LoadActivityList(string sortType)
        {
            List<ClsActivity> activityList = GetSortedList(_LcVehicle.VehicleActvityList, sortType);
            listBoxActivityList.DataSource = null;
            listBoxActivityList.DataSource = activityList;
            decimal cashFlow = _LcVehicle.CalculateVehicleCashFlow();
            labelVehicleCashFlow.Text = "Cashflow: " + cashFlow + " NZ$";
        }

        private List<ClsActivity> GetSortedList(List<ClsActivity> activityList, string sortType)
        {
            if("Activity Name" == sortType)
            {
                ClsSortByName sortByName = new ClsSortByName();
                activityList.Sort(sortByName);
            } else
            {
                ClsSortByDate sortByDate = new ClsSortByDate();
                activityList.Sort(sortByDate);
            }
            return activityList;
        }

        private void AddActivity()
        {
            string activityType = comboBoxType.Text;
            ClsActivity lcActivity = ClsActivity.NewActivity(activityType, _LcVehicle.DailyCharge);
            lcActivity.ActivityDate = DateTime.Now;
            if (lcActivity.ViewEditActivity())
            {
                lcActivity.ActivityUpdatedTime = DateTime.Now;
                _LcVehicle.VehicleActvityList.Add(lcActivity);
                LoadActivityList(comboBoxSortBy.Text);
            }
        }

        private void EditActivity()
        {
            ClsActivity lcActivity = (ClsActivity)listBoxActivityList.SelectedItem;
            if(lcActivity !=null && lcActivity.ViewEditActivity())
                LoadActivityList(comboBoxSortBy.Text);
            richTextBoxViewActivity.Clear();
            GetQuickView();
        }

        private void DeleteActivity()
        {
            ClsActivity lcActivity = (ClsActivity)listBoxActivityList.SelectedItem;
            if (DialogResult.OK == MessageBox.Show("Are you sure you want to delete?",
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                richTextBoxViewActivity.Clear();
                _LcVehicle.VehicleActvityList.Remove(lcActivity);
                LoadActivityList(comboBoxSortBy.Text);
                GetQuickView();
            }
        }

        private void GetQuickView()
        {
            ClsActivity lcActivity = (ClsActivity)listBoxActivityList.SelectedItem;
            if(lcActivity != null)
                richTextBoxViewActivity.Text = lcActivity.GetQuickView();
        }
    }
}
