namespace InternetCafeSystem
{
    partial class ZhuCe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZhuCe));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vipname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vippwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_zhuce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员账号：";
            // 
            // txt_vipname
            // 
            this.txt_vipname.Location = new System.Drawing.Point(171, 168);
            this.txt_vipname.Name = "txt_vipname";
            this.txt_vipname.Size = new System.Drawing.Size(157, 25);
            this.txt_vipname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "会员密码：";
            // 
            // txt_vippwd
            // 
            this.txt_vippwd.Location = new System.Drawing.Point(171, 244);
            this.txt_vippwd.Name = "txt_vippwd";
            this.txt_vippwd.PasswordChar = '*';
            this.txt_vippwd.Size = new System.Drawing.Size(157, 25);
            this.txt_vippwd.TabIndex = 1;
            this.txt_vippwd.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(110, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "会员注册";
            // 
            // btn_zhuce
            // 
            this.btn_zhuce.Location = new System.Drawing.Point(141, 329);
            this.btn_zhuce.Name = "btn_zhuce";
            this.btn_zhuce.Size = new System.Drawing.Size(136, 48);
            this.btn_zhuce.TabIndex = 3;
            this.btn_zhuce.Text = "注册";
            this.btn_zhuce.UseVisualStyleBackColor = true;
            this.btn_zhuce.Click += new System.EventHandler(this.btn_zhuce_Click);
            // 
            // ZhuCe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 459);
            this.Controls.Add(this.btn_zhuce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_vippwd);
            this.Controls.Add(this.txt_vipname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ZhuCe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vipname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vippwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_zhuce;
    }
}