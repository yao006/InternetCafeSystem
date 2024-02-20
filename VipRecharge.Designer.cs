namespace InternetCafeSystem
{
    partial class VipRecharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VipRecharge));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vbalance = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员账号";
            // 
            // txt_vnum
            // 
            this.txt_vnum.Location = new System.Drawing.Point(120, 133);
            this.txt_vnum.Name = "txt_vnum";
            this.txt_vnum.Size = new System.Drawing.Size(147, 25);
            this.txt_vnum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "充值金额";
            // 
            // txt_vbalance
            // 
            this.txt_vbalance.Location = new System.Drawing.Point(120, 238);
            this.txt_vbalance.Name = "txt_vbalance";
            this.txt_vbalance.Size = new System.Drawing.Size(147, 25);
            this.txt_vbalance.TabIndex = 1;
            this.txt_vbalance.TabStop = false;
            this.txt_vbalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vbalance_KeyPress);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(142, 319);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(104, 41);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // VipRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 482);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_vbalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_vnum);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VipRecharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员充值";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vbalance;
        private System.Windows.Forms.Button btn_ok;
    }
}