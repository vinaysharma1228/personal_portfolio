using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace personal_portfolio
{
    public partial class login_page : System.Web.UI.Page
    {

        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mrbin\source\repos\personal_portfolio\personal_portfolio\App_Data\crud_operation.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;

        public void getConn()
        {
            con = new SqlConnection(s);
            con.Open();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            getConn();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            String email = "vinay@gmail.com";
            String password = "12345";
            String role = ddl_role_login.SelectedValue;

            if(role.Equals("🛂 Admin"))
            {
                if (email_login.Text.Equals(email) && email_password.Text.Equals(password))
                {
                    Response.Redirect("admin_dashboard.aspx");
                }
                else
                {
                    email_password.Text = "";
                    email_password.Focus();
                    ErrorMessageLabel.Text = "Wrong Crendentials..";
                }
            }
            else if (role.Equals("⚕️ Staff"))
            {               
                getConn();
                cmd = new SqlCommand("select * from Staff_register_tbl where Email='" + email_login.Text + "' and Password='" + email_password.Text + "'  ", con);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    Session["role"] = role;
                    Session["staff_email_login"] = email_login.Text;
                    Session["staff_password_login"] = email_password.Text;

                    Response.Redirect("Staff_panel.aspx");
                }
                else
                {

                    ErrorMessageLabel.Text = "Invalid email or password";
                }

            }
            else
            {
                

                getConn();
                cmd = new SqlCommand("select * from Student_register_tbl where Email='"+email_login.Text+"' and Password='"+email_password.Text+"'  ", con);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    
                    Session["role"] = role;
                    Session["student_email_login"] = email_login.Text;
                    Session["student_password_login"] = email_password.Text;   
                    
                    Response.Redirect("student_dashboard.aspx");
                }
                else
                {                
                   
                   ErrorMessageLabel.Text= "Invalid email or password";
                }








            }

            

            
        }
    }
}