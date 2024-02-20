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
    public partial class VipLogin : Form
    {
        InternetUserBLL bll= new InternetUserBLL();
        public VipLogin()
        {
            InitializeComponent();
        }

        private void btn_vipdenglu_Click(object sender, EventArgs e)
        {
            string vname=txt_vipuser.Text.Trim();
            string vpwd=txt_vippwd.Text.Trim();
            if (vname != "" || vpwd != "")
            {
                if (bll.VipLogin(vname, vpwd))
                {
                    MessageBox.Show("登陆成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VipMain vm= new VipMain(vname);
                    this.Hide();
                    vm.ShowDialog();
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("账号或密码错误，请重新输入！", "提示", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    txt_vipuser.Text = "";
                    txt_vippwd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("账号或密码不能为空！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void lkl_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l=new Login();
            this.Hide();
            l.Show();
        }

        private void btn_zhuce_Click(object sender, EventArgs e)
        {
            ZhuCe zhuCe = new ZhuCe();
            zhuCe.ShowDialog();
        }
    }
}
