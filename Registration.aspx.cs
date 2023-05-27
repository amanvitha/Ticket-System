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
    public partial class Registation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        public void register()
            {
                string strcon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tbl_customer_master (customer_fname ,customer_lname,customer_mobile,customer_email, login_password,customer_address,security_questions_Code,security_answer_code,account_no)values(@fname,@lname,@mobile,@mailid,@password,@address,@security,@answer,@acountnum)", con);
                cmd.Parameters.AddWithValue("@fname", fname.Text);
                cmd.Parameters.AddWithValue("@lname", lname.Text);
                cmd.Parameters.AddWithValue("@mobile", mobile.Text);
                cmd.Parameters.AddWithValue("@mailid ", mailid.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@acountnum", acountnum.Text);
                cmd.Parameters.AddWithValue("@security", security.SelectedValue);
                cmd.Parameters.AddWithValue("@answer", answer.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);

                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    Response.Redirect("Login.aspx");
                    message.Text = "Registered Successfully";
                }
                //return null;
                con.Close();
           

        }

        string mobil, mail;
        protected void Button2_Click(object sender, EventArgs e)
        {

                if (validation())
                {
                    if (mails == true)
                    {
                        message.Text = "E-Mail or Mobile Number Already Exist";
                    }
                }
                else
                {
                    register();
                }
            }
            bool mails = false;
            public bool validation()
            {

                string strcon = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
                SqlConnection con1 = new SqlConnection(strcon);
                con1.Open();
                SqlCommand cmnd1 = new SqlCommand("select customer_mobile,customer_email from tbl_customer_master where customer_mobile=@mobile or  customer_email=@email", con1);
                cmnd1.Parameters.AddWithValue("@mobile", mobile.Text);
                cmnd1.Parameters.AddWithValue("@email", mailid.Text);
                SqlDataAdapter ad = new SqlDataAdapter();
                ad.SelectCommand = cmnd1;
                DataSet ds = new DataSet();
                ad.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    mails = true;
                }
                return mails;
                con1.Close();
            }
        }
    }
