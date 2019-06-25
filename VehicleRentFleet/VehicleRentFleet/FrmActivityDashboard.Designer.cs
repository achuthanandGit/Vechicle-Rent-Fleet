namespace VehicleRentFleet
{
    partial class FrmActivityDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelVehicleCashFlow = new System.Windows.Forms.Label();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.labelSortby = new System.Windows.Forms.Label();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.richTextBoxViewActivity = new System.Windows.Forms.RichTextBox();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuActivity = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelRegistrationNumber = new System.Windows.Forms.Label();
            this.labelActivityDashboard = new System.Windows.Forms.Label();
            this.listBoxActivityList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVehicleCashFlow
            // 
            this.labelVehicleCashFlow.AutoSize = true;
            this.labelVehicleCashFlow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleCashFlow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelVehicleCashFlow.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelVehicleCashFlow.Location = new System.Drawing.Point(639, 509);
            this.labelVehicleCashFlow.Name = "labelVehicleCashFlow";
            this.labelVehicleCashFlow.Size = new System.Drawing.Size(0, 22);
            this.labelVehicleCashFlow.TabIndex = 28;
            this.labelVehicleCashFlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelVehicleCashFlow.UseMnemonic = false;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSortBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "Activity Name",
            "Activity Date"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(114, 509);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(151, 27);
            this.comboBoxSortBy.TabIndex = 25;
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            // 
            // labelSortby
            // 
            this.labelSortby.AutoSize = true;
            this.labelSortby.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortby.Location = new System.Drawing.Point(29, 509);
            this.labelSortby.Name = "labelSortby";
            this.labelSortby.Size = new System.Drawing.Size(71, 22);
            this.labelSortby.TabIndex = 24;
            this.labelSortby.Text = "Sort by";
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddActivity.Location = new System.Drawing.Point(1090, 403);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(75, 35);
            this.buttonAddActivity.TabIndex = 23;
            this.buttonAddActivity.Text = "Add";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Hiring",
            "Service",
            "Re-location"});
            this.comboBoxType.Location = new System.Drawing.Point(1049, 347);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(116, 27);
            this.comboBoxType.TabIndex = 22;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(988, 347);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(48, 22);
            this.labelType.TabIndex = 21;
            this.labelType.Text = "Type";
            // 
            // richTextBoxViewActivity
            // 
            this.richTextBoxViewActivity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxViewActivity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBoxViewActivity.Location = new System.Drawing.Point(833, 169);
            this.richTextBoxViewActivity.Name = "richTextBoxViewActivity";
            this.richTextBoxViewActivity.ReadOnly = true;
            this.richTextBoxViewActivity.Size = new System.Drawing.Size(334, 156);
            this.richTextBoxViewActivity.TabIndex = 20;
            this.richTextBoxViewActivity.Text = "";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // contextMenuActivity
            // 
            this.contextMenuActivity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuActivity.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuActivity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuActivity.Name = "contextMenuActivity";
            this.contextMenuActivity.Size = new System.Drawing.Size(125, 52);
            this.contextMenuActivity.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuActivity_Opening);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(1090, 454);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 35);
            this.buttonClose.TabIndex = 27;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelRegistrationNumber
            // 
            this.labelRegistrationNumber.AutoSize = true;
            this.labelRegistrationNumber.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationNumber.Location = new System.Drawing.Point(37, 104);
            this.labelRegistrationNumber.Name = "labelRegistrationNumber";
            this.labelRegistrationNumber.Size = new System.Drawing.Size(0, 26);
            this.labelRegistrationNumber.TabIndex = 18;
            // 
            // labelActivityDashboard
            // 
            this.labelActivityDashboard.AutoSize = true;
            this.labelActivityDashboard.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivityDashboard.Location = new System.Drawing.Point(348, 38);
            this.labelActivityDashboard.Name = "labelActivityDashboard";
            this.labelActivityDashboard.Size = new System.Drawing.Size(395, 52);
            this.labelActivityDashboard.TabIndex = 17;
            this.labelActivityDashboard.Text = "Activity Dashboard";
            this.labelActivityDashboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxActivityList
            // 
            this.listBoxActivityList.ContextMenuStrip = this.contextMenuActivity;
            this.listBoxActivityList.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxActivityList.FormattingEnabled = true;
            this.listBoxActivityList.ItemHeight = 23;
            this.listBoxActivityList.Location = new System.Drawing.Point(42, 169);
            this.listBoxActivityList.Name = "listBoxActivityList";
            this.listBoxActivityList.Size = new System.Drawing.Size(753, 303);
            this.listBoxActivityList.TabIndex = 30;
            this.listBoxActivityList.SelectedIndexChanged += new System.EventHandler(this.listBoxActivityList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Activity Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Activity Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Activity Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Activity Cost (NZ$)";
            // 
            // FrmActivityDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxActivityList);
            this.Controls.Add(this.labelActivityDashboard);
            this.Controls.Add(this.labelVehicleCashFlow);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.labelSortby);
            this.Controls.Add(this.buttonAddActivity);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.richTextBoxViewActivity);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelRegistrationNumber);
            this.Name = "FrmActivityDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity Dashboard";
            this.contextMenuActivity.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVehicleCashFlow;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label labelSortby;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.RichTextBox richTextBoxViewActivity;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuActivity;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelRegistrationNumber;
        private System.Windows.Forms.Label labelActivityDashboard;
        private System.Windows.Forms.ListBox listBoxActivityList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}