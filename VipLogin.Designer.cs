namespace InternetCafeSystem
{
    partial class VipLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VipLogin));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_vippwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vipuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_vipdenglu = new System.Windows.Forms.Button();
            this.lkl_back = new System.Windows.Forms.LinkLabel();
            this.btn_zhuce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(41, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(607, 60);
            this.label3.TabIndex = 8;
            this.label3.Text = "欢迎您来到Lucky网咖";
            // 
            // txt_vippwd
            // 
            this.txt_vippwd.Location = new System.Drawing.Point(257, 230);
            this.txt_vippwd.Name = "txt_vippwd";
            this.txt_vippwd.PasswordChar = '*';
            this.txt_vippwd.Size = new System.Drawing.Size(203, 25);
            this.txt_vippwd.TabIndex = 6;
            this.txt_vippwd.TabStop = false;
            this.txt_vippwd.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "会员密码：";
            // 
            // txt_vipuser
            // 
            this.txt_vipuser.Location = new System.Drawing.Point(257, 172);
            this.txt_vipuser.Name = "txt_vipuser";
            this.txt_vipuser.Size = new System.Drawing.Size(203, 25);
            this.txt_vipuser.TabIndex = 7;
            this.txt_vipuser.Text = "934499656";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "会员账号：";
            // 
            // btn_vipdenglu
            // 
            this.btn_vipdenglu.Location = new System.Drawing.Point(168, 297);
            this.btn_vipdenglu.Name = "btn_vipdenglu";
            this.btn_vipdenglu.Size = new System.Drawing.Size(132, 42);
            this.btn_vipdenglu.TabIndex = 9;
            this.btn_vipdenglu.Text = "登录";
            this.btn_vipdenglu.UseVisualStyleBackColor = true;
            this.btn_vipdenglu.Click += new System.EventHandler(this.btn_vipdenglu_Click);
            // 
            // lkl_back
            // 
            this.lkl_back.AutoSize = true;
            this.lkl_back.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lkl_back.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lkl_back.LinkColor = System.Drawing.Color.Red;
            this.lkl_back.Location = new System.Drawing.Point(23, 346);
            this.lkl_back.Name = "lkl_back";
            this.lkl_back.Size = new System.Drawing.Size(73, 30);
            this.lkl_back.TabIndex = 10;
            this.lkl_back.TabStop = true;
            this.lkl_back.Text = "返回";
            this.lkl_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_back_LinkClicked);
            // 
            // btn_zhuce
            // 
            this.btn_zhuce.Location = new System.Drawing.Point(404, 297);
            this.btn_zhuce.Name = "btn_zhuce";
            this.btn_zhuce.Size = new System.Drawing.Size(132, 42);
            this.btn_zhuce.TabIndex = 11;
            this.btn_zhuce.Text = "注册";
            this.btn_zhuce.UseVisualStyleBackColor = true;
            this.btn_zhuce.Click += new System.EventHandler(this.btn_zhuce_Click);
            // 
            // VipLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 395);
            this.Controls.Add(this.btn_zhuce);
            this.Controls.Add(this.lkl_back);
            this.Controls.Add(this.btn_vipdenglu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_vippwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_vipuser);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VipLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_vippwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vipuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_vipdenglu;
        private System.Windows.Forms.LinkLabel lkl_back;
        private System.Windows.Forms.Button btn_zhuce;
    }
}