namespace InternetCafeSystem
{
    partial class AddComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddComputer));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pcname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pcxianka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pctext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "电脑编号：";
            // 
            // txt_pcname
            // 
            this.txt_pcname.Location = new System.Drawing.Point(126, 116);
            this.txt_pcname.Name = "txt_pcname";
            this.txt_pcname.Size = new System.Drawing.Size(175, 25);
            this.txt_pcname.TabIndex = 1;
            this.txt_pcname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pcname_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "电脑显卡：";
            // 
            // txt_pcxianka
            // 
            this.txt_pcxianka.Location = new System.Drawing.Point(126, 193);
            this.txt_pcxianka.Name = "txt_pcxianka";
            this.txt_pcxianka.Size = new System.Drawing.Size(175, 25);
            this.txt_pcxianka.TabIndex = 1;
            this.txt_pcxianka.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "电脑描述：";
            // 
            // txt_pctext
            // 
            this.txt_pctext.Location = new System.Drawing.Point(126, 258);
            this.txt_pctext.Multiline = true;
            this.txt_pctext.Name = "txt_pctext";
            this.txt_pctext.Size = new System.Drawing.Size(175, 92);
            this.txt_pctext.TabIndex = 1;
            this.txt_pctext.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(121, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "添加电脑";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(126, 403);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(111, 39);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // AddComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 464);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_pctext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pcxianka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pcname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加电脑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pcname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pcxianka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pctext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ok;
    }
}