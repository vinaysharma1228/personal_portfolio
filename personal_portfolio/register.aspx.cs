using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace personal_portfolio
{
    public partial class register : System.Web.UI.Page
    {
        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mrbin\source\repos\personal_portfolio\personal_portfolio\App_Data\crud_operation.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        SqlCommand cmd4;

        public void getConn()
        {
            con = new SqlConnection(s);
            con.Open();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            getConn();

        }

        public bool IsValidPassword(string password)
        {
            
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";

           
            Regex regex = new Regex(pattern);

           
            return regex.IsMatch(password);
        }
        public bool IsValidEmail(string email)
        {
            
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";        
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        protected void button1_Click(object sender, EventArgs e)
        {

            String fname = txt_fnm.Text;
            String lname = txt_lnm.Text;
            String email = txt_eml.Text;
            String dob = drop_date.SelectedValue + "-" + drop_month.SelectedValue + "-" + drop_year.SelectedValue;

            String imageUrl = "profile_img/vinay.png";
            String password = txt_pass.Text;
            String Cpassword = txt_cpass.Text;

            // for students 

            if (ddl_role_register.Text.Equals("👩‍🎓 Student"))
            {
                if (!string.IsNullOrEmpty(fname))
                {
                    if (!string.IsNullOrEmpty(lname))
                    {
                        if (!string.IsNullOrEmpty(email))
                        {

                            if (IsValidEmail(email))
                            {

                                if (password.Equals(Cpassword))
                                {
                                    if (IsValidPassword(password))
                                    {
                                       
                                        getConn();

                                        cmd = new SqlCommand("insert into Student_register_tbl (First_Name,First_Last,Email,DOB,Gender,Password) values('" + txt_fnm.Text + "','" + txt_lnm.Text + "','" + txt_eml.Text + "','" + dob + "','" + drop_gender.SelectedValue + "','" + txt_pass.Text + "') ", con);
                                        cmd2 = new SqlCommand("insert into Approvable_account_tbl (First_Name,Last_Name,Email,Image) values('" + txt_fnm.Text + "','" + txt_lnm.Text + "','" + txt_eml.Text + "','" + imageUrl + "') ", con);

                                        cmd.ExecuteNonQuery();
                                        cmd2.ExecuteNonQuery();

                                        ErrorMessageLabel2.Text = "Register Done ✅ Now You Can Login 👇";
                                    }
                                    else
                                    {
                                        ErrorMessageLabel2.Text = "Password is not Strong";
                                    }
                                }
                                else
                                {
                                    ErrorMessageLabel2.Text = "Password must be Same .";
                                }

                            }
                            else
                            {
                                ErrorMessageLabel2.Text = "Please enter valid email.";
                            }

                        }
                        else
                        {
                            ErrorMessageLabel2.Text = "First name cannot be Empty.";
                        }



                    }
                    else
                    {
                        ErrorMessageLabel2.Text = "Last name cannot be Empty.";
                    }

                }


                else
                {
                    ErrorMessageLabel2.Text = "First name cannot be Empty.";
                }
            }
            else 
            {
                if (!string.IsNullOrEmpty(fname))
                {
                    if (!string.IsNullOrEmpty(lname))
                    {
                        if (!string.IsNullOrEmpty(email))
                        {

                            if (IsValidEmail(email))
                            {
                                if (password.Equals(Cpassword))
                                {
                                    if (IsValidPassword(password))
                                    {
                                        getConn();

                                        cmd3 = new SqlCommand("insert into Staff_register_tbl (First_Name,First_Last,Email,DOB,Gender,Password) values('" + txt_fnm.Text + "','" + txt_lnm.Text + "','" + txt_eml.Text + "','" + dob + "','" + drop_gender.SelectedValue + "','" + txt_pass.Text + "') ", con);
                                        cmd4 = new SqlCommand("insert into Approvable_account_staff_tbl (First_Name,Last_Name,Email,Image) values('" + txt_fnm.Text + "','" + txt_lnm.Text + "','" + txt_eml.Text + "','" + imageUrl + "') ", con);

                                        cmd3.ExecuteNonQuery();
                                        cmd4.ExecuteNonQuery();

                                        ErrorMessageLabel2.Text = "Register Done ✅ Now You Can Login 👇";
                                        
                                    }
                                    else
                                    {
                                        ErrorMessageLabel2.Text = "Password is not Strong";
                                    }
                                }
                                else
                                {
                                    ErrorMessageLabel2.Text = "Password must be Same .";
                                }

                            }
                            else
                            {
                                ErrorMessageLabel2.Text = "Please enter valid email.";
                            }

                        }
                        else
                        {
                            ErrorMessageLabel2.Text = "First name cannot be Empty.";
                        }



                    }
                    else
                    {
                        ErrorMessageLabel2.Text = "Last name cannot be Empty.";
                    }

                }


                else
                {
                    ErrorMessageLabel2.Text = "First name cannot be Empty.";
                }
            }

            
        }

    }
}