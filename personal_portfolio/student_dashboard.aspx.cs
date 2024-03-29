using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace personal_portfolio
{
    public partial class student_dashboard : System.Web.UI.Page
    {

        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mrbin\source\repos\personal_portfolio\personal_portfolio\App_Data\crud_operation.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;

        public void getConn()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        public bool IsApproved(String email)
        {
            getConn();
            cmd = new SqlCommand("select * from Approved_account_student_tbl where Email='" + email + "'", con);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
             if(Session["student_email_login"]!=null)
            {
                lbl_user.Text = Session["student_email_login"].ToString();
            }

            if (IsApproved(Session["student_email_login"].ToString()))
            {
               
                txt_search.Visible = true;
                btn_search.Visible = true;
                btn_achievement.Visible = true;
                lbl_ttl_student.Visible = true;
                txt_ttl_std.Visible = true;


            }
            else
            {
                lbl_account_approved_msg.Visible = true;
                lbl_account_approved_msg.Text = "Your Account Have n't Aprroved Yet 😒. Please Wait Until Approved 🫷.";
            }
        }

        protected void button3_Click(object sender, EventArgs e)
        {
            string script = "if (confirm('Are you sure you want to log out?')) { window.location.href = 'login_page.aspx'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "confirmLogout", script, true);
        }
    }
}