<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RaiseTicket.aspx.cs" Inherits="Ticket_System.Ticket.RaiseTicket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body style="text-align:left">
    <form id="form1" runat="server">
        <div>
            <h1>Ticket Details</h1>
            <p id="welcome" >
                <asp:Label ID="txtsess" runat="server"></asp:Label>
&nbsp;Raise 
            Ticket</p>
            <p >
                &nbsp;</p>
            <p >
                &nbsp;</p>
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Mobile"></asp:Label>
            :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox><asp:RegularExpressionValidator ID="mobilevalidd" runat="server"  
ControlToValidate="txtmobile" ErrorMessage="Enter Ten Digit Mobile Number"  
ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>  
            <br />
            <br />
            &nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="overview" runat="server"></asp:Label>
            <br />
            Problem:&nbsp;&nbsp;
            <asp:TextBox ID="txtproblem" runat="server"></asp:TextBox>
<%--            <asp:RequiredFieldValidator ID="prbvalid" runat="server" ControlToValidate="txtproblem" ErrorMessage="problem required"></asp:RequiredFieldValidator>--%>
            <br />
            <br />
            Description:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtdesc" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Saveticket" runat="server" OnClick="Saveticket_Click" Text="Save" style="height: 26px" />
        &nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="btnback" runat="server" OnClick="btnback_Click" Text="Back" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="Label1" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
