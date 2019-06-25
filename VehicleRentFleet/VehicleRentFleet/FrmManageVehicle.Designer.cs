namespace VehicleRentFleet
{
    partial class FrmManageVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageVehicle));
            this.labelInvalidRegNo = new System.Windows.Forms.Label();
            this.labelHire = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelMake = new System.Windows.Forms.Label();
            this.labelRegNo = new System.Windows.Forms.Label();
            this.numericUpDownHire = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.textBoxRegNumber = new System.Windows.Forms.TextBox();
            this.buttonViewActivity = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelManageVehicleTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInvalidRegNo
            // 
            this.labelInvalidRegNo.AutoSize = true;
            this.labelInvalidRegNo.BackColor = System.Drawing.Color.Transparent;
            this.labelInvalidRegNo.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidRegNo.ForeColor = System.Drawing.Color.DarkRed;
            this.labelInvalidRegNo.Location = new System.Drawing.Point(248, 172);
            this.labelInvalidRegNo.Name = "labelInvalidRegNo";
            this.labelInvalidRegNo.Size = new System.Drawing.Size(0, 16);
            this.labelInvalidRegNo.TabIndex = 40;
            // 
            // labelHire
            // 
            this.labelHire.AutoSize = true;
            this.labelHire.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHire.ForeColor = System.Drawing.Color.Black;
            this.labelHire.Location = new System.Drawing.Point(25, 364);
            this.labelHire.Name = "labelHire";
            this.labelHire.Size = new System.Drawing.Size(179, 22);
            this.labelHire.TabIndex = 39;
            this.labelHire.Text = "Hire per date (NZ$)";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.Color.Black;
            this.labelYear.Location = new System.Drawing.Point(159, 311);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(45, 22);
            this.labelYear.TabIndex = 38;
            this.labelYear.Text = "Year";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.ForeColor = System.Drawing.Color.Black;
            this.labelModel.Location = new System.Drawing.Point(148, 256);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(56, 22);
            this.labelModel.TabIndex = 37;
            this.labelModel.Text = "Model";
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMake.ForeColor = System.Drawing.Color.Black;
            this.labelMake.Location = new System.Drawing.Point(159, 199);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(50, 22);
            this.labelMake.TabIndex = 36;
            this.labelMake.Text = "Make";
            // 
            // labelRegNo
            // 
            this.labelRegNo.AutoSize = true;
            this.labelRegNo.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegNo.ForeColor = System.Drawing.Color.Black;
            this.labelRegNo.Location = new System.Drawing.Point(36, 143);
            this.labelRegNo.Name = "labelRegNo";
            this.labelRegNo.Size = new System.Drawing.Size(173, 22);
            this.labelRegNo.TabIndex = 35;
            this.labelRegNo.Text = "Registration Number";
            // 
            // numericUpDownHire
            // 
            this.numericUpDownHire.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHire.Location = new System.Drawing.Point(252, 365);
            this.numericUpDownHire.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownHire.Name = "numericUpDownHire";
            this.numericUpDownHire.Size = new System.Drawing.Size(97, 27);
            this.numericUpDownHire.TabIndex = 34;
            this.numericUpDownHire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownYear.Location = new System.Drawing.Point(252, 311);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(100, 27);
            this.numericUpDownYear.TabIndex = 33;
            this.numericUpDownYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(252, 255);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(167, 27);
            this.textBoxModel.TabIndex = 32;
            // 
            // textBoxMake
            // 
            this.textBoxMake.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMake.Location = new System.Drawing.Point(249, 198);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(170, 27);
            this.textBoxMake.TabIndex = 31;
            // 
            // textBoxRegNumber
            // 
            this.textBoxRegNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegNumber.Location = new System.Drawing.Point(249, 143);
            this.textBoxRegNumber.Name = "textBoxRegNumber";
            this.textBoxRegNumber.Size = new System.Drawing.Size(142, 27);
            this.textBoxRegNumber.TabIndex = 30;
            this.textBoxRegNumber.TextChanged += new System.EventHandler(this.textBoxRegNumber_TextChanged);
            // 
            // buttonViewActivity
            // 
            this.buttonViewActivity.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewActivity.Image = ((System.Drawing.Image)(resources.GetObject("buttonViewActivity.Image")));
            this.buttonViewActivity.Location = new System.Drawing.Point(543, 357);
            this.buttonViewActivity.Name = "buttonViewActivity";
            this.buttonViewActivity.Size = new System.Drawing.Size(34, 35);
            this.buttonViewActivity.TabIndex = 29;
            this.buttonViewActivity.UseVisualStyleBackColor = true;
            this.buttonViewActivity.Click += new System.EventHandler(this.buttonViewActivity_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(497, 199);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 35);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(497, 135);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(80, 35);
            this.buttonOk.TabIndex = 27;
            this.buttonOk.Text = "Save";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelManageVehicleTitle
            // 
            this.labelManageVehicleTitle.AutoSize = true;
            this.labelManageVehicleTitle.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageVehicleTitle.Location = new System.Drawing.Point(133, 36);
            this.labelManageVehicleTitle.Name = "labelManageVehicleTitle";
            this.labelManageVehicleTitle.Size = new System.Drawing.Size(318, 52);
            this.labelManageVehicleTitle.TabIndex = 26;
            this.labelManageVehicleTitle.Text = "Manage Vehicle";
            // 
            // FrmManageVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 423);
            this.Controls.Add(this.labelInvalidRegNo);
            this.Controls.Add(this.labelHire);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.labelRegNo);
            this.Controls.Add(this.numericUpDownHire);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.textBoxRegNumber);
            this.Controls.Add(this.buttonViewActivity);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelManageVehicleTitle);
            this.Name = "FrmManageVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInvalidRegNo;
        private System.Windows.Forms.Label labelHire;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelRegNo;
        private System.Windows.Forms.NumericUpDown numericUpDownHire;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.TextBox textBoxRegNumber;
        private System.Windows.Forms.Button buttonViewActivity;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        protected System.Windows.Forms.Label labelManageVehicleTitle;
    }
}