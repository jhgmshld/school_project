<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="StoriesManagment.aspx.cs" Inherits="ProductManagment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 39px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <br />
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
                    <asp:Button ID="btnNew" runat="server" Text="New" Width="100px" CausesValidation="False" OnClick="btnNew_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblpdiscreption" runat="server" Text="content"></asp:Label>
                </td>
                <td colspan="2">
                                   <asp:TextBox ID="txtContent" runat="server" Columns="10" Height="208px" TextMode="MultiLine" Width="525px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcontent" ErrorMessage="input content" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="Add" Width="100px" OnClick="btnAdd_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblpwritername" runat="server" Text="written by"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtwirtername" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtwirtername" ErrorMessage="input writer name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="100px" OnClick="btnUpdate_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblpnumofcomments" runat="server" Text="num of comments"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="100px" CausesValidation="False" OnClick="btnDelete_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblpuserid" runat="server" Text="writer id"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtwriterid" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtwriterid" ErrorMessage="input writer id" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Label ID="lblcoverimg" runat="server" Text="cover image"></asp:Label>
                </td>
                <td class="auto-style1" colspan="2">
                    <asp:Image ID="Image1" runat="server" Height="141px" Width="217px" />
                    <br />
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <br />
                </td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnfirst" runat="server" Text="First" Width="100px" CausesValidation="False" OnClick="btnFirst_Click" />
                </td>
                <td class="auto-style1">
                    <asp:Button ID="btnprev" runat="server" Text="Prev" Width="100px" CausesValidation="False" OnClick="btnPrev_Click" />
                </td>
                <td class="auto-style1">
                    <asp:Button ID="btnnext" runat="server" Text="Next" Width="100px" CausesValidation="False" OnClick="btnNext_Click" />
                </td>
                <td class="auto-style1">
                    <asp:Button ID="btnlast" runat="server" Text="Last" Width="100px" CausesValidation="False" OnClick="btnLast_Click" />
                </td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
    </center>
    &nbsp;





    <asp:GridView ID="gdvs" runat="server">
    </asp:GridView>





</asp:Content>

