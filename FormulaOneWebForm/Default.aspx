<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormulaOneWebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>FormulaOne - WebForm</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--
            UserName <asp:TextBox ID="txtUserName" runat="server" /> <br />
            Password <input type="text" id="txtPassword" /> <br />
            -->
            <asp:Button ID="btnInvia" runat="server" Text="Invia" /> <br />
            <asp:Label ID="lblMessaggio" runat="server" Text=" " />
        </div>
        <div>
            <asp:GridView ID="dgvTabella" runat="server"></asp:GridView>
            <asp:ListBox ID="lbxNazioni" runat="server" Height="400px" Width="400px"></asp:ListBox>
        </div>
    </form>
    
</body>
</html>
