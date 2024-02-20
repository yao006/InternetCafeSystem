using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetDAL
{
    public class DbHelper
    {
        //创建一个连接对象（默认null）
        private SqlConnection con = null;

        /// <summary>
        /// 打开数据库
        /// </summary>
        /// <returns></returns>
        private void OpenSqlConnection()
        {
            //第一步获取连接数据库的访问地址（ip地址、数据库名称、账号、密码）
            string connectionString = "Data Source=127.0.0.1;Initial Catalog=InternetCafe;User ID=sa;Password=123456";

            //第二步 打开数据库
            con = new SqlConnection(connectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();//打开数据库 
            }
            else if (con.State == ConnectionState.Broken)
            {

                con.Close();//先关闭
                con.Open();
            }

        }



        /// <summary>
        /// 关闭数据库库连接对象
        /// </summary>
        private void CloseSqlConnection()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
                {
                    con.Close();
                }
            }

        }



        /// <summary>
        /// 处理数据库的各种 插入  删除  修改操作
        /// </summary>
        /// <param name="sql">要执行的TSQL语句命令</param>
        /// <returns>true执行成功  false 执行失败</returns>
        public bool SQL_ExecuteNonQuery(string sql)
        {

            try
            {
                //第一步打开数据库
                OpenSqlConnection();
                //第二步创建执行SQL语句对象
                SqlCommand cmd = new SqlCommand(sql, con);
                //第三步执行语句 并返回影响的行数  影响0执行失败  影响1执行成功
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("执行TSQL命令出错，请联系管理员！1812312313");
            }
            finally
            {

                CloseSqlConnection(); //关闭数据库
            }

            return false;
        }



        /// <summary>
        /// 获取数据库的各种查询操作
        /// </summary>
        /// <param name="sql">要查询的TSQL命令 一般全部为select查询</param>
        /// <returns>返回结果数据集DataSet（别名 tables）</returns>
        public DataSet SQL_GetData(string sql)
        {
            try
            {
                //打开数据库
                OpenSqlConnection();
                //创建执行对象
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                //创建一个数据集
                DataSet ds = new DataSet();
                //把执行后返回的数据  存放到数据集ds中 并起名为tables
                adapter.Fill(ds, "tables");
                return ds;
            }
            catch (Exception)
            {
                Console.WriteLine("执行TSQL命令出错，请联系管理员！1812312313");
            }
            finally
            {
                CloseSqlConnection();//关闭数据库
            }

            return null;
        }
    }
}
