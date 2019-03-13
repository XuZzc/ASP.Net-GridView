using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using System.Data;

namespace BLL
{
    public class UserInfoBLL
    {
        /// <summary>
        /// 查询所有的用户列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetUserList() {
            return UserInfoDAL.GetUserList();
        }
    }
}
