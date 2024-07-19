<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 53%;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">





                       <br />
                       <br />
    <br />
    <br />
    <br />
    <center>
                       <table class="auto-style1">
                           <tr>
                               <td>
                                   <asp:Label ID="lblSubject" runat="server" Text="Title"></asp:Label>
                               </td>
                               <td colspan="2">
                                   <asp:TextBox ID="txtSubject" runat="server" Width="529px"></asp:TextBox>
                               </td>
                               <td>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="input titel " ControlToValidate="txtSubject" ForeColor="Red"></asp:RequiredFieldValidator>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                   <asp:Label ID="lblContent" runat="server" Text="Message"></asp:Label>
                               </td>
                               <td colspan="2">
                                   <asp:TextBox ID="txtContent" runat="server" Columns="10" Height="208px" TextMode="MultiLine" Width="525px"></asp:TextBox>
                               </td>
                               <td>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtContent" ErrorMessage="input message" ForeColor="Red"></asp:RequiredFieldValidator>
                               </td>
                           </tr>
                           <tr>
                               <td>&nbsp;</td>
                               <td>
                                   <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" />
                               </td>
                               <td>
                                   <asp:Button ID="btnClear" runat="server" Text="clear" OnClick="btnClear_Click" />
                               </td>
                               <td>&nbsp;</td>
                           </tr>
                       </table>
        </center>
                       <br />
&nbsp;




</asp:Content>

