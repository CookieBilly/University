namespace PPW4_Task1
{
    partial class Searchincident
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
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.lblIncidentCount = new System.Windows.Forms.Label();
            this.lstSelection = new System.Windows.Forms.ListBox();
            this.lblSelection = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalNumber.Location = new System.Drawing.Point(12, 20);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(245, 25);
            this.lblTotalNumber.TabIndex = 5;
            this.lblTotalNumber.Text = "Total Number Of Incidents:";
            // 
            // lblIncidentCount
            // 
            this.lblIncidentCount.AutoSize = true;
            this.lblIncidentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIncidentCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblIncidentCount.Location = new System.Drawing.Point(12, 57);
            this.lblIncidentCount.Name = "lblIncidentCount";
            this.lblIncidentCount.Size = new System.Drawing.Size(103, 25);
            this.lblIncidentCount.TabIndex = 6;
            this.lblIncidentCount.Text = "#Number#";
            // 
            // lstSelection
            // 
            this.lstSelection.FormattingEnabled = true;
            this.lstSelection.Location = new System.Drawing.Point(310, 57);
            this.lstSelection.Name = "lstSelection";
            this.lstSelection.Size = new System.Drawing.Size(120, 95);
            this.lstSelection.TabIndex = 7;
            this.lstSelection.SelectedIndexChanged += new System.EventHandler(this.lstSelection_SelectedIndexChanged);
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSelection.Location = new System.Drawing.Point(305, 20);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(166, 25);
            this.lblSelection.TabIndex = 8;
            this.lblSelection.Text = "Incident Selection";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(457, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 61);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Click to view incident report";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Searchincident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 178);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lstSelection);
            this.Controls.Add(this.lblIncidentCount);
            this.Controls.Add(this.lblTotalNumber);
            this.Name = "Searchincident";
            this.Text = "View an incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.Label lblIncidentCount;
        private System.Windows.Forms.ListBox lstSelection;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Button btnSearch;
    }
}