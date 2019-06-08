<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebImagenes.aspx.cs" Inherits="ProyectoLogin.WebImagenes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagen/197374.svg" />
    <p>
        <img ID="Imagen2" runat="server" alt="" src="~/Imagen/197374.svg" /></p>
       
        <h1>bulleted</h1>
        
        <asp:BulletedList ID="BulletedList1" runat="server" DataTextField="Login" DataValueField="Clave">
        </asp:BulletedList>

        <ul>
            <li>Chile</li>
            <li>Argentina</li>
            <li>Peru</li>
        </ul>
            <h1>DropDownList</h1>

        <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Login" DataValueField="Clave">
        </asp:DropDownList>

        <h1>GridView</h1>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
    </body>
</html>
