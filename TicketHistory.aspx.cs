using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Ticket_System.Ticket
{
    public partial class TicketHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection con1 = new SqlConnection(strcon);
            con1.Open();
            SqlCommand cmd = new SqlCommand("select id,ticketnumber,statuscode,problem,resolution,name,createdon,resolvedon from tbl_ticket_master", con1);

            SqlDataReader dr = cmd.ExecuteReader();
            history.DataSource = dr;
            history.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }

        protected void Unnamed1_Click1(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,ticketnumber,statuscode,problem,resolution,name,createdon,resolvedon from tbl_ticket_master where  statuscode=1", con);

            SqlDataReader dr = cmd.ExecuteReader();
            history.DataSource = dr;
            history.DataBind();
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,ticketnumber,statuscode,problem,resolution,name,createdon,resolvedon from tbl_ticket_master where  statuscode=2", con);

            SqlDataReader dr = cmd.ExecuteReader();
            history.DataSource = dr;
            history.DataBind();
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,ticketnumber,problem,resolution,name,createdon,resolvedon from tbl_ticket_master where  statuscode=3", con);

            SqlDataReader dr = cmd.ExecuteReader();
            history.DataSource = dr;
            history.DataBind();
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,ticketnumber,problem,resolution,name,createdon,resolvedon from tbl_ticket_master where  statuscode=4", con);

            SqlDataReader dr = cmd.ExecuteReader();
            history.DataSource = dr;
            history.DataBind();
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select  id,ticketnumber,statuscode,problem,resolution,name,createdon,resolvedon from tbl_ticket_master where  statuscode=5", con);

            SqlDataReader dr = cmd.ExecuteReader();
            history.DataSource = dr;
            history.DataBind();
        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,ticketnumber,statuscode,problem,resolution,name,createdon,resolvedon from tbl_ticket_master where  statuscode=6", con);

            SqlDataReader dr = cmd.ExecuteReader();
            history.DataSource = dr;
            history.DataBind();
        }

        protected void history_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow row = history.SelectedRow;
            Label lblid = (Label)row.FindControl("lblid");
            Label lblnum = (Label)row.FindControl("lblnum");
            Label lblname = (Label)row.FindControl("lblname");
            Label lblprblm = (Label)row.FindControl("lblprblm");
            Session["id"] = lblid.Text;
            Session["num"] = lblnum.Text;
            Session["name"] = lblname.Text;
            Session["problem"] = lblprblm.Text;

            Response.Redirect("TicketDetails.aspx");

        }
    }
}