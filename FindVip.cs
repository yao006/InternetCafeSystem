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
    public partial class FindVip : Form
    {
        InternetUserBLL bll = new InternetUserBLL();
        public FindVip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vnum = txt_vname.Text.Trim();
            if (vnum != "")
            {
                DataSet ds = bll.FindVipByNum(vnum);
                dgv_vip.AllowUserToAddRows = false;
                dgv_vip.DataSource = ds.Tables[0].DefaultView;
                dgv_vip.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                DataSet ds = bll.SelectAllVip();
                dgv_vip.AllowUserToAddRows = false;
                dgv_vip.DataSource = ds.Tables[0].DefaultView;
                dgv_vip.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            string vnum = txt_vname.Text.Trim();
            DataSet ds = bll.SelectAllVip();
            dgv_vip.AllowUserToAddRows = false;
            dgv_vip.DataSource = ds.Tables[0].DefaultView;
            dgv_vip.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            txt_vname.Text = "";
        }

        private void FindVip_Load(object sender, EventArgs e)
        {
            DataSet ds = bll.SelectAllVip();
            dgv_vip.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
