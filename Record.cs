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
    public partial class Record : Form
    {
        InternetUserBLL bll = new InternetUserBLL();
        public Record()
        {
            InitializeComponent();
        }

        private void Record_Load(object sender, EventArgs e)
        {
           DataSet ds= bll.FindRecord();
           dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string vnum=txt_vnum.Text.Trim();
            if (txt_vnum.Text != "")
            {
                DataSet ds = bll.FindVipRecord(vnum);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                DataSet ds = bll.FindRecord();
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_vnum.Text = "";
            DataSet ds = bll.FindRecord();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
