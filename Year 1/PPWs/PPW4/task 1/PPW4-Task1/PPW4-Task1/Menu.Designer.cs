namespace PPW4_Task1
{
    partial class Menu
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
            this.btnRecordIncident = new System.Windows.Forms.Button();
            this.picIncident = new System.Windows.Forms.PictureBox();
            this.btnViewIncidents = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIncident)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecordIncident
            // 
            this.btnRecordIncident.Location = new System.Drawing.Point(240, 146);
            this.btnRecordIncident.Name = "btnRecordIncident";
            this.btnRecordIncident.Size = new System.Drawing.Size(173, 28);
            this.btnRecordIncident.TabIndex = 0;
            this.btnRecordIncident.Text = "&Record an Incident";
            this.btnRecordIncident.UseVisualStyleBackColor = true;
            this.btnRecordIncident.Click += new System.EventHandler(this.btnRecordIncident_Click);
            // 
            // picIncident
            // 
            this.picIncident.Image = global::PPW4_Task1.Properties.Resources.shutterstock_133083437;
            this.picIncident.ImageLocation = "";
            this.picIncident.InitialImage = global::PPW4_Task1.Properties.Resources.tripping_and_realizing_no_one_saw_you;
            this.picIncident.Location = new System.Drawing.Point(12, 12);
            this.picIncident.Name = "picIncident";
            this.picIncident.Size = new System.Drawing.Size(203, 426);
            this.picIncident.TabIndex = 1;
            this.picIncident.TabStop = false;
            // 
            // btnViewIncidents
            // 
            this.btnViewIncidents.Location = new System.Drawing.Point(240, 180);
            this.btnViewIncidents.Name = "btnViewIncidents";
            this.btnViewIncidents.Size = new System.Drawing.Size(173, 28);
            this.btnViewIncidents.TabIndex = 1;
            this.btnViewIncidents.Text = "&View all incidents";
            this.btnViewIncidents.UseVisualStyleBackColor = true;
            this.btnViewIncidents.Click += new System.EventHandler(this.btnViewIncidents_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(240, 248);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(173, 28);
            this.btnStats.TabIndex = 3;
            this.btnStats.Text = "View &statistics";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "View incidents requiring &followup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnViewIncidents);
            this.Controls.Add(this.picIncident);
            this.Controls.Add(this.btnRecordIncident);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picIncident)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecordIncident;
        private System.Windows.Forms.PictureBox picIncident;
        private System.Windows.Forms.Button btnViewIncidents;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button button1;
    }
}