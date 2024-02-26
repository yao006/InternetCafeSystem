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
    public partial class AddAdministrator : Form
    {
        InternetUserBLL bll = new InternetUserBLL(); 
        public AddAdministrator()
        {
            InitializeComponent();
        }

        private void btn_tijiao_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string pwd = txt_password.Text.Trim();
            if (name != "" || pwd != "")
            {
                if (bll.SelectIsManager(name))
                {
                    MessageBox.Show("该账号已被注册，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_name.Text = "";
                }
                else
                {
                    if (name.Length >= 8)
                    {
                        bll.AddManager(name, pwd);
                        MessageBox.Show("注册成功！" + "您的账号为： " + name + "  请牢记", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("您的账号过短，请输入大于等于8位字符", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("账号或密码不能为空！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
    }
}
