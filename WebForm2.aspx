<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="app2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="c2" >
    <div>
      formulaire de radio button on asp 
    </div> 
        <div class="c3"> 
            <br />
             <br />
            <br /> 
            choisir un color s'ill vous plait 
            <br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="rouge" GroupName="g1" OnCheckedChanged="RadioButton1_CheckedChanged" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="blue" GroupName="g1" />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="green" GroupName="g1" />
            <asp:RadioButton ID="RadioButton4" runat="server" Text="yellow" GroupName="g1" /> 
               <br />
            <br />
             <br />
            <br />
             
           <asp:Button ID="Button1" runat="server" Text="Get Color" OnClick="Button1_Click" />
            <asp:Panel ID="Panel1" runat="server" BackColor="Gray" Height="285px">
            </asp:Panel>
        </div>
    </form>
</body>
</html>
