<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_list.aspx.cs" Inherits="Default2" %>

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
                <td align = "center" bgcolor = "#00FFFF" colspan = "3">會員資料:</td>
            </tr>
            <tr>      
                <td colspan = "3" align ="right">     
                    <a href="new_member.aspx" >新增會員</a>
                </td>
            </tr>
            <tr>
                <td>名稱:</td> <td>帳號:</td> <td>密碼:</td>
            </tr>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>

        </table>
        </div>
    </form>
</body>
</html>
