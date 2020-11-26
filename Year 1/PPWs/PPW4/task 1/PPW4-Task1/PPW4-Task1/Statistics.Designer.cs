namespace PPW4_Task1
{
    partial class Statistics
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAnIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllIncidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIncidentCount = new System.Windows.Forms.Label();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.lblFollowupAmount = new System.Windows.Forms.Label();
            this.lblRequireFollowup = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblPublicPercentage = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(410, 24);
            this.menuStrip2.TabIndex = 30;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAnIncidentToolStripMenuItem,
            this.viewStatisticsToolStripMenuItem,
            this.viewAllIncidentsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // createAnIncidentToolStripMenuItem
            // 
            this.createAnIncidentToolStripMenuItem.Name = "createAnIncidentToolStripMenuItem";
            this.createAnIncidentToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.createAnIncidentToolStripMenuItem.Text = "Create an Incident";
            // 
            // viewStatisticsToolStripMenuItem
            // 
            this.viewStatisticsToolStripMenuItem.Name = "viewStatisticsToolStripMenuItem";
            this.viewStatisticsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.viewStatisticsToolStripMenuItem.Text = "View statistics";
            // 
            // viewAllIncidentsToolStripMenuItem
            // 
            this.viewAllIncidentsToolStripMenuItem.Name = "viewAllIncidentsToolStripMenuItem";
            this.viewAllIncidentsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.viewAllIncidentsToolStripMenuItem.Text = "View all incidents";
            // 
            // lblIncidentCount
            // 
            this.lblIncidentCount.AutoSize = true;
            this.lblIncidentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIncidentCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblIncidentCount.Location = new System.Drawing.Point(12, 85);
            this.lblIncidentCount.Name = "lblIncidentCount";
            this.lblIncidentCount.Size = new System.Drawing.Size(103, 25);
            this.lblIncidentCount.TabIndex = 32;
            this.lblIncidentCount.Text = "#Number#";
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalNumber.Location = new System.Drawing.Point(12, 48);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(245, 25);
            this.lblTotalNumber.TabIndex = 31;
            this.lblTotalNumber.Text = "Total Number Of Incidents:";
            // 
            // lblFollowupAmount
            // 
            this.lblFollowupAmount.AutoSize = true;
            this.lblFollowupAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFollowupAmount.ForeColor = System.Drawing.Color.DimGray;
            this.lblFollowupAmount.Location = new System.Drawing.Point(12, 175);
            this.lblFollowupAmount.Name = "lblFollowupAmount";
            this.lblFollowupAmount.Size = new System.Drawing.Size(103, 25);
            this.lblFollowupAmount.TabIndex = 34;
            this.lblFollowupAmount.Text = "#Number#";
            // 
            // lblRequireFollowup
            // 
            this.lblRequireFollowup.AutoSize = true;
            this.lblRequireFollowup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRequireFollowup.Location = new System.Drawing.Point(12, 138);
            this.lblRequireFollowup.Name = "lblRequireFollowup";
            this.lblRequireFollowup.Size = new System.Drawing.Size(309, 25);
            this.lblRequireFollowup.TabIndex = 33;
            this.lblRequireFollowup.Text = "Total Incidents Requiring Followup";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPercentage.ForeColor = System.Drawing.Color.DimGray;
            this.lblPercentage.Location = new System.Drawing.Point(12, 270);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(103, 25);
            this.lblPercentage.TabIndex = 36;
            this.lblPercentage.Text = "#Number#";
            // 
            // lblPublicPercentage
            // 
            this.lblPublicPercentage.AutoSize = true;
            this.lblPublicPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPublicPercentage.Location = new System.Drawing.Point(12, 233);
            this.lblPublicPercentage.Name = "lblPublicPercentage";
            this.lblPublicPercentage.Size = new System.Drawing.Size(272, 25);
            this.lblPublicPercentage.TabIndex = 35;
            this.lblPublicPercentage.Text = "Percentage of public Incidents";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 316);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblPublicPercentage);
            this.Controls.Add(this.lblFollowupAmount);
            this.Controls.Add(this.lblRequireFollowup);
            this.Controls.Add(this.lblIncidentCount);
            this.Controls.Add(this.lblTotalNumber);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAnIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllIncidentsToolStripMenuItem;
        private System.Windows.Forms.Label lblIncidentCount;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.Label lblFollowupAmount;
        private System.Windows.Forms.Label lblRequireFollowup;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblPublicPercentage;
    }
}