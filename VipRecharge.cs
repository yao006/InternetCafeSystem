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
    public partial class VipRecharge : Form
    {
        InternetUserBLL bll = new InternetUserBLL();
        public VipRecharge()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string vnum = txt_vnum.Text.Trim();
            int vbalance = int.Parse(txt_vbalance.Text.Trim());

            if (vnum != "")
            {
                if (bll.SelectIs(vnum))
                {
                    DataSet ds = bll.SelectLonelyVip(vnum);
                    int x = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    if (x == 0)
                    {
                        if (bll.AddOneMoney(vnum, vbalance))
                        {
                            MessageBox.Show("充值成功！您的当前余额为：" + vbalance, "提示");
                            txt_vbalance.Text = "";
                        }
                    }
                    else
                    {
                        if (bll.AddMoney(vnum, vbalance, x))
                        {
                            MessageBox.Show("充值成功！您的当前余额为：" + (vbalance + x), "提示");
                            txt_vbalance.Text = "";
                        }
                    }

                }
                else
                {
                    MessageBox.Show("此账号不存在，请重新输入！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    txt_vnum.Text = "";
                }
            }
            else
            {
                MessageBox.Show("账号或充值金额不能为空！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void txt_vbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                int len = txt_vbalance.Text.Length;
                if (len < 1 && e.KeyChar == '0')
                {
                    e.Handled = true;
                }
                else if ((e.KeyChar < '0'))
                {
                    e.Handled = true;
                }

            }

        }
    }
}
