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
    public partial class Loign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Login1();

        }
        public void Login1()
        {
            string strcon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,customer_fname,login_password from tbl_customer_master where customer_fname=@username and login_password=@password", con);
            cmd.Parameters.AddWithValue("@username", loginusername.Text);
            cmd.Parameters.AddWithValue("@password", loginpasswrd.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["user"] = loginusername.Text;
                Session["id"] = dr["id"];

                Response.Redirect("Welcome.aspx");
            }
            else
            {
                loginerror.Text = "Entered username and passwod mismatch";
            }
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx");
        }
    }
}
