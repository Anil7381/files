<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1><center>USER LOGIN</center></h1>
    
    <form id="form1" runat="server">
        <div><center>
            <asp:Table runat="server" BorderStyle="Groove" CellPadding="10" CellSpacing="5" Font-Bold="True" Font-Overline="False" HorizontalAlign="Justify" Visible="True" Font-Strikeout="False" Font-Size="20" GridLines="None" Font-Italic="False">
        <asp:TableHeaderRow>
            <asp:TableCell>UserName</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="Textbox1" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>Password</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="Textbox2" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>          
    </asp:Table>
             </center>
            <br />
              <center>
                  <asp:Button ID="Button1" runat="server" Text="LOGIN" Font-Bold="True" BorderWidth="2" Font-Size="15" OnClick="Button1_Click" /></center>  
            
        </div>
    </form>
</body>
</html>
