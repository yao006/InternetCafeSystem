using InternetBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeSystem
{
    public partial class Login : Form
    {
        InternetUserBLL bll = new InternetUserBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_denglu_Click(object sender, EventArgs e)
        {
            string name = txt_username.Text.Trim();
            string pwd = txt_pwd.Text.Trim();
            if (name != "" || pwd != "")
            {
                if (bll.ManagerLogin(name, pwd))
                {
                    MessageBox.Show("登陆成功", "提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    InternetCafeMain icm= new InternetCafeMain();
                    this.Hide();
                    icm.Show();
                }
                else
                {
                    MessageBox.Show("账号或密码错误，请重新输入！", "提示", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        txt_username.Text = "";
                        txt_pwd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("账号或密码不能为空！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }


        private void btn_vipdenglu_Click(object sender, EventArgs e)
        {
            VipLogin vipLogin = new VipLogin();
            this.Hide();
            vipLogin.ShowDialog();
            this.Dispose();
        }
    }
}
