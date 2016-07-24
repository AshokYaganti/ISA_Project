<%@ Page Language="C#" AutoEventWireup="true" Debug="true" CodeFile="email.aspx.cs" Inherits="email" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
 <head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 169px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="0" cellpadding="0" cellspacing="0" style="width: 464px">
                <tr>
                    <td class="auto-style1">To:
                    </td>
                    <td>
                        <asp:TextBox ID="txtTo" runat="server" Width="204px"></asp:TextBox>
                    </td>
                </tr>
 
                <tr>
                    <td class="auto-style1">Subject:
                    </td>
                    <td>
                        <asp:TextBox ID="txtSubject" runat="server" Width="201px"></asp:TextBox>
                    </td>
                </tr>
 
                <tr>
                    <td class="auto-style1">Attachment:
                    </td>
                    <td>
                        <asp:FileUpload ID="fileUploader" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td valign="top" class="auto-style1">Body:
                    </td>
                    <td>
                       <img src='images/laptop.jpg' width='100' height='100'/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;
                    </td>
                </tr>
 
                <tr>
                    <td class="auto-style1"></td>
                    <td>
                        <asp:Button ID="bttn_Send" Text="Send Mail" runat="server" OnClick="bttn_Send_Click" />
                    </td>
                </tr>
            </table>
 
        </div>
    </form>
</body>
</html>