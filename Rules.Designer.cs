namespace InternetCafeSystem
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.txt_rules = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_rules
            // 
            this.txt_rules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_rules.Enabled = false;
            this.txt_rules.Location = new System.Drawing.Point(0, 0);
            this.txt_rules.Multiline = true;
            this.txt_rules.Name = "txt_rules";
            this.txt_rules.Size = new System.Drawing.Size(418, 535);
            this.txt_rules.TabIndex = 0;
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 535);
            this.Controls.Add(this.txt_rules);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计费规则";
            this.Load += new System.EventHandler(this.Rules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_rules;
    }
}