<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userhome.aspx.cs" Inherits="userhome" %>

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
            width: 393px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
        <table class="style1" border="1" style="background-color: #00FFFF">
            <tr>
                <td class="style2">
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        style="text-align: center" Text="Account Details" />
                </td>
                <td style="text-align: center">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        style="text-align: center" Text="Transfer Funds" />
                </td>
                <td style="font-weight: 700; text-align: center">
                    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Logout" />
                </td>
                 <td style="font-weight: 700; text-align: center">
                    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="CSRF Attack Details" />
                </td>
            </tr>
        </table>
   <br />
        Your Account Balance :&nbsp; 
        <asp:Label ID="Label1" runat="server" style="color: #FF3300" Text="Label" 
            Visible="False" Width="198px"></asp:Label>
   <br />

    </div>
    </form>
</body>
</html>
