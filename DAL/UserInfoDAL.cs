using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserInfoDAL
    {

        /// <summary>
        /// 查询所有的用户列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetUserList() {
            string sql = "select * from UserInfo";
            DataTable dt = DBHelper.Select(sql);
            return dt;
        }
    }
}
