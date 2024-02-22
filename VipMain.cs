using InternetBLL;
using InternetModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InternetCafeSystem
{
    public partial class VipMain : Form
    {
        InternetUserBLL bll = new InternetUserBLL();
        UserInfo ui = new UserInfo();
        string _vnum;
        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
        public VipMain(string vnum)
        {
            InitializeComponent();
            _vnum = vnum;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = bll.SelectLonelyVip(_vnum);
            int vmoney = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            MessageBox.Show("您的余额为：" + vmoney + " 元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataSet ds = bll.FindComputerState();
            dgv_choose.AllowUserToAddRows = false;
            dgv_choose.DataSource = ds.Tables[0].DefaultView;
            //在datagridview中添加button按钮
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "go";
            btn.HeaderText = "操作";
            btn.DefaultCellStyle.NullValue = "上机";
            dgv_choose.Columns.Add(btn);

            //在datagridview中添加button按钮
            //DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.Name = "down";
            btn2.HeaderText = "操作";
            btn2.DefaultCellStyle.NullValue = "下机";
            dgv_choose.Columns.Add(btn2);
            dgv_choose.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //在datagridview中添加button按钮
            DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn();
            btn3.Name = "find";
            btn3.HeaderText = "操作";
            btn3.DefaultCellStyle.NullValue = "查看上机时长";
            dgv_choose.Columns.Add(btn3);
            dgv_choose.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgv_choose_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_choose.Columns[e.ColumnIndex].Name == "go")
            {
                DataGridViewColumn column = dgv_choose.Columns[e.ColumnIndex];
                ui.Pcname = (string)dgv_choose.CurrentRow.Cells[1].Value;
                string pcname = ui.Pcname;
                DataSet ds = bll.SelectLonelyVip(_vnum);
                int money = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                if (money >= 5)
                {
                    bll.AddStartTime(_vnum, pcname);//添加上机记录
                    MessageBox.Show("上机成功！", "温馨提示");
                    bll.UpdateComStateGo(pcname);//修改电脑状态为上机
                    DataSet dst = bll.FindComputerState();
                    dgv_choose.DataSource = dst.Tables[0].DefaultView;
                    btn.Visible = false;
                    
                }
                else
                {
                    MessageBox.Show("您的余额不足，请及时充值！", "温馨提示");
                }

            }

            else if (this.dgv_choose.Columns[e.ColumnIndex].Name == "down")
            {
                DataSet ds = bll.SelectLonelyVip(_vnum);
                int money = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                if (MessageBox.Show("您确定要下机吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataSet dscom = bll.FindComNum(_vnum);
                    string pcname = dscom.Tables[0].Rows[0][0].ToString();
                    bool b = bll.AddEndTime(_vnum, pcname);
                    if (b)
                    {
                        bll.UpdateComStateDown(pcname);
                        DataSet ds2 = bll.FindStartTime(_vnum, pcname);
                        DateTime st = Convert.ToDateTime(ds2.Tables[0].Rows[0][0].ToString());

                        DataSet ds1 = bll.FindEndTime(_vnum, pcname);
                        DateTime dt = Convert.ToDateTime(ds1.Tables[0].Rows[0][0].ToString());

                        int startTime = st.Minute;
                        int endTime = dt.Minute;

                        int gametime = endTime - startTime;
                        if (gametime > 60)
                        {
                            float mm = gametime / 60;
                            float mmr=(float)Math.Round(mm,1);
                            float finalMoney = (mmr * 3) + 5;
                            bll.UpdateMoneyOver(money, finalMoney,_vnum);
                        }
                        else if (gametime <= 60)
                        {
                            bll.UpdateMoney(money, _vnum);
                            DataSet ds4 = bll.SelectLonelyVip(_vnum);
                            int money2 = Convert.ToInt32(ds4.Tables[0].Rows[0][0].ToString());
                            MessageBox.Show("下机成功！您此次的上机时长为：" + gametime + " 分钟，" + "消费为 " + 5 + " 元，" + "当前剩余 " + money2 + " 元", "提示");
                            btn.Visible = true;
                        }


                    }

                    DataSet dst = bll.FindComputerState();
                    dgv_choose.DataSource = dst.Tables[0].DefaultView;
                }
            }
            else if (this.dgv_choose.Columns[e.ColumnIndex].Name == "find")
            {
                DataSet dscom = bll.FindComNum(_vnum);
                string pcname = dscom.Tables[0].Rows[0][0].ToString();
                DataSet ds1 = bll.FindStartTime(_vnum, pcname);
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    DateTime st1 = Convert.ToDateTime(ds1.Tables[0].Rows[0][0].ToString());

                    int startTime = st1.Minute;

                    DateTime dt = DateTime.Now;
                    int time = dt.Minute;

                    int t = time - startTime;

                    MessageBox.Show("您目前玩了" + t + "分钟", "提示");
                }

            }
        }

      

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Rules r= new Rules();
            r.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            VipRecord vipRecord = new VipRecord(_vnum);
            vipRecord.ShowDialog();

        }

       
    }
}
