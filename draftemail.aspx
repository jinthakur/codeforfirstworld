<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="draftemail.aspx.cs" Inherits="draftemail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">

    <table style="width: 100%;margin-left:32px">
        <tr>
            <td>
                 From :
               

            </td>
            <td>
                <input id="Text1" type="text"  runat="server" />&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td> To &nbsp;:</td>
            <td>
                <input id="Text2" type="text"  runat="server"/>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td> Subject : 
               &nbsp;</td>
            <td> <input id="sub" type="text" runat="server" />&nbsp;</td>
            <td>&nbsp;</td>

        </tr>
        <tr>
            <td> Prank Msg 
               &nbsp;:</td>
            <td> <input id="PraNKMSG" type="text"   runat="server"/>&nbsp;</td>
            <td>&nbsp;</td>

        </tr>
        <tr>
            <td> REAL Msg
              &nbsp;:</td>
            <td>  <input id="rEALMSG" type="text"  runat="server" />&nbsp;</td>
            <td>&nbsp;</td>

        </tr>
        <tr>
            <td> <asp:Button ID="Button1" runat="server" Text="Send Email" OnClick="Button1_Click" />
              </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>

        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
</asp:Content>

