namespace InternetCafeSystem
{
    partial class FindVip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindVip));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_vname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_vip = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vip)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_vname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 0;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(672, 9);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(104, 41);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_vname
            // 
            this.txt_vname.Location = new System.Drawing.Point(172, 19);
            this.txt_vname.Name = "txt_vname";
            this.txt_vname.Size = new System.Drawing.Size(334, 25);
            this.txt_vname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员账号：";
            // 
            // dgv_vip
            // 
            this.dgv_vip.AllowUserToAddRows = false;
            this.dgv_vip.AllowUserToDeleteRows = false;
            this.dgv_vip.AllowUserToResizeColumns = false;
            this.dgv_vip.AllowUserToResizeRows = false;
            this.dgv_vip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vip.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_vip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vip.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_vip.Location = new System.Drawing.Point(0, 64);
            this.dgv_vip.Name = "dgv_vip";
            this.dgv_vip.ReadOnly = true;
            this.dgv_vip.RowHeadersVisible = false;
            this.dgv_vip.RowHeadersWidth = 51;
            this.dgv_vip.RowTemplate.Height = 27;
            this.dgv_vip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vip.Size = new System.Drawing.Size(800, 386);
            this.dgv_vip.TabIndex = 1;
            // 
            // FindVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_vip);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FindVip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看会员";
            this.Load += new System.EventHandler(this.FindVip_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_vname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_vip;
        private System.Windows.Forms.Button btn_reset;
    }
}