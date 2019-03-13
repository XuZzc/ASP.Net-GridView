using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProdctPic { get; set; }
        public double ProductPrice { get; set; }
        public string ProductDesc { get; set; }
        public int ClassID { get; set; }
        public DateTime AddTime { get; set; }
    }
}
