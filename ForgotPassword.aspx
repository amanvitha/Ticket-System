<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Ticket_System.Ticket.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align:center">
    <form id="form1" runat="server">
        <div>
            <h1>XPAY Life bank</h1>
            <h2>Password Reset Form</h2>

        </div>
        Select Question?<br />
        <asp:DropDownList ID="question" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="code"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dotnetConnectionString2 %>" SelectCommand="SELECT [name], [code] FROM [tbl_security_question_master]"></asp:SqlDataSource>
        <br />
        <br />
            <asp:Label runat="server" Text="Type Answer"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="answer"></asp:TextBox><br />
        <br />
            <asp:Label runat="server" Text="Enter mobile Number"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="mobil"></asp:TextBox><br />
        <br />
            <asp:Label runat="server" Text="Enter new Password"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="pwd"></asp:TextBox><br />
        <br />

       
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        <br />
        <asp:Label ID="Resetmsg" runat="server"></asp:Label>

       
    </form>
</body>
</html>
