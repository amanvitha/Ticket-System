using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Ticket_System.Ticket
{
    public partial class RaiseTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtsess.Text = Session["user"].ToString();

        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }

        protected void Saveticket_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int n = num.Next();
            Session["TicketNumber"] = n;
            string conn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();

            SqlCommand cmd = new SqlCommand("insert into tbl_ticket_master(ticketnumber,Name,Email,Mobile,Problem,Description,statuscode,userid)values(@ticketnum,@name,@email,@mobile,@prblm,@desc,@code,@userid)", connect);
            cmd.Parameters.AddWithValue("@ticketnum", n);
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@email", txtmail.Text);
            cmd.Parameters.AddWithValue("@mobile", txtmobile.Text);
            cmd.Parameters.AddWithValue("@prblm", txtproblem.Text);
            cmd.Parameters.AddWithValue("@desc", txtdesc.Text);
            cmd.Parameters.AddWithValue("@code", 1);
            cmd.Parameters.AddWithValue("@userid", Session["id"]);

            int x = cmd.ExecuteNonQuery();

            if (x > 0)
            {
                overview.Text = "Thank You For Raising Ticket.Your Ticket Number is:" + n;

            }
            else
            {
                overview.Text = "Something Went Wrong";
            }
            connect.Close();

        }
    }
}