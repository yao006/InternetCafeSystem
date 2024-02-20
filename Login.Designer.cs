namespace InternetCafeSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_denglu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_vipdenglu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(287, 140);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(203, 25);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码：";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(287, 198);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(203, 25);
            this.txt_pwd.TabIndex = 1;
            this.txt_pwd.TabStop = false;
            this.txt_pwd.Text = "123456";
            // 
            // btn_denglu
            // 
            this.btn_denglu.Location = new System.Drawing.Point(207, 286);
            this.btn_denglu.Name = "btn_denglu";
            this.btn_denglu.Size = new System.Drawing.Size(112, 45);
            this.btn_denglu.TabIndex = 2;
            this.btn_denglu.Text = "管理员登录";
            this.btn_denglu.UseVisualStyleBackColor = true;
            this.btn_denglu.Click += new System.EventHandler(this.btn_denglu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(100, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(546, 60);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lucky网吧管理后台";
            // 
            // btn_vipdenglu
            // 
            this.btn_vipdenglu.Location = new System.Drawing.Point(452, 286);
            this.btn_vipdenglu.Name = "btn_vipdenglu";
            this.btn_vipdenglu.Size = new System.Drawing.Size(113, 45);
            this.btn_vipdenglu.TabIndex = 4;
            this.btn_vipdenglu.Text = "会员登录";
            this.btn_vipdenglu.UseVisualStyleBackColor = true;
            this.btn_vipdenglu.Click += new System.EventHandler(this.btn_vipdenglu_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 411);
            this.Controls.Add(this.btn_vipdenglu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_denglu);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky网吧管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button btn_denglu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_vipdenglu;
    }
}