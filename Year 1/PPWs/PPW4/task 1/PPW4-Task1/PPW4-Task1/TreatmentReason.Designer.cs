namespace PPW4_Task1
{
    partial class TreatmentReason
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
            this.txtTreatmentGiven = new System.Windows.Forms.TextBox();
            this.lblTreatmentGiven = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTreatmentGiven
            // 
            this.txtTreatmentGiven.Location = new System.Drawing.Point(12, 35);
            this.txtTreatmentGiven.Multiline = true;
            this.txtTreatmentGiven.Name = "txtTreatmentGiven";
            this.txtTreatmentGiven.Size = new System.Drawing.Size(304, 167);
            this.txtTreatmentGiven.TabIndex = 0;
            // 
            // lblTreatmentGiven
            // 
            this.lblTreatmentGiven.AutoSize = true;
            this.lblTreatmentGiven.Location = new System.Drawing.Point(9, 19);
            this.lblTreatmentGiven.Name = "lblTreatmentGiven";
            this.lblTreatmentGiven.Size = new System.Drawing.Size(158, 13);
            this.lblTreatmentGiven.TabIndex = 1;
            this.lblTreatmentGiven.Text = "Please describe treatment given";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 215);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // TreatmentReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 250);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTreatmentGiven);
            this.Controls.Add(this.txtTreatmentGiven);
            this.Name = "TreatmentReason";
            this.Text = "Please describe treatment given";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTreatmentGiven;
        private System.Windows.Forms.Label lblTreatmentGiven;
        private System.Windows.Forms.Button btnSubmit;
    }
}