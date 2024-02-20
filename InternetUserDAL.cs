using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetDAL
{
    public class InternetUserDAL
    {
        DbHelper db = new DbHelper();
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="zhanghao"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public DataSet ManagerLogin(string zhanghao, string pwd)
        {
            string sql = "select * from manager where adminname='" + zhanghao + "' and password='" + pwd + "'";
            return db.SQL_GetData(sql);
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="vipname"></param>
        /// <param name="vippwd"></param>
        /// <returns></returns>
        public bool AddUsers(string vipname, string vippwd)
        {
            string sql = "insert into vip(vnum,vpassword,vbalance,vtime)values('" + vipname + "','" + vippwd + "',0,getdate())";
            return db.SQL_ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 会员登录
        /// </summary>
        /// <param name="vipnamed"></param>
        /// <param name="vippwd"></param>
        /// <returns></returns>
        public DataSet VipLogin(string vipname, string vippwd)
        {
            string sql = "select * from vip where vnum = '" + vipname + "' and vpassword = '" + vippwd + "'";
            return db.SQL_GetData(sql);
        }

        /// <summary>
        /// 查询Vip账号
        /// </summary>
        /// <param name="zhanghao"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public DataSet SelectIs(string vipnamed)
        {
            string sql = "select * from vip where vnum = '" + vipnamed + "'";
            return db.SQL_GetData(sql);
        }

        /// <summary>
        /// 查询会员表所有信息
        /// </summary>
        /// <returns></returns>
        public DataSet SelectAllVip()
        {
            string sql = "select vid as '会员序号',vnum as '会员账号',vbalance as '余额（元）',vtime as '注册时间' from vip";
            return db.SQL_GetData(sql);
        }

        /// <summary>
        /// 查询单个会员储值
        /// </summary>
        /// <param name="lvnum"></param>
        /// <param name="lbalance"></param>
        /// <returns></returns>
        public DataSet SelectLonelyVip(string lvnum)
        {
            string sql = "select vbalance from vip where vnum='" + lvnum + "'";
            return db.SQL_GetData(sql);
        }

        /// <summary>
        /// 第一次充值
        /// </summary>
        /// <param name="vnum"></param>
        /// <param name="balance"></param>
        /// <param name="old"></param>
        /// <returns></returns>
        public bool AddOneMoney(string vnum, int balance)
        {
            string sql = "update vip set vbalance=" + balance + " where vnum ='" + vnum + "'";
            return db.SQL_ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 反复充值功能
        /// </summary>
        /// <param name="vnum"></param>
        /// <param name="balance"></param>
        /// <returns></returns>
        public bool AddMoney(string vnum, int balance, int old)
        {
            string sql = "update vip set vbalance=" + balance + "+" + old + " where vnum ='" + vnum + "'";
            return db.SQL_ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 添加电脑
        /// </summary>
        /// <param name="pcname"></param>
        /// <param name="pcgraphics"></param>
        /// <param name="pcnode"></param>
        /// <returns></returns>
        public bool AddComputer(string pcname, string pcgraphics, String pcnode)
        {
            string sql = "insert into computer(pcname,pcgraphics,pcstate,pcnode)values('" + pcname + "','" + pcgraphics + "',0,'" + pcnode + "')";
            return db.SQL_ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 查询电脑
        /// </summary>
        /// <returns></returns>
        public DataSet FindComputer()
        {
            string sql = "select pcid '电脑序号',pcname '电脑编号',pcgraphics '显卡',pcnode '描述',(case pcstate when 0 then '待机' when 1 then '上机' end)状态  from computer\r\n";
            return db.SQL_GetData(sql);
        }

        /// <summary>
        /// 模糊查询会员（会员账号）
        /// </summary>
        /// <param name="vnum"></param>
        /// <returns></returns>
        public DataSet FindVipByNum(string vnum)
        {
            string sql = "select vid as '会员序号',vnum as '会员账号',vbalance as '余额（元）',vtime as '注册时间' from vip where vnum like '%" + vnum + "%'";
            return db.SQL_GetData(sql);
        }

        /// <summary>
        /// 模糊查询电脑（电脑编号）
        /// </summary>
        /// <param name="pcname"></param>
        /// <returns></returns>
        public DataSet FindComputerByName(string pcname)
        {
            string sql = "select pcid '电脑序号',pcname '电脑编号',pcgraphics '显卡',pcnode '描述',(case pcstate when 0 then '待机' when 1 then '上机' end)状态  from computer where pcname like '%" + pcname + "%' \r\n";
            return db.SQL_GetData(sql);
        }

        /// <summary>
        /// 查看待机状态的电脑
        /// </summary>
        /// <returns></returns>
        public DataSet FindComputerState()
        {
            string sql = "select pcid '电脑序号',pcname '电脑编号',pcgraphics '显卡',pcnode '描述',(case pcstate when 0 then '待机中' when 1 then '上机中' end)状态  from computer\r\n";
            return db.SQL_GetData(sql);
        }

        /// <summary>
        /// 添加充值记录（上机时间）
        /// </summary>
        /// <param name="vnum"></param>
        /// <param name="comnum"></param>
        /// <returns></returns>
        public bool AddStartTime(string vnum, string comnum)
        {
            string sql = "insert into starttime(vnum,computernum,starttime,rstate) values ('" + vnum + "','" + comnum + "',GETDATE(),0)\r\n";
            return db.SQL_ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 添加充值记录（下机时间）
        /// </summary>
        /// <param name="vnum"></param>
        /// <param name="comnum"></param>
        /// <returns></returns>
        public bool AddEndTime(string vnum, string comnum)
        {
            string sql = "insert into endtime(vnum,computernum,endtime,rstate) values ('" + vnum + "','" + comnum + "',GETDATE(),0)";
            return db.SQL_ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 修改电脑状态为上机
        /// </summary>
        /// <param name="pcname"></param>
        /// <returns></returns>
        public bool UpdateComStateGo(string pcname)
        {
            string sql = "update computer set pcstate = 1 where pcname = '" + pcname + "'";
            return db.SQL_ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 修改电脑状态为下机
        /// </summary>
        /// <param name="pcname"></param>
        /// <returns></returns>
        public bool UpdateComStateDown(string pcname)
        {
            string sql = "update computer set pcstate = 0 where pcname = '" + pcname + "'";
            return db.SQL_ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 获取上机时间
        /// </summary>
        /// <param name="vnum"></param>
        /// <param name="computernum"></param>
        /// <returns></returns>
        public DataSet FindStartTime(string vnum, string computernum)
        {
            string sql = "select top 1 starttime from starttime  where vnum = '" + vnum + "' and computernum = '" + computernum + "' order by rid desc\r\n";
            return db.SQL_GetData(sql);
        }

        /// <summary>
        /// 获取下机时间
        /// </summary>
        /// <param name="vnum"></param>
        /// <param name="computernum"></param>
        /// <returns></returns>
        public DataSet FindEndTime(string vnum, string computernum)
        {
            string sql = "select top 1 endtime from endtime  where vnum = '" + vnum + "' and computernum = '" + computernum + "' order by rid desc\r\n";
            return db.SQL_GetData(sql);
        }

        /// <summary>
        /// 获取电脑编号
        /// </summary>
        /// <param name="vnum"></param>
        /// <returns></returns>
        public DataSet FindComNum(string vnum)
        {
            string sql = "select top 1 computernum from starttime  where vnum = '" + vnum + "'  order by rid desc";
            return db.SQL_GetData(sql);
        }

        /// <summary>
        /// 上机时长小于60分钟收费5元
        /// </summary>
        /// <param name="money"></param>
        /// <param name="vnum"></param>
        /// <returns></returns>
        public bool UpdateMoney(float money, string vnum)
        {
            string sql = "update vip set vbalance = " + money + " - 5 where vnum = '" + vnum + "'";
            return db.SQL_ExecuteNonQuery(sql);
        }

        public bool UpdateMoneyOver(float money, float m, string vnum)
        {
            string sql = "update vip set vbalance = " + money + " - " + m + " where vnum = '" + vnum + "'";
            return db.SQL_ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 查询上机记录
        /// </summary>
        /// <returns></returns>
        public DataSet FindRecord()
        {
            string sql = "select a.vnum as '会员账号',a.computernum as '电脑编号',starttime as '上机时间',endtime as '下机时间' from starttime a,endtime b where a.vnum = b.vnum\r\n";
            return db.SQL_GetData(sql);
        }

        public DataSet FindVipRecord(string vnum)
        {
            string sql = "select a.vnum as '会员账号',a.computernum as '电脑编号',starttime as '上机时间',endtime as '下机时间' from starttime a,endtime b where a.vnum = b.vnum and a.vnum='" + vnum + "'\r\n";
            return db.SQL_GetData(sql);
        }
    }
}
