using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetModel
{
    public class UserInfo
    {
        private static int id;
        private static string adminname;
        private static string password;
        private static int vid;
        private static string vnum;
        private static string vpassword;
        private static int vbalance;
        private static DateTime vtime;
        private static int pcid;
        private static string pcname;
        private static string pcgraphics;
        private static int pcstate;
        private static string pcnode;

        public static int Id { get => id; set => id = value; }
        public static string Adminname { get => adminname; set => adminname = value; }
        public static string Password { get => password; set => password = value; }
        public static int Vid { get => vid; set => vid = value; }
        public static string Vnum { get => vnum; set => vnum = value; }
        public static string Vpassword { get => vpassword; set => vpassword = value; }
        public static int Vbalance { get => vbalance; set => vbalance = value; }
        public static DateTime Vtime { get => vtime; set => vtime = value; }
        public int Pcid { get => pcid; set => pcid = value; }
        public string Pcname { get => pcname; set => pcname = value; }
        public string Pcgraphics { get => pcgraphics; set => pcgraphics = value; }
        public int Pcstate { get => pcstate; set => pcstate = value; }
        public string Pcnode { get => pcnode; set => pcnode = value; }
    }
}
