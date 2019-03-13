using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserInfo
    {

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string QQ { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreateTime { get; set; }
        public string UserType { get; set; }
    }
}
