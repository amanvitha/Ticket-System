<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Ticket_System.Ticket.Registation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head><body style="text-align:center">
    <form id="form1" runat="server" >
        <div>
        <h1>XPAY Life Bank</h1>
            <h2>registration Form</h2>
        First Name:<asp:TextBox ID="fname"  runat="server"></asp:TextBox>
        <br />
        <br />
        Last Name:<asp:TextBox ID="lname" runat="server"></asp:TextBox>
            <br />
            <br />
        Mobile:<asp:TextBox ID="mobile" runat="server"></asp:TextBox>
        <br /><asp:RegularExpressionValidator ID="mobilevalid" runat="server"  
ControlToValidate="mobile" ErrorMessage="Enter Ten Digit Mobile Number"  
ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>  
        <br />
        Email ID:<asp:TextBox ID="mailid" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="EmailValid" runat="server" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" ControlToValidate="mailid" ErrorMessage="Invalid Email"></asp:RegularExpressionValidator>
        <br />
        <br />
        Address:<asp:TextBox ID="address" runat="server"></asp:TextBox>
        <br />
        <br />
        Account No.:<asp:TextBox ID="acountnum" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="acountvalidation" runat="server" ControlToValidate="acountnum"   
ErrorMessage="Please enter twelve digits only" ForeColor="Red" ValidationExpression="^(?=.*[0-9]).{12}$"></asp:RegularExpressionValidator>
        <br />
        <br />
        Select Security Question:<asp:DropDownList ID="security" runat="server"  DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="code">
            
        </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dotnetConnectionString %>" SelectCommand="SELECT [name], [code] FROM [tbl_security_question_master]"></asp:SqlDataSource>
        <br />
        <br />
        Security Answer:<asp:TextBox ID="answer" runat="server"></asp:TextBox>
        <br />
        <br />
        Password:<asp:TextBox ID="password" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="pwdvalidation" runat="server" ControlToValidate="password"   
ErrorMessage="Please enter valid password" ForeColor="Red" ValidationExpression="^(?=.*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}$"></asp:RegularExpressionValidator>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
            <asp:Label ID="message" runat="server" Text=""></asp:Label>
        <br />
        <br />
            </div>
    </form>
</body>
</html>
