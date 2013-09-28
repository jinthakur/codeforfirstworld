<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Switchemail.aspx.cs" Inherits="Switchemail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">

    <table style="width: 100%;margin-left:32px">
       
        <tr>
            <td> <asp:Button ID="Button1" runat="server" Text="Switch Email" OnClick="Button1_Click" />
              </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>

        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
</asp:Content>

