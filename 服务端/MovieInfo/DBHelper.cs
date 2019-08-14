using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MovieInfo
{
    class DBHelper
    {
        //创建链接数据库字符串
        public static string ConnStr = "server=.;database=DarkNet;integrated security=true";
        //创建链接数据库对象
        public static SqlConnection Conn = new SqlConnection(ConnStr);

        /// <summary>
        /// 链接数据库
        /// </summary>

        public static void InitConnection()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
        }

        /// <summary>
        /// 断开试查询
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>

        public static DataTable GetDataTable(string sqlStr)
        {
            InitConnection();
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Conn);
            DataTable td = new DataTable();
            sda.Fill(td);
            Conn.Close();
            return td;
        }

        /// <summary>
        /// 非断开试查询
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>

        public static SqlDataReader GetDataReader(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>

        public static bool ExecuteNoneQuery(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            bool rel = cmd.ExecuteNonQuery() > 0;
            Conn.Close();
            return rel;
        }

        /// <summary>
        /// 执行聚合函数
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>

        public static Object ExecuteScalar(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            object rel = cmd.ExecuteScalar();
            Conn.Close();
            return rel;
        }
    }
}
