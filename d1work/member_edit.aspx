<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_edit.aspx.cs" Inherits="member_edit" %>

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
                <td align = "center" bgcolor ="#00FFFF">修改會員資料系統:</td>
            </tr>
            <tr>
                <td>帳號:<asp:TextBox ID="Account" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>密碼:<asp:TextBox ID="Password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>姓名:<asp:TextBox ID="Name" runat="server"></asp:TextBox>
                </td>
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
