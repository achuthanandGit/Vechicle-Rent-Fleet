namespace VehicleRentFleet
{
    partial class FrmHiringActivity
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
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelHireCalculation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCharge
            // 
            this.numericUpDownCharge.Enabled = false;
            this.numericUpDownCharge.Location = new System.Drawing.Point(352, 300);
            this.numericUpDownCharge.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCharge.Size = new System.Drawing.Size(96, 27);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(482, 191);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(482, 139);
            // 
            // labelCharge
            // 
            this.labelCharge.Location = new System.Drawing.Point(26, 301);
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(102, 194);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(198, 191);
            this.dateTimePickerDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(95, 145);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(198, 140);
            // 
            // Activity
            // 
            this.Activity.Location = new System.Drawing.Point(148, 44);
            this.Activity.Size = new System.Drawing.Size(300, 50);
            this.Activity.Text = "Hiring Activity";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(198, 245);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerEndDate.TabIndex = 20;
            this.dateTimePickerEndDate.Value = new System.DateTime(2019, 6, 20, 12, 52, 53, 0);
            this.dateTimePickerEndDate.ValueChanged += new System.EventHandler(this.dateTimePickerEndDate_ValueChanged);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(66, 248);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(83, 22);
            this.labelEndDate.TabIndex = 19;
            this.labelEndDate.Text = "End Date";
            // 
            // labelHireCalculation
            // 
            this.labelHireCalculation.AutoSize = true;
            this.labelHireCalculation.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHireCalculation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelHireCalculation.Location = new System.Drawing.Point(199, 305);
            this.labelHireCalculation.Name = "labelHireCalculation";
            this.labelHireCalculation.Size = new System.Drawing.Size(0, 19);
            this.labelHireCalculation.TabIndex = 21;
            // 
            // FrmHiringActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(593, 357);
            this.Controls.Add(this.labelHireCalculation);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Name = "FrmHiringActivity";
            this.Text = "Hiring Activity";
            this.Controls.SetChildIndex(this.Activity, 0);
            this.Controls.SetChildIndex(this.textBoxName, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.dateTimePickerDate, 0);
            this.Controls.SetChildIndex(this.labelDate, 0);
            this.Controls.SetChildIndex(this.labelCharge, 0);
            this.Controls.SetChildIndex(this.buttonOk, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.numericUpDownCharge, 0);
            this.Controls.SetChildIndex(this.labelEndDate, 0);
            this.Controls.SetChildIndex(this.dateTimePickerEndDate, 0);
            this.Controls.SetChildIndex(this.labelHireCalculation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelHireCalculation;
    }
}
