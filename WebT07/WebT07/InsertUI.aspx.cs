using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
namespace WebT07
{
    public partial class InsertUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack )
            {
                this.DropDownList1.DataSource = ProductBLL.SelectproductClass();
                this.DropDownList1.DataTextField = "ClassName";
                this.DropDownList1.DataValueField = "ClassID";
                this.DropDownList1.DataBind();

            }
        }
        //上传
        protected void Button1_Click(object sender, EventArgs e)
        {
            string fileName = FileUpload1.FileName;
            //获取文件后缀
            string fileFix = fileName.Substring(fileName.LastIndexOf('.') + 1).ToLower();
            if (fileFix != "png" && fileFix != "jpg" && fileFix != "jpeg" && fileFix != "gif")
            {
                this.Label1.Text = "选择的文件不是图片！";
            }
            else {
                FileUpload1.SaveAs(Server.MapPath(".") + "/ProductPic/" + fileName);
                this.Label1.Text = fileName;
            }


        }
        //添加
        protected void Button2_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = this.tbname.Text;
            p.ProdctPic = this.Label1.Text;
            p.ProductPrice =double .Parse ( this.tbprice.Text);
            p.ProductDesc = this.tbxiangqing.Text;
            p.ClassID = int.Parse(this.DropDownList1.SelectedValue.ToString());
            p.AddTime = DateTime.Now;
            if (ProductBLL.InsertProduct(p))
            {
                Response.Redirect("/Demo01.aspx");
            }
            else {
                Response.Write("<script>alert('添加失败')</script>");
                Response.Redirect("/InsertUI.aspx");
            }








        }

      









    }
}