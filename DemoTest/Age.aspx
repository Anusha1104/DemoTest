<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Age.aspx.cs" Inherits="DemoTest.Age" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Date Of Birth</td>
                    <td>
                        <asp:TextBox ID="dtdob" runat="server" TextMode="Date"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                        <asp:TextBox ID="txtage" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
