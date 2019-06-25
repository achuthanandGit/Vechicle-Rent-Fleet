namespace VehicleRentFleet
{
    partial class FrmVehicleFleet
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.buttonDeleteVehicle = new System.Windows.Forms.Button();
            this.buttonEditVehicle = new System.Windows.Forms.Button();
            this.labelVehicleDetail = new System.Windows.Forms.Label();
            this.richTextBoxQuickView = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFleetList = new System.Windows.Forms.ListBox();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.labelTotalCashFlow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(501, 381);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 35);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Quit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddVehicle.Location = new System.Drawing.Point(122, 381);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(75, 35);
            this.buttonAddVehicle.TabIndex = 17;
            this.buttonAddVehicle.Text = "Add";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // buttonDeleteVehicle
            // 
            this.buttonDeleteVehicle.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteVehicle.Location = new System.Drawing.Point(501, 229);
            this.buttonDeleteVehicle.Name = "buttonDeleteVehicle";
            this.buttonDeleteVehicle.Size = new System.Drawing.Size(80, 35);
            this.buttonDeleteVehicle.TabIndex = 16;
            this.buttonDeleteVehicle.Text = "Delete";
            this.buttonDeleteVehicle.UseVisualStyleBackColor = true;
            this.buttonDeleteVehicle.Click += new System.EventHandler(this.buttonDeleteVehicle_Click);
            // 
            // buttonEditVehicle
            // 
            this.buttonEditVehicle.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditVehicle.Location = new System.Drawing.Point(501, 173);
            this.buttonEditVehicle.Name = "buttonEditVehicle";
            this.buttonEditVehicle.Size = new System.Drawing.Size(80, 35);
            this.buttonEditVehicle.TabIndex = 15;
            this.buttonEditVehicle.Text = "Edit";
            this.buttonEditVehicle.UseVisualStyleBackColor = true;
            this.buttonEditVehicle.Click += new System.EventHandler(this.buttonEditVehicle_Click);
            // 
            // labelVehicleDetail
            // 
            this.labelVehicleDetail.AutoSize = true;
            this.labelVehicleDetail.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleDetail.Location = new System.Drawing.Point(245, 120);
            this.labelVehicleDetail.Name = "labelVehicleDetail";
            this.labelVehicleDetail.Size = new System.Drawing.Size(114, 22);
            this.labelVehicleDetail.TabIndex = 14;
            this.labelVehicleDetail.Text = "Vehicle Detail";
            // 
            // richTextBoxQuickView
            // 
            this.richTextBoxQuickView.Enabled = false;
            this.richTextBoxQuickView.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxQuickView.ForeColor = System.Drawing.SystemColors.Highlight;
            this.richTextBoxQuickView.Location = new System.Drawing.Point(247, 145);
            this.richTextBoxQuickView.Name = "richTextBoxQuickView";
            this.richTextBoxQuickView.Size = new System.Drawing.Size(226, 119);
            this.richTextBoxQuickView.TabIndex = 13;
            this.richTextBoxQuickView.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Available Vehicles";
            // 
            // listBoxFleetList
            // 
            this.listBoxFleetList.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFleetList.FormattingEnabled = true;
            this.listBoxFleetList.ItemHeight = 19;
            this.listBoxFleetList.Location = new System.Drawing.Point(30, 145);
            this.listBoxFleetList.Name = "listBoxFleetList";
            this.listBoxFleetList.Size = new System.Drawing.Size(167, 213);
            this.listBoxFleetList.TabIndex = 11;
            this.listBoxFleetList.SelectedIndexChanged += new System.EventHandler(this.listBoxFleetList_SelectedIndexChanged);
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormTitle.Location = new System.Drawing.Point(152, 35);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(312, 52);
            this.labelFormTitle.TabIndex = 10;
            this.labelFormTitle.Text = "Rent a Vehicle";
            // 
            // labelTotalCashFlow
            // 
            this.labelTotalCashFlow.AutoSize = true;
            this.labelTotalCashFlow.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCashFlow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTotalCashFlow.Location = new System.Drawing.Point(245, 333);
            this.labelTotalCashFlow.Name = "labelTotalCashFlow";
            this.labelTotalCashFlow.Size = new System.Drawing.Size(142, 22);
            this.labelTotalCashFlow.TabIndex = 19;
            this.labelTotalCashFlow.Text = "Total Cash Flow";
            // 
            // FrmVehicleFleet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.labelTotalCashFlow);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAddVehicle);
            this.Controls.Add(this.buttonDeleteVehicle);
            this.Controls.Add(this.buttonEditVehicle);
            this.Controls.Add(this.labelVehicleDetail);
            this.Controls.Add(this.richTextBoxQuickView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFleetList);
            this.Controls.Add(this.labelFormTitle);
            this.Name = "FrmVehicleFleet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Rent Fleet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.Button buttonDeleteVehicle;
        private System.Windows.Forms.Button buttonEditVehicle;
        private System.Windows.Forms.Label labelVehicleDetail;
        private System.Windows.Forms.RichTextBox richTextBoxQuickView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFleetList;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Label labelTotalCashFlow;
    }
}

