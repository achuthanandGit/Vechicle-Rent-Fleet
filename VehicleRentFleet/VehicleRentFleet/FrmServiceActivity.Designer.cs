namespace VehicleRentFleet
{
    partial class FrmServiceActivity
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
            this.richTextBoxServiceBrief = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCharge
            // 
            this.numericUpDownCharge.Location = new System.Drawing.Point(201, 362);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(515, 185);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(515, 133);
            // 
            // labelCharge
            // 
            this.labelCharge.Location = new System.Drawing.Point(31, 361);
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(107, 185);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(201, 185);
            this.dateTimePickerDate.Size = new System.Drawing.Size(282, 27);
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(100, 134);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(201, 134);
            // 
            // Activity
            // 
            this.Activity.Location = new System.Drawing.Point(145, 40);
            this.Activity.Size = new System.Drawing.Size(320, 50);
            this.Activity.Text = "Service Activity";
            // 
            // richTextBoxServiceBrief
            // 
            this.richTextBoxServiceBrief.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxServiceBrief.Location = new System.Drawing.Point(201, 243);
            this.richTextBoxServiceBrief.Name = "richTextBoxServiceBrief";
            this.richTextBoxServiceBrief.Size = new System.Drawing.Size(227, 96);
            this.richTextBoxServiceBrief.TabIndex = 20;
            this.richTextBoxServiceBrief.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Service Brief";
            // 
            // FrmServiceActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(614, 416);
            this.Controls.Add(this.richTextBoxServiceBrief);
            this.Controls.Add(this.label1);
            this.Name = "FrmServiceActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Activity";
            this.Controls.SetChildIndex(this.Activity, 0);
            this.Controls.SetChildIndex(this.textBoxName, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.dateTimePickerDate, 0);
            this.Controls.SetChildIndex(this.labelDate, 0);
            this.Controls.SetChildIndex(this.labelCharge, 0);
            this.Controls.SetChildIndex(this.buttonOk, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.numericUpDownCharge, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.richTextBoxServiceBrief, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxServiceBrief;
        private System.Windows.Forms.Label label1;
    }
}
