<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Ticket_System.Ticket.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head><body style="text-align:center">
    <form id="form1" runat="server">
        <div>
            <p>Welcome&nbsp;&nbsp;
                <asp:Label ID="session" runat="server"  ></asp:Label>
&nbsp;&nbsp; To XPAY Life </p>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="raise" runat="server"  Text="Raise Ticket" OnClick="raise_Click" />
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="status" runat="server" Text="Ticket Status" OnClick="status_Click"  />
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="tktanl" runat="server"  Text="Ticket Analytics" OnClick="tktanl_Click" />
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="Button1" runat="server"  Text="LogOut" style="height: 26px" OnClick="Button1_Click" />
            </p>
        </div>
    </form>
</body>
</html>
