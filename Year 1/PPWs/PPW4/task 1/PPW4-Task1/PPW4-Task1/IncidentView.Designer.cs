namespace PPW4_Task1
{
    partial class IncidentViewBox
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
            this.chkFollowup = new System.Windows.Forms.CheckBox();
            this.lblFollowup = new System.Windows.Forms.Label();
            this.chkTreatment = new System.Windows.Forms.CheckBox();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblIncidentType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblIncident = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIncidentType = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTreatmentDesc = new System.Windows.Forms.TextBox();
            this.lblTreatmentDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkFollowup
            // 
            this.chkFollowup.AutoSize = true;
            this.chkFollowup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chkFollowup.Enabled = false;
            this.chkFollowup.Location = new System.Drawing.Point(17, 724);
            this.chkFollowup.Name = "chkFollowup";
            this.chkFollowup.Size = new System.Drawing.Size(134, 17);
            this.chkFollowup.TabIndex = 32;
            this.chkFollowup.Text = "Follow-up was required";
            this.chkFollowup.UseVisualStyleBackColor = false;
            // 
            // lblFollowup
            // 
            this.lblFollowup.AutoSize = true;
            this.lblFollowup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFollowup.Location = new System.Drawing.Point(12, 696);
            this.lblFollowup.Name = "lblFollowup";
            this.lblFollowup.Size = new System.Drawing.Size(223, 25);
            this.lblFollowup.TabIndex = 31;
            this.lblFollowup.Text = "Was follow-up required?";
            // 
            // chkTreatment
            // 
            this.chkTreatment.AutoCheck = false;
            this.chkTreatment.AutoSize = true;
            this.chkTreatment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chkTreatment.Cursor = System.Windows.Forms.Cursors.No;
            this.chkTreatment.Enabled = false;
            this.chkTreatment.Location = new System.Drawing.Point(17, 497);
            this.chkTreatment.Name = "chkTreatment";
            this.chkTreatment.Size = new System.Drawing.Size(137, 17);
            this.chkTreatment.TabIndex = 30;
            this.chkTreatment.Text = "Treatment was required";
            this.chkTreatment.UseVisualStyleBackColor = false;
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTreatment.Location = new System.Drawing.Point(12, 469);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(226, 25);
            this.lblTreatment.TabIndex = 29;
            this.lblTreatment.Text = "Was treatment required?";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLocation.Location = new System.Drawing.Point(12, 399);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(185, 25);
            this.lblLocation.TabIndex = 28;
            this.lblLocation.Text = "Location Of Incident";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocation.Enabled = false;
            this.txtLocation.Location = new System.Drawing.Point(17, 427);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 27;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDescription.Location = new System.Drawing.Point(12, 247);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(208, 25);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "Description Of Incident";
            // 
            // lblIncidentType
            // 
            this.lblIncidentType.AutoSize = true;
            this.lblIncidentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIncidentType.Location = new System.Drawing.Point(12, 179);
            this.lblIncidentType.Name = "lblIncidentType";
            this.lblIncidentType.Size = new System.Drawing.Size(130, 25);
            this.lblIncidentType.TabIndex = 23;
            this.lblIncidentType.Text = "Incident Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblName.Location = new System.Drawing.Point(12, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 25);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Participant Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(17, 134);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 21;
            // 
            // lblIncident
            // 
            this.lblIncident.AutoSize = true;
            this.lblIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIncident.Location = new System.Drawing.Point(12, 42);
            this.lblIncident.Name = "lblIncident";
            this.lblIncident.Size = new System.Drawing.Size(110, 25);
            this.lblIncident.TabIndex = 20;
            this.lblIncident.Text = "Incident ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(17, 70);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(106, 20);
            this.txtID.TabIndex = 19;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIncidentType
            // 
            this.txtIncidentType.BackColor = System.Drawing.SystemColors.Window;
            this.txtIncidentType.Enabled = false;
            this.txtIncidentType.Location = new System.Drawing.Point(17, 207);
            this.txtIncidentType.Name = "txtIncidentType";
            this.txtIncidentType.ReadOnly = true;
            this.txtIncidentType.Size = new System.Drawing.Size(100, 20);
            this.txtIncidentType.TabIndex = 35;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(17, 275);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(221, 100);
            this.txtDescription.TabIndex = 37;
            // 
            // txtTreatmentDesc
            // 
            this.txtTreatmentDesc.BackColor = System.Drawing.SystemColors.Window;
            this.txtTreatmentDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTreatmentDesc.Enabled = false;
            this.txtTreatmentDesc.Location = new System.Drawing.Point(17, 561);
            this.txtTreatmentDesc.Multiline = true;
            this.txtTreatmentDesc.Name = "txtTreatmentDesc";
            this.txtTreatmentDesc.ReadOnly = true;
            this.txtTreatmentDesc.Size = new System.Drawing.Size(221, 100);
            this.txtTreatmentDesc.TabIndex = 38;
            // 
            // lblTreatmentDescription
            // 
            this.lblTreatmentDescription.AutoSize = true;
            this.lblTreatmentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTreatmentDescription.Location = new System.Drawing.Point(12, 533);
            this.lblTreatmentDescription.Name = "lblTreatmentDescription";
            this.lblTreatmentDescription.Size = new System.Drawing.Size(229, 25);
            this.lblTreatmentDescription.TabIndex = 39;
            this.lblTreatmentDescription.Text = "Description Of Treatment";
            // 
            // IncidentViewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 775);
            this.Controls.Add(this.lblTreatmentDescription);
            this.Controls.Add(this.txtTreatmentDesc);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtIncidentType);
            this.Controls.Add(this.chkFollowup);
            this.Controls.Add(this.lblFollowup);
            this.Controls.Add(this.chkTreatment);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblIncidentType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblIncident);
            this.Controls.Add(this.txtID);
            this.Name = "IncidentViewBox";
            this.Text = "Viewing incident Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkFollowup;
        private System.Windows.Forms.Label lblFollowup;
        private System.Windows.Forms.CheckBox chkTreatment;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblIncidentType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblIncident;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIncidentType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTreatmentDesc;
        private System.Windows.Forms.Label lblTreatmentDescription;
    }
}