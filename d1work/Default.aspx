<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <table border = "1" align ="center">
            <tr>
                <td align = "center" bgcolor ="#00FFFF">帳號登入系統:</td>
            </tr>
            <tr>
                <td>帳號:<input type = "text" name = "account" /></td>
            </tr>
            <tr>
                <td>密碼:<input type = "password" name = "password" /></td>
            </tr>
            <tr>      
                <td>     
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="確定"/>
                <asp:Label ID="Label1" runat="server" Text="" ></asp:Label>
                </td>
            </tr>
        </table>
        
    </form>
</body>
</html>
