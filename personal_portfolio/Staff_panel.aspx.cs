using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace personal_portfolio
{
    public partial class Staff_panel : System.Web.UI.Page
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
            cmd = new SqlCommand("select * from Approved_account_staff_tbl where Email='" + email + "'" ,con);

            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
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
            if (Session["staff_email_login"] != null)
            {
                txt_user.Text = Session["staff_email_login"].ToString();
            }

            if (IsApproved(Session["staff_email_login"].ToString()))
            {

                txt_search.Visible = true;
                btn_search.Visible = true;
                btn_addStudents.Visible = true;
                lbl_ttl_std.Visible = true;
                GridView1_StaffPanel.Visible = true;


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

        protected void button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("addStudents.aspx");
        }
    }
}