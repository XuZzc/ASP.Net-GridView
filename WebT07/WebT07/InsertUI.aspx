<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertUI.aspx.cs" Inherits="WebT07.InsertUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        商品名称：<asp:TextBox ID="tbname" runat="server"></asp:TextBox>
        <br />
        商品图片：<asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="上传" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        商品价格：<asp:TextBox ID="tbprice" runat="server"></asp:TextBox>
        <br />
        商品详情：<asp:TextBox ID="tbxiangqing" runat="server" Height="66px"></asp:TextBox>
        <br />
        商品类别：<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="添加" />
    </div>
    </form>
</body>
</html>
