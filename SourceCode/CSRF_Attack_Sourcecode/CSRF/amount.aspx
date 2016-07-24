<%@ Page Language="C#" AutoEventWireup="true" CodeFile="amount.aspx.cs" Inherits="amount" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            text-align: center;
        }
        .style3
        {
            text-align: center;
            color: #0000FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="style1">
            <tr>
                <td>
                    <h2 class="style3" style="background-color: #66FFFF">
                        Funds Transfer</h2>
                </td>
            </tr>
        </table>
        <table class="style1">
            <tr>
                <td style="text-align: right">
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Home" />
                </td>
            </tr>
        </table>
    <br />
        <table align="center">
            <tr>
                <td class="style2">
                    User Name</td>
                <td>
                   <input type="text" id="uname" name="uname" /></td>
            </tr>
            <tr>
                <td class="style2">
                    Amount</td>
                <td><input type="text" id="amount" name="amount" />
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Transfer" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
