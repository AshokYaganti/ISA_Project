<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewuser.aspx.cs" Inherits="viewuser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SQL Injection Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 50%; margin: 0 auto; text-align: center;">
        <table>
            <tr>
                <td colspan="2">
                    <h2>
                        SQL Injection Demo</h2>
                </td>
            </tr>
            <tr>
                <td>
                    <h3>
                        Welcome
                        <asp:Label ID="lblDetails" runat="server"></asp:Label>
                    </h3>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
