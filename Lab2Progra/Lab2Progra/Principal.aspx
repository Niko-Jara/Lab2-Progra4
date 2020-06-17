<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Lab2Progra.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          
        <p id="nomUsuario" runat="server">  </p>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Calcular" OnClick="Button2_Click" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

    </form>
   
</body>
</html>
