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
    public partial class VipRecord : Form
    {
        InternetUserBLL bll= new InternetUserBLL();
        string _vnum;
        public VipRecord(string vnum)
        {
            InitializeComponent();
            _vnum = vnum;
        }

        private void VipRecord_Load(object sender, EventArgs e)
        {
            DataSet ds = bll.FindVipRecord(_vnum);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
