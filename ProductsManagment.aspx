<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductsManagment.aspx.cs" Inherits="ProductManagment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 39px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    ProductManagment<br />
    <br />
    <center>
        <table style="width: 65%;">
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblpNumt" runat="server" Text="Number"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:Label ID="lblpNum" runat="server" Text=""></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblpName" runat="server" Text="Name"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtpName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtpName" ErrorMessage="input Name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnNew" runat="server" Text="New" Width="100px" CausesValidation="False" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblpCompany" runat="server" Text="Company"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtpCompany" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpCompany" ErrorMessage="input Company" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="Add" Width="100px" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblpDate" runat="server" Text="Date"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtpDate" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtpDate" ErrorMessage="input Date" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="100px" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblpPrice" runat="server" Text="Price"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtpPrice" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtpPrice" ErrorMessage="input Price" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="100px" CausesValidation="False" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblpSupplier" runat="server" Text="Supplier"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:DropDownList ID="ddlpSupplier" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlpSupplier" ErrorMessage="choose supplier" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnfirst" runat="server" Text="First" Width="100px" CausesValidation="False" />
                </td>
                <td class="auto-style1">
                    <asp:Button ID="btnprev" runat="server" Text="Prev" Width="100px" CausesValidation="False" />
                </td>
                <td class="auto-style1">
                    <asp:Button ID="btnnext" runat="server" Text="Next" Width="100px" CausesValidation="False" />
                </td>
                <td class="auto-style1">
                    <asp:Button ID="btnlast" runat="server" Text="Last" Width="100px" CausesValidation="False" />
                </td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
        </table>
        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
    </center>
    &nbsp;





</asp:Content>

