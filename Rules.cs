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
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            txt_rules.Text = "1、时长小于60分钟则收费5元。2、时长大于60分钟则第一个小时收费5元，之后每小时收取三元。3、祝您上机愉快";
        }
    }
}
