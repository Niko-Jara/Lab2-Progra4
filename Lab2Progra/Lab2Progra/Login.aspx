<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab2Progra.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <asp:Label Text="User Login" runat="server" />
  
        <p>
            <asp:Label Text="Usuario" runat="server" />
            </p>
        <p>
            <asp:TextBox ID="txtUsuario" runat="server"  />
            </p>
        <p>
            <asp:Label Text="Contraseña" runat="server" />
            </p>
        <p>
            <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" />
            </p>
        <p>
            <asp:Button ID="Btn" runat="server" Text="Ingresar" OnClick="Btn_Click" />
        </p>
    </form>
</body>

</html>
