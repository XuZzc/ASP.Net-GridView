using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class ProductDAL
    {
        /// <summary>
        /// 查询所有的产品列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetProductList() {
            string sql = "select * from Product";
            return DBHelper.Select(sql);
        }

        /// <summary>
        /// 根据id删除商品数据
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static bool UPproduct(int ID) {
            string sql = string.Format("delete from Product where ProductID='{0}'", ID);
            return DBHelper.Update(sql);
        }
        /// <summary>
        /// 商品类别
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectproductClass()
        {
            string sql = string.Format("select * from ProductClass");
            return DBHelper.Select(sql);
        
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InsertProduct(Product p)
        {
            string sql = string.Format("insert into Product values('{0}','{1}','{2}','{3}','{4}','{5}')", p.ProductName, p.ProdctPic, p.ProductPrice, p.ProductDesc, p.ClassID, p.AddTime);
            return DBHelper.Update(sql);
        }

    }
}
