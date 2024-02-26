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
    public partial class InternetCafeMain : Form
    {
        InternetUserBLL bll = new InternetUserBLL();
        public InternetCafeMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ZhuCe zc = new ZhuCe();
            zc.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FindVip fv = new FindVip();
            fv.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            VipRecharge vr = new VipRecharge();
            vr.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AddComputer ac = new AddComputer();
            ac.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FindComputer fc = new FindComputer();
            fc.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Record r = new Record();
            r.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            AddAdministrator ac = new AddAdministrator();
            ac.ShowDialog();
        }
    }
}
