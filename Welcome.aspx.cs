using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ticket_System.Ticket
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            session.Text = Session["user"].ToString();
        }

        protected void raise_Click(object sender, EventArgs e)
        {
            Response.Redirect("RaiseTicket.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void tktanl_Click(object sender, EventArgs e)
        {
            Response.Redirect("TicketAnalytics.aspx");
        }

        protected void status_Click(object sender, EventArgs e)
        {
            Response.Redirect("TicketHistory.aspx");
        }
    }
}