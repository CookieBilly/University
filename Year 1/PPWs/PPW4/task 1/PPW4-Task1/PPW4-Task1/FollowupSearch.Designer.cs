namespace PPW4_Task1
{
    partial class FollowupSearch
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSelection = new System.Windows.Forms.Label();
            this.lstSelection = new System.Windows.Forms.ListBox();
            this.lblFollowupCount = new System.Windows.Forms.Label();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(617, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 61);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Click to view incident report";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSelection.Location = new System.Drawing.Point(465, 19);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(166, 25);
            this.lblSelection.TabIndex = 13;
            this.lblSelection.Text = "Incident Selection";
            // 
            // lstSelection
            // 
            this.lstSelection.FormattingEnabled = true;
            this.lstSelection.Location = new System.Drawing.Point(470, 56);
            this.lstSelection.Name = "lstSelection";
            this.lstSelection.Size = new System.Drawing.Size(120, 95);
            this.lstSelection.TabIndex = 12;
            this.lstSelection.SelectedIndexChanged += new System.EventHandler(this.lstSelection_SelectedIndexChanged);
            // 
            // lblFollowupCount
            // 
            this.lblFollowupCount.AutoSize = true;
            this.lblFollowupCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFollowupCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblFollowupCount.Location = new System.Drawing.Point(12, 56);
            this.lblFollowupCount.Name = "lblFollowupCount";
            this.lblFollowupCount.Size = new System.Drawing.Size(103, 25);
            this.lblFollowupCount.TabIndex = 11;
            this.lblFollowupCount.Text = "#Number#";
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalNumber.Location = new System.Drawing.Point(12, 19);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(415, 25);
            this.lblTotalNumber.TabIndex = 10;
            this.lblTotalNumber.Text = "Total Number Of Incidents: Requiring Followup";
            // 
            // FollowupSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 175);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lstSelection);
            this.Controls.Add(this.lblFollowupCount);
            this.Controls.Add(this.lblTotalNumber);
            this.Name = "FollowupSearch";
            this.Text = "View people requiring a followup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.ListBox lstSelection;
        private System.Windows.Forms.Label lblFollowupCount;
        private System.Windows.Forms.Label lblTotalNumber;
    }
}