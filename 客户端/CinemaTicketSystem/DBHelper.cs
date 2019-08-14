using System;
using System.Data.SqlClient;
using System.Data;

namespace CinemaTicketSystem
{
    class DBHelper
    {
        //创建链接数据库字符串
        public static string ConnStr = "server=.;database=DarkNet;integrated security=true";
        //创建链接数据库对象
        public static SqlConnection Conn = null;

        /// <summary>
        /// 链接数据库
        /// </summary>

        public static void InitConnection()
        {
            try
            {
                if (Conn == null)
                {
                    Conn = new SqlConnection(ConnStr);
                }
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
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 断开试查询
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>

        public static DataTable GetDataTable(string sqlStr)
        {
            DataTable td=null;
            try
            {
                InitConnection();
                SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Conn);
                td = new DataTable();
                sda.Fill(td);
                Conn.Close();
                
            }
            catch (Exception)
            {
                
            }
            return td;
        }

        /// <summary>
        /// 非断开试查询
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>

        public static SqlDataReader GetDataReader(string sqlStr)
        {
            SqlCommand cmd = null;
            try
            {
                InitConnection();
                cmd = new SqlCommand(sqlStr, Conn);
                
            }
            catch (Exception)
            {
                
            }
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>

        public static bool ExecuteNoneQuery(string sqlStr)
        {
            bool rel = false;
            try
            {
                InitConnection();
                SqlCommand cmd = new SqlCommand(sqlStr, Conn);
                rel = cmd.ExecuteNonQuery() > 0;
                Conn.Close();
                
            }
            catch (Exception)
            {

            }
            return rel;
        }

        /// <summary>
        /// 执行聚合函数
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>

        public static object ExecuteScalar(string sqlStr)
        {
            try
            {
                InitConnection();
                SqlCommand cmd = new SqlCommand(sqlStr, Conn);
                object rel = cmd.ExecuteScalar();
                Conn.Close();
                return rel;
            }
            catch (Exception)
            {
                
            }
        }
        //参数化sql语句

        public static bool ExecuteScalar(string sql, params SqlParameter[] sqlparameters)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            if (sqlparameters != null)
                cmd.Parameters.AddRange(sqlparameters);
            cmd.CommandText = sql;
            cmd.ExecuteScalar();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
