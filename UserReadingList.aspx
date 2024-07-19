﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserReadingList.aspx.cs" Inherits="UserCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style11 {
            width: 80%;
            left:8%;
            position:absolute;
        }
        .auto-style12 {
            text-align: center;
            width: 222px;
            background-color:white;
            position:absolute;
        }
        .auto-style10 {
            text-align: center;
            height: 26px;
            width: 222px;
        }
        .auto-style13 {
            margin-top: 3px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



                    
    <asp:DataList ID="DataList1" runat="server" CssClass="auto-style11" DataKeyField="sNum" DataSourceID="SqlDataSource1" Height="334px" RepeatColumns="4" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand" BackColor="White" BorderColor="#993399" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" GridLines="Both" CellPadding="0">
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
                        <asp:Button ID="Button1" runat="server" CommandName="read" OnClick="Button1_Click" Text="read" />
                        <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%#Eval("sNum") %>' CommandName="." CssClass="auto-style13" Height="48px" ImageUrl="~/images/add.png" Width="75px" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("suserid") %>' Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
        </ItemTemplate>
    </asp:DataList>





    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [booktb]"></asp:SqlDataSource>



    <br />



</asp:Content>
