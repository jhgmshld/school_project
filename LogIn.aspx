<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <style>
        .sname{
            opacity:0.3;
        }
        .sback{
            left:25%;
            top:55%;
            background-image:url(https://c8.alamy.com/comp/2F3XF9J/an-aesthetic-illustration-of-a-marble-background-in-light-purple-pantone-color-2F3XF9J.jpg);
            height:200px;
            width:630px;
            opacity:0.5;
            position:absolute;
        }
        .auto-style9 {
            left: 10%;
            top: 17%;
            background-image: url('https://c8.alamy.com/comp/2F3XF9J/an-aesthetic-illustration-of-a-marble-background-in-light-purple-pantone-color-2F3XF9J.jpg');
            height: 500px;
            width: 1200px;
            opacity: 0.7;
            position: absolute;
        }
        .auto-style10 {
            width: 135px;
        }
        .auto-style11 {
            width: 260px;
        }
    </style>

    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="" CssClass="auto-style9"></asp:Label>
    <br />
    <center>
    <table style="width:50%;left:35%;top:40%;position:absolute;">
        <tr>
            <td class="auto-style10">
                <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="txtUserName" runat="server" OnTextChanged="txtUserName_TextChanged" CssClass="sname"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="input user name" ControlToValidate="txtUserName" ForeColor="#CC0000"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="txtPassword" runat="server" CssClass="sname"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="input password" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">
                <asp:Button ID="btnLogIn" runat="server" Text="LogIn" OnClick="btnLogIn_Click" /></td>
            <td>&nbsp;</td>
        </tr>
    </table>
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </center>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

    <br />


                   



</asp:Content>

