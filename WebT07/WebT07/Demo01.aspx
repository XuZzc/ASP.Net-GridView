<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo01.aspx.cs" Inherits="WebT07.Demo01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" OnRowDeleted="GridView1_RowDeleted" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="编号" />
                <asp:BoundField DataField="productName" HeaderText="商品名称" />
                <asp:ImageField DataImageUrlField="ProductPic" DataImageUrlFormatString="~/ProductPic/{0}" HeaderText="图片">
                </asp:ImageField>
                <asp:BoundField DataField="ProductPrice" HeaderText="商品价格" />
                <asp:CommandField HeaderText="操作" ShowDeleteButton="True" />
            </Columns>


        </asp:GridView>
    </div>
    </form>
</body>
</html>
