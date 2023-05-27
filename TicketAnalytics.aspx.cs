using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Ticket_System.Ticket
{
    public partial class TicketAnalytics : System.Web.UI.Page
    {
        string conntn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(conntn);

            if (connect.State == ConnectionState.Closed)
            {
                SqlCommand cmnd = new SqlCommand("select statuscode,count(id) as data from tbl_ticket_master group by statuscode", connect);
                connect.Open();
                SqlDataReader sd = cmnd.ExecuteReader();
                txtinit.Text = "0  Initiated";
                txtreopen.Text = "0   Re-Opened";
                txtunassign.Text = "0 Un-Assigned";
                txtassign.Text = "0 Assigned";
                txtresolve.Text = "0 Resolved";
                txtclose.Text = "0 Closed";
                while (sd.Read())
                {

                    if (sd[0].ToString() == "1")
                    {
                        if (sd[1].ToString() == null)
                        {
                            txtinit.Text = 0 + "Initiated";
                        }

                        else
                        {
                            txtinit.Text = sd[1].ToString() + "Initiated";
                        }
                    }
                    if (sd[0].ToString() == "6")
                    {
                        if (sd[1].ToString() == null)

                        {
                            txtreopen.Text = 0 + "Re-Opened";
                        }
                        else
                        {
                            txtreopen.Text = sd[1].ToString() + "Re-Opened";
                        }
                    }
                    if (sd[0].ToString() == "2")
                    {
                        if (sd[1].ToString() == null)

                        {
                            txtunassign.Text = 0 + "Un-Assigned";
                        }
                        else
                        {
                            txtunassign.Text = sd[1].ToString() + "Un-Assigned";
                        }

                    }
                    if (sd[0].ToString() == "3")
                    {
                        if (sd[1].ToString() == null)
                        { txtassign.Text = 0 + "Assigned"; }
                        else
                        {
                            txtassign.Text = sd[1].ToString() + "Assigned";
                        }
                    }
                    if (sd[0].ToString() == "4")
                    {
                        if (sd[1].ToString() == null)
                        {
                            txtresolve.Text = 0 + "Resolved";
                        }
                        else
                        {
                            txtresolve.Text = sd[1].ToString() + "Resolved";
                        }
                    }
                    if (sd[0].ToString() == "5")
                    {
                        if (sd[1].ToString() == null)
                        {
                            txtclose.Text = 0 + "Closed";
                        }
                        else
                        {
                            txtclose.Text = sd[1].ToString() + "Closed";
                        }
                    }
                }
                connect.Close();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select statuscode,count(id) as data from tbl_ticket_master group by statuscode", connect);
                da.Fill(ds);
                tktanlytcs.DataSource = ds;
                tktanlytcs.DataBind();


            }
        }

        protected void bck_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }
        protected void tktanlytcs_Load(object sender, EventArgs e)
        {

        }
    }
}