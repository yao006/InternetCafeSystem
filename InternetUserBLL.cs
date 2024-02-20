using InternetDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InternetBLL
{
    public class InternetUserBLL
    {
        DbHelper db = new DbHelper();
        InternetUserDAL dal = new InternetUserDAL();
        public bool ManagerLogin(string zhanghao, string pwd)
        {
            DataSet ds = dal.ManagerLogin(zhanghao, pwd);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public bool AddUsers(string vipname, string vippwd)
        {
            bool b = dal.AddUsers(vipname, vippwd);
            if (b == true)
            {
                return true;
            }
            return false;
        }

        public bool VipLogin(string vipname, string vippwd)
        {
            DataSet ds = dal.VipLogin(vipname, vippwd);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public bool SelectIs(string vipnamed)
        {
            DataSet ds = dal.SelectIs(vipnamed);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public DataSet SelectAllVip()
        {

            DataSet ds = dal.SelectAllVip();
            return ds;
        }

        public DataSet SelectLonelyVip(string lvnum)
        {
            DataSet ds = dal.SelectLonelyVip(lvnum);
            return ds;
        }

        public bool AddOneMoney(string vnum, int balance)
        {
            bool b = dal.AddOneMoney(vnum, balance);
            if (b == true)
            {
                return true;
            }

            return false;
        }

        public bool AddMoney(string vnum, int balance, int old)
        {
            bool b = dal.AddMoney(vnum, balance, old);
            if (b == true)
            {
                return true;
            }

            return false;
        }

        public bool AddComputer(string pcname, string pcgraphics, String pcnode)
        {
            bool b = dal.AddComputer(pcname, pcgraphics, pcnode);
            if (b)
            {
                return true;
            }
            return false;
        }

        public DataSet FindComputer()
        {
            return dal.FindComputer();
        }

        public DataSet FindVipByNum(string vnum)
        {
            DataSet ds = dal.FindVipByNum(vnum);
            return ds;
        }

        public DataSet FindComputerByName(string pcname)
        {
            DataSet ds = dal.FindComputerByName(pcname);
            return ds;
        }

        public DataSet FindComputerState()
        {
            DataSet ds = dal.FindComputerState();
            return ds;
        }

        public bool AddStartTime(string vnum, string comnum)
        {
            bool b = dal.AddStartTime(vnum, comnum);
            if (b)
            {
                return true;
            }
            return false;
        }

        public bool AddEndTime(string vnum, string comnum)
        {
            bool b = dal.AddEndTime(vnum, comnum);
            if (b)
            {
                return true;
            }
            return false;
        }

        public bool UpdateComStateGo(string pcname)
        {
            bool b = dal.UpdateComStateGo(pcname);
            if (b)
            {
                return true;
            }
            return false;
        }

        public bool UpdateComStateDown(string pcname)
        {
            bool b = dal.UpdateComStateDown(pcname);
            if (b)
            {
                return true;
            }
            return false;
        }

        public DataSet FindStartTime(string vnum, string computernum)
        {
            DataSet ds = dal.FindStartTime(vnum, computernum);
            return ds;
        }

        public DataSet FindEndTime(string vnum, string computernum)
        {
            DataSet ds = dal.FindEndTime(vnum, computernum);
            return ds;
        }

        public DataSet FindComNum(string vnum)
        {
            DataSet ds = dal.FindComNum(vnum);
            return ds;
        }

        public bool UpdateMoney(float money, string vnum)
        {
            bool b = dal.UpdateMoney(money, vnum);
            if (b)
            {
                return true;
            }
            return false;
        }

        public bool UpdateMoneyOver(float money, float m, string vnum)
        {
            bool b = dal.UpdateMoneyOver(money, m, vnum);
            if (b)
            {
                return true;
            }
            return false;
        }

        public DataSet FindRecord()
        { 
            DataSet ds = dal.FindRecord();
            return ds;
        }

        public DataSet FindVipRecord(string vnum)
        {
            DataSet ds = dal.FindVipRecord(vnum);
            return ds;
        }
    }
}
