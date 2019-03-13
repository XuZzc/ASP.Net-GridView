using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBHelper
    {
        public static SqlConnection conn = new SqlConnection
            ("Data Source=.;Initial Catalog=FreshLiveDB;Integrated Security=True");

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable Select(string sql) {
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(dt);
            return dt;
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool Update(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
           
        }
    }
}
