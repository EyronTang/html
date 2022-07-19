<%@ Page Language="C#" AutoEventWireup="true" CodeFile="new_member.aspx.cs" Inherits="new_member" %>

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
                <td align = "center" bgcolor ="#00FFFF">新增帳號系統:</td>
            </tr>
            <tr>
                <td>帳號:<input type = "text" name = "account" /></td>
            </tr>
            <tr>
                <td>密碼:<input type = "password" name = "password" /></td>
            </tr>
            <tr>
                <td>姓名:<input type = "text" name = "name" /></td>
            </tr>
            <tr>      
                <td>     
                    <asp:Button ID="Button1" runat="server" Text="確定" OnClick="Button1_Click" />
                    
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
