using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebT07
{
    public partial class Demo01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GridView1.AutoGenerateColumns = false;
                this.GridView1.DataSource = ProductBLL.GetProductList();
                this.GridView1.DataBind();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {

        }
        //删除
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = int.Parse(this.GridView1.Rows[e.RowIndex].Cells[0].Text.ToString());

            if (ProductBLL.UPproduct(ID))
            {
                this.GridView1.AutoGenerateColumns = false;
                this.GridView1.DataSource = ProductBLL.GetProductList();
                this.GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('删除失败！')</script>");
            }
        }
    }
}