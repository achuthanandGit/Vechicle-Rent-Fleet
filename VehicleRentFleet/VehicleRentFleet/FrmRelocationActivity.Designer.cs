namespace VehicleRentFleet
{
    partial class FrmRelocationActivity
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
            this.numericUpDownKmInvolved = new System.Windows.Forms.NumericUpDown();
            this.labelKmInvolvedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKmInvolved)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCharge
            // 
            this.numericUpDownCharge.Location = new System.Drawing.Point(204, 299);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(490, 188);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(490, 136);
            // 
            // labelCharge
            // 
            this.labelCharge.Location = new System.Drawing.Point(37, 299);
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(113, 188);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(204, 188);
            this.dateTimePickerDate.Size = new System.Drawing.Size(249, 27);
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(106, 142);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(204, 137);
            // 
            // Activity
            // 
            this.Activity.Location = new System.Drawing.Point(109, 41);
            this.Activity.Size = new System.Drawing.Size(382, 50);
            this.Activity.Text = "Relocation Activity";
            // 
            // numericUpDownKmInvolved
            // 
            this.numericUpDownKmInvolved.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownKmInvolved.Location = new System.Drawing.Point(204, 242);
            this.numericUpDownKmInvolved.Name = "numericUpDownKmInvolved";
            this.numericUpDownKmInvolved.Size = new System.Drawing.Size(115, 27);
            this.numericUpDownKmInvolved.TabIndex = 20;
            this.numericUpDownKmInvolved.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelKmInvolvedLabel
            // 
            this.labelKmInvolvedLabel.AutoSize = true;
            this.labelKmInvolvedLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmInvolvedLabel.Location = new System.Drawing.Point(51, 241);
            this.labelKmInvolvedLabel.Name = "labelKmInvolvedLabel";
            this.labelKmInvolvedLabel.Size = new System.Drawing.Size(109, 22);
            this.labelKmInvolvedLabel.TabIndex = 19;
            this.labelKmInvolvedLabel.Text = "KM invlolved";
            // 
            // FrmRelocationActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(600, 355);
            this.Controls.Add(this.numericUpDownKmInvolved);
            this.Controls.Add(this.labelKmInvolvedLabel);
            this.Name = "FrmRelocationActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relocation Activity";
            this.Controls.SetChildIndex(this.Activity, 0);
            this.Controls.SetChildIndex(this.textBoxName, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.dateTimePickerDate, 0);
            this.Controls.SetChildIndex(this.labelDate, 0);
            this.Controls.SetChildIndex(this.labelCharge, 0);
            this.Controls.SetChildIndex(this.buttonOk, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.numericUpDownCharge, 0);
            this.Controls.SetChildIndex(this.labelKmInvolvedLabel, 0);
            this.Controls.SetChildIndex(this.numericUpDownKmInvolved, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKmInvolved)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownKmInvolved;
        private System.Windows.Forms.Label labelKmInvolvedLabel;
    }
}
