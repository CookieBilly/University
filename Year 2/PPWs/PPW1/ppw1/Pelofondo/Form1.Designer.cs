namespace Pelofondo
{
    partial class Form1
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
            this.cboSelector = new System.Windows.Forms.ComboBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboSelector
            // 
            this.cboSelector.FormattingEnabled = true;
            this.cboSelector.Location = new System.Drawing.Point(7, 41);
            this.cboSelector.Name = "cboSelector";
            this.cboSelector.Size = new System.Drawing.Size(121, 24);
            this.cboSelector.TabIndex = 0;
            this.cboSelector.SelectedIndexChanged += new System.EventHandler(this.cboSelector_SelectedIndexChanged);
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 16;
            this.lbResults.Location = new System.Drawing.Point(147, 41);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(1547, 308);
            this.lbResults.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Session Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Session List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.cboSelector);
            this.Name = "Form1";
            this.Text = "Session List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelector;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

