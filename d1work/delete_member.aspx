<%@ Page Language="C#" AutoEventWireup="true" CodeFile="delete_member.aspx.cs" Inherits="delete_member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border = "1" align ="center">
            <tr>
                <td align = "center" bgcolor ="#00FFFF">刪除帳號系統:</td>
            </tr>
            <tr>
                <td>帳號:<input type = "text" name = "account" /></td>
            </tr>
            <tr>
                <td>密碼:<input type = "password" name = "password" /></td>
            </tr>
            <tr>      
                <td>     
                    <asp:Button ID="Button1" runat="server" Text="確定" />
                    
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
