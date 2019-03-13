using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class ProductBLL
    {
        /// <summary>
        /// 查询所有的产品列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetProductList() {
            return ProductDAL.GetProductList();
        }

        /// <summary>
        /// 根据id删除商品数据
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static bool UPproduct(int ID) {
            return ProductDAL.UPproduct(ID);
        
        }
         /// <summary>
        /// 商品类别
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectproductClass()
        {
            return ProductDAL.SelectproductClass();
        }
          /// <summary>
        /// 添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InsertProduct(Model.Product p)
        {
            return ProductDAL.InsertProduct(p);
        }
    }
}
