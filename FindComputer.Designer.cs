namespace InternetCafeSystem
{
    partial class FindComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindComputer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_chaxun = new System.Windows.Forms.Button();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_getcomputer = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_getcomputer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_chaxun);
            this.panel1.Controls.Add(this.txt_cname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 0;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(629, 15);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(105, 36);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_chaxun
            // 
            this.btn_chaxun.Location = new System.Drawing.Point(490, 15);
            this.btn_chaxun.Name = "btn_chaxun";
            this.btn_chaxun.Size = new System.Drawing.Size(104, 36);
            this.btn_chaxun.TabIndex = 2;
            this.btn_chaxun.Text = "查询";
            this.btn_chaxun.UseVisualStyleBackColor = true;
            this.btn_chaxun.Click += new System.EventHandler(this.btn_chaxun_Click);
            // 
            // txt_cname
            // 
            this.txt_cname.Location = new System.Drawing.Point(155, 20);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(298, 25);
            this.txt_cname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "电脑编号：";
            // 
            // dgv_getcomputer
            // 
            this.dgv_getcomputer.AllowUserToAddRows = false;
            this.dgv_getcomputer.AllowUserToDeleteRows = false;
            this.dgv_getcomputer.AllowUserToResizeColumns = false;
            this.dgv_getcomputer.AllowUserToResizeRows = false;
            this.dgv_getcomputer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_getcomputer.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_getcomputer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_getcomputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_getcomputer.Location = new System.Drawing.Point(0, 63);
            this.dgv_getcomputer.Name = "dgv_getcomputer";
            this.dgv_getcomputer.ReadOnly = true;
            this.dgv_getcomputer.RowHeadersVisible = false;
            this.dgv_getcomputer.RowHeadersWidth = 51;
            this.dgv_getcomputer.RowTemplate.Height = 27;
            this.dgv_getcomputer.Size = new System.Drawing.Size(800, 387);
            this.dgv_getcomputer.TabIndex = 1;
            // 
            // FindComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_getcomputer);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FindComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看电脑";
            this.Load += new System.EventHandler(this.FindComputer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_getcomputer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_chaxun;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_getcomputer;
        private System.Windows.Forms.Button btn_reset;
    }
}