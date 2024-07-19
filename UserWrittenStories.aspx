<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserWrittenStories.aspx.cs" Inherits="UserOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style11 {
            margin-right: 3px;
        }
        .auto-style12 {
            text-align: center;
            width: 222px;
        }
        .auto-style10 {
            text-align: center;
            height: 26px;
            width: 222px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



         




    <asp:DataList ID="DataList1" runat="server" CssClass="auto-style11" DataKeyField="sNum" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" Height="334px" RepeatColumns="4" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand">
        <ItemTemplate>
            <table class="auto-style8">
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblsNum" runat="server" Text="bookId"></asp:Label>
                        <asp:Label ID="lblSnumm" runat="server" Text='<%# Eval("sNum") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblwritername" runat="server" Text="writer "></asp:Label>
                        <asp:Label ID="lblwritern" runat="server" Text='<%# Eval("swriter") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="lblbookname" runat="server" Text="title"></asp:Label>
                        <asp:Label ID="lbltitlet" runat="server" Text='<%# Eval("sName") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Image ID="Image1" runat="server" Height="130px" ImageUrl='<%# Eval("image") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblcmn" runat="server" Text="comments"></asp:Label>
                        <asp:Label ID="lblcomn" runat="server" Text='<%# Eval("snumofcomments") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lbldescribtion" runat="server" Text="describtion"></asp:Label>
                        <asp:Label ID="lbldesc" runat="server" Text='<%# Eval("sdiscreption") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        &nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("suserid") %>' Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString5 %>" ProviderName="<%$ ConnectionStrings:ConnectionString5.ProviderName %>" SelectCommand="SELECT * FROM [booktb]"></asp:SqlDataSource>



         




</asp:Content>

