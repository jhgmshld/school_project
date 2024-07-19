<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddToList.aspx.cs" Inherits="AddToList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#BFA5F0;">
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="268px" ShowFooter="True" Width="697px">
                <Columns>
                    <asp:BoundField DataField="sNum" HeaderText="book id" />
                    <asp:BoundField DataField="swriter" HeaderText="writer username" />
                    <asp:BoundField DataField="sName" HeaderText="book name" />
                    <asp:BoundField DataField="snumofcomments" HeaderText="num of comments" />
                    <asp:BoundField DataField="sdiscreption" HeaderText="describtion" />
                    <asp:BoundField DataField="image" HeaderText="cover" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
