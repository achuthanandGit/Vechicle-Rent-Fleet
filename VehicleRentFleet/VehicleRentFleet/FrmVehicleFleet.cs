using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VehicleRentFleet
{
    public partial class FrmVehicleFleet : Form
    {
        public FrmVehicleFleet()
        {
            RetrieveVehicleData();
            InitializeComponent();
            UpdateVehicleFleetList();
            SetButtonToolTips();
        }

        private void SetButtonToolTips()
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.buttonAddVehicle, "Add New");
            ToolTip1.SetToolTip(this.buttonEditVehicle, "Edit");
            ToolTip1.SetToolTip(this.buttonDeleteVehicle, "Delete");
            ToolTip1.SetToolTip(this.buttonExit, "Quit");
        }

        private void RetrieveVehicleData()
        {
            try
            {
                ClsRentVehicleFleet.RetrieveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ClsRentVehicleFleet.SaveData();
            Close();
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicle();
        }

        private void buttonDeleteVehicle_Click(object sender, EventArgs e)
        {
            DeleteVehicle();
        }

        private void buttonEditVehicle_Click(object sender, EventArgs e)
        {
            EditVehicle();
        }

        private void listBoxFleetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vehicleRegNo = listBoxFleetList.SelectedItem.ToString();
            ClsVehicle lcVehicle = ClsRentVehicleFleet.FleetList[vehicleRegNo];
            richTextBoxQuickView.Text = lcVehicle.GetQuickView();
        }

        private void EditVehicle()
        {
            String vehicleRegNo = listBoxFleetList.SelectedItem.ToString();
            ClsVehicle lcVehicle = ClsRentVehicleFleet.FleetList[vehicleRegNo];
            lcVehicle.ViewEditVehicle();
            UpdateVehicleFleetList();
        }

        private void DeleteVehicle()
        {
            String vehicleRegNo = listBoxFleetList.SelectedItem.ToString();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the vehicle?", 
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == dialogResult &&
                ClsRentVehicleFleet.FleetList.Remove(vehicleRegNo))
                UpdateVehicleFleetList();
        }

        private void AddVehicle()
        {
            ClsVehicle lcVehicle = new ClsVehicle();
            if (lcVehicle != null && lcVehicle.ViewEditVehicle())
            {
                ClsRentVehicleFleet.FleetList.Add(lcVehicle.RegistrationNumber, lcVehicle);
                UpdateVehicleFleetList();
            }
        }

        private void UpdateVehicleFleetList()
        {
            List<String> fleetList = ClsRentVehicleFleet.FleetList.Keys.ToList();
            listBoxFleetList.DataSource = fleetList;
            decimal cashFlow = ClsRentVehicleFleet.CalculateFleetCashFlow();
            labelTotalCashFlow.Text = "Total Cashflow: "+cashFlow+ " NZ$";
            if (!fleetList.Any())
            {
                listBoxFleetList.DataSource = null;
                listBoxFleetList.Items.Clear();
                richTextBoxQuickView.Clear();
                DisableEditDeleteButton(false);
            }
            else
                DisableEditDeleteButton(true);
        }

        private void DisableEditDeleteButton(bool status)
        {
            buttonEditVehicle.Enabled = status;
            buttonDeleteVehicle.Enabled = status;
        }
    }
}
