<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketHistory.aspx.cs" Inherits="Ticket_System.Ticket.TicketHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><table class="table table-striped">
                <tr>
                    <td><asp:LinkButton runat="server" OnClick="Unnamed1_Click1"  >Initiated</asp:LinkButton></td>
                
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton runat="server" OnClick="Unnamed2_Click" >Unassigned</asp:LinkButton></td>
                
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton runat="server" s OnClick="Unnamed3_Click" >Assigned</asp:LinkButton>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton runat="server" OnClick="Unnamed4_Click" >Resolved</asp:LinkButton></td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton runat="server" OnClick="Unnamed5_Click" >Closed</asp:LinkButton></td>
                
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton runat="server" OnClick="Unnamed6_Click" >Re-Opened</asp:LinkButton>
                        
                    </td>
                </tr>
                 </table>
        </div><p>
            
            <asp:GridView ID="history" AutoGenerateColumns="False" runat="server" OnSelectedIndexChanged="history_SelectedIndexChanged1"  BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3"  GridLines="Vertical"  >
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:TemplateField HeaderText="id">
                        <ItemTemplate>
                            <asp:Label runat="server" id="lblid" Text='<%# Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Ticket Number"><ItemTemplate>
                            <asp:Label runat="server" id="lblnum" Text='<%# Eval("ticketnumber") %>'></asp:Label>
                        </ItemTemplate></asp:TemplateField>
                    <asp:TemplateField HeaderText="Name"><ItemTemplate>
                            <asp:Label runat="server" id="lblname" Text='<%# Eval("name") %>'></asp:Label>
                        </ItemTemplate></asp:TemplateField>
                    <asp:TemplateField HeaderText="Problem"><ItemTemplate>
                            <asp:Label runat="server" id="lblprblm" Text='<%# Eval("problem") %>'></asp:Label>
                        </ItemTemplate></asp:TemplateField>
                    <asp:CommandField HeaderText="Action" ShowSelectButton="True" />
                    
    </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="Result" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
        </p>
    </form>
</body>
</html>
