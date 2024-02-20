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
using System.Xml.Linq;

namespace InternetCafeSystem
{
    public partial class FindComputer : Form
    {
        InternetUserBLL bll = new InternetUserBLL();
        public FindComputer()
        {
            InitializeComponent();
        }

        private void btn_chaxun_Click(object sender, EventArgs e)
        {
            string pcname = txt_cname.Text.Trim();
            if (pcname != "")
            {
                DataSet ds = bll.FindComputerByName(pcname);
                dgv_getcomputer.AllowUserToAddRows = false;
                dgv_getcomputer.DataSource = ds.Tables[0].DefaultView;
                dgv_getcomputer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                DataSet ds = bll.FindComputer();
                dgv_getcomputer.AllowUserToAddRows = false;
                dgv_getcomputer.DataSource = ds.Tables[0].DefaultView;
                dgv_getcomputer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            string pcname = txt_cname.Text.Trim();
            DataSet ds = bll.FindComputer();
            dgv_getcomputer.AllowUserToAddRows = false;
            dgv_getcomputer.DataSource = ds.Tables[0].DefaultView;
            dgv_getcomputer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            txt_cname.Text = "";
        }

        private void FindComputer_Load(object sender, EventArgs e)
        {
            DataSet ds = bll.FindComputer();
            dgv_getcomputer.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
