namespace PPW4_Task1
{
    partial class IncidentRecord
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIncidentType = new System.Windows.Forms.Label();
            this.cmbIncidentType = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.chkTreatment = new System.Windows.Forms.CheckBox();
            this.chkFollowup = new System.Windows.Forms.CheckBox();
            this.lblFollowup = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(18, 70);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(53, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblID.Location = new System.Drawing.Point(13, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(110, 25);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Incident ID:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(18, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblName.Location = new System.Drawing.Point(13, 115);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Participant Name";
            // 
            // lblIncidentType
            // 
            this.lblIncidentType.AutoSize = true;
            this.lblIncidentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIncidentType.Location = new System.Drawing.Point(13, 188);
            this.lblIncidentType.Name = "lblIncidentType";
            this.lblIncidentType.Size = new System.Drawing.Size(130, 25);
            this.lblIncidentType.TabIndex = 6;
            this.lblIncidentType.Text = "Incident Type";
            // 
            // cmbIncidentType
            // 
            this.cmbIncidentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncidentType.FormattingEnabled = true;
            this.cmbIncidentType.Location = new System.Drawing.Point(18, 217);
            this.cmbIncidentType.Name = "cmbIncidentType";
            this.cmbIncidentType.Size = new System.Drawing.Size(121, 21);
            this.cmbIncidentType.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(18, 292);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 93);
            this.txtDescription.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDescription.Location = new System.Drawing.Point(13, 264);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(208, 25);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description Of Incident";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLocation.Location = new System.Drawing.Point(13, 404);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(185, 25);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Location Of Incident";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(18, 435);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 10;
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTreatment.Location = new System.Drawing.Point(13, 477);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(226, 25);
            this.lblTreatment.TabIndex = 12;
            this.lblTreatment.Text = "Was treatment required?";
            // 
            // chkTreatment
            // 
            this.chkTreatment.AutoSize = true;
            this.chkTreatment.Location = new System.Drawing.Point(18, 505);
            this.chkTreatment.Name = "chkTreatment";
            this.chkTreatment.Size = new System.Drawing.Size(137, 17);
            this.chkTreatment.TabIndex = 13;
            this.chkTreatment.Text = "Treatment was required";
            this.chkTreatment.UseVisualStyleBackColor = true;
            // 
            // chkFollowup
            // 
            this.chkFollowup.AutoSize = true;
            this.chkFollowup.Location = new System.Drawing.Point(18, 572);
            this.chkFollowup.Name = "chkFollowup";
            this.chkFollowup.Size = new System.Drawing.Size(134, 17);
            this.chkFollowup.TabIndex = 15;
            this.chkFollowup.Text = "Follow-up was required";
            this.chkFollowup.UseVisualStyleBackColor = true;
            // 
            // lblFollowup
            // 
            this.lblFollowup.AutoSize = true;
            this.lblFollowup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFollowup.Location = new System.Drawing.Point(13, 544);
            this.lblFollowup.Name = "lblFollowup";
            this.lblFollowup.Size = new System.Drawing.Size(223, 25);
            this.lblFollowup.TabIndex = 14;
            this.lblFollowup.Text = "Was follow-up required?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(18, 617);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 44);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit Incident";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(159, 617);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 44);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // IncidentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 681);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkFollowup);
            this.Controls.Add(this.lblFollowup);
            this.Controls.Add(this.chkTreatment);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbIncidentType);
            this.Controls.Add(this.lblIncidentType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Name = "IncidentRecord";
            this.Text = "Record an incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIncidentType;
        private System.Windows.Forms.ComboBox cmbIncidentType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.CheckBox chkTreatment;
        private System.Windows.Forms.CheckBox chkFollowup;
        private System.Windows.Forms.Label lblFollowup;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }
}