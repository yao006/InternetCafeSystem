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
    public partial class AddComputer : Form
    {
        InternetUserBLL bll = new InternetUserBLL();
        public AddComputer()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string pcname = txt_pcname.Text.Trim();
            string paxianka = txt_pcxianka.Text.Trim();
            string pcnode = txt_pctext.Text.Trim();
            if (pcname != "" && paxianka != "")
            {
                bool b = bll.AddComputer(pcname, paxianka, pcnode);
                if (b)
                {
                    MessageBox.Show("添加成功！新的电脑编号为：" + pcname, "提示");
                    txt_pcname.Text = "";
                    txt_pctext.Text = "";
                    txt_pcxianka.Text = "";
                }
                else
                {
                    MessageBox.Show("添加失败！请重试", "提示");
                }
            }
            else
            {
                MessageBox.Show("电脑编号或显卡不能为空！", "提示");
            }
        }

        private void txt_pcname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                int len = txt_pcname.Text.Length;
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
