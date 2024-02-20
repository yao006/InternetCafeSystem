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
    public partial class ZhuCe : Form
    {
        InternetUserBLL bll = new InternetUserBLL();
        public ZhuCe()
        {
            InitializeComponent();
        }

        private void btn_zhuce_Click(object sender, EventArgs e)
        {
            string vname = txt_vipname.Text.Trim();
            string vpwd = txt_vippwd.Text.Trim();
            if (vname != "" || vpwd != "")
            {
                if (bll.SelectIs(vname))
                {
                    MessageBox.Show("该账号已被注册，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_vipname.Text = "";
                }
                else
                {
                    if (vname.Length >= 8)
                    {
                        bll.AddUsers(vname, vpwd);
                        MessageBox.Show("注册成功！" + "您的账号为： " + vname + "  请牢记", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
