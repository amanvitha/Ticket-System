using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Ticket_System.Ticket
{
    public partial class TicketDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["num"] != null && Session["name"] != null && Session["problem"] != null)
            {
                txtnum.Text = Session["num"].ToString();
                txtname.Text = Session["name"].ToString();
                txtprblm.Text = Session["problem"].ToString();
            }
            else
            {
                Response.Redirect("TicketHistory.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string strcon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection cond = new SqlConnection(strcon);
            cond.Open();
            SqlCommand cnd = new SqlCommand("update tbl_ticket_master set ticketnumber=@ticketnumber,name=@name,problem=@problem,statuscode=@code where ticketnumber=" + Session["num"], cond);

            cnd.Parameters.AddWithValue("@ticketnumber", txtnum.Text);
            cnd.Parameters.AddWithValue("@name", txtname.Text);
            cnd.Parameters.AddWithValue("@problem", txtprblm.Text);
            cnd.Parameters.AddWithValue("@code", tktstatus.SelectedValue);
            int xx = cnd.ExecuteNonQuery();
            if (xx > 0)
            {
                result.Text = "Record updated Successfully";
            }

            cond.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("TicketHistory.aspx");
        }
    }
}