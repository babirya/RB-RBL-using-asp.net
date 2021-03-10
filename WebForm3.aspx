<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="app2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
    <asp:label runat="server" text="cocher une coulor s'ill vous plait"></asp:label>
    </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" style="height: 27px; width: 82px">
            <asp:ListItem>rouge</asp:ListItem>
            <asp:ListItem>vert</asp:ListItem>
            <asp:ListItem>blue</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="afficher" />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="230px" Width="271px">
        </asp:Panel>
    </form>
</body>
</html>
