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
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            forgot();
        }
        public void forgot()
        {
            string strcon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("update tbl_customer_master set security_questions_Code=@question,security_answer_code=@answer,customer_mobile=@mobile,login_password=@password where security_questions_Code=@question and security_answer_code=@answer and customer_mobile=@mobile ", con);
            cmd.Parameters.AddWithValue("@question", question.Text);
            cmd.Parameters.AddWithValue("@answer", answer.Text);
            cmd.Parameters.AddWithValue("@mobile", mobil.Text);
            cmd.Parameters.AddWithValue("@password", pwd.Text);
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {
                Resetmsg.Text = "Password resetted Successfully";

            }
            else
            {
                Resetmsg.Text = "Error Occured";
            }
            con.Close();
        
    }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}