using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;


namespace personal_portfolio
{
   
    public partial class admin_dashboard : System.Web.UI.Page
    {

        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mrbin\source\repos\personal_portfolio\personal_portfolio\App_Data\crud_operation.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;


        public void getConn()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        public void countStudents()
        {
            getConn();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Approved_account_student_tbl", con);

       
            int rowCount = (int)cmd.ExecuteScalar();

            txt_ttl_std.Text = rowCount.ToString();
        }

        public void countStaff()
        {
            getConn();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Approved_account_staff_tbl", con);


            int rowCount = (int)cmd.ExecuteScalar();

            txt_total_staff.Text = rowCount.ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            getConn();

            if(ddlist_search.SelectedValue.Equals("Staff"))
            {
                fillgridStaff();
            }
            else
            {
                fillgrid();
            }

            

            countStudents();
            countStaff();
        }

        public DataSet filldataStaff()
        {
            getConn();
            da = new SqlDataAdapter("select * from Approvable_account_staff_tbl", con);
            ds = new DataSet();
            da.Fill(ds);

            return ds;
        }
        public DataSet filldata()
        {
            getConn();
            da = new SqlDataAdapter("select * from Approvable_account_tbl", con);
            ds = new DataSet();
            da.Fill(ds);

            return ds;

        }

        public void fillgridStaff()
        {
            getConn();
            GridView1_adminPanel.DataSource = filldataStaff();
            GridView1_adminPanel.DataBind();
        }

        public void fillgrid()
        {
            getConn();
            GridView1_adminPanel.DataSource = filldata();
            GridView1_adminPanel.DataBind();
        }

        protected void button3_Click(object sender, EventArgs e)
        {
            string script = "if (confirm('Are you sure you want to log out?')) { window.location.href = 'login_page.aspx'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "confirmLogout", script, true);
        }

        protected void ddlist_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlist_search.SelectedValue.Equals("Staff"))
            {
                fillgridStaff();
            }
            else
            {
                fillgrid();
            }
        }

        public DataSet fetchData(int id)
        {
            if (ddlist_search.SelectedValue.Equals("Staff"))
            {
                getConn();
                da = new SqlDataAdapter("select * from Approvable_account_staff_tbl where id='" + id + "'", con);
                ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            else
            {
                getConn();
                da = new SqlDataAdapter("select * from Approvable_account_tbl where id='" + id + "'", con);
                ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            

            if (e.CommandName == "cmd_Approved")
            {
                String fname,lname,email,image;

                getConn();
                int id = Convert.ToInt16(e.CommandArgument);
                ViewState["id"] = id;

                ds = new DataSet();
                ds = fetchData(Convert.ToInt16(ViewState["id"]));

                if(ddlist_search.SelectedValue.Equals("Staff"))
                {
                    fname = (ds.Tables[0].Rows[0][1]).ToString();
                    lname = (ds.Tables[0].Rows[0][2]).ToString();
                    email = (ds.Tables[0].Rows[0][3]).ToString();
                    image = (ds.Tables[0].Rows[0][4]).ToString();

                    cmd = new SqlCommand("insert into Approved_account_staff_tbl (First_Name,Last_Name,Email,Image) values('"+fname+"','"+lname+"','"+email+"','"+image+"')", con);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("delete from Approvable_account_staff_tbl where Id='" + id + "'",con);
                    cmd.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript(this, GetType(), "PostBackScript", "__doPostBack('', '');", true);




                }
                else
                {
                    fname = (ds.Tables[0].Rows[0][1]).ToString();
                    lname = (ds.Tables[0].Rows[0][2]).ToString();
                    email = (ds.Tables[0].Rows[0][3]).ToString();
                    image = (ds.Tables[0].Rows[0][4]).ToString();

                    cmd = new SqlCommand("insert into Approved_account_student_tbl (First_Name,Last_Name,Email,Image) values('" + fname + "','" + lname + "','" + email + "','" + image + "')", con);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("delete from Approvable_account_tbl where Id='" + id + "'", con);
                    cmd.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript(this, GetType(), "PostBackScript", "__doPostBack('', '');", true);

                }


            }
            else
            {
                if(ddlist_search.SelectedValue.Equals("Student"))
                {
                    getConn();
                    int id = Convert.ToInt16(e.CommandArgument);
                    ViewState["id"] = id;

                    cmd = new SqlCommand("delete from Approvable_account_tbl where Id='"+id+"'", con);
                    cmd.ExecuteNonQuery();
                    txt_search.Text = "Deleted..";
                }
                else
                {
                    getConn();
                    int id = Convert.ToInt16(e.CommandArgument);
                    ViewState["id"] = id;

                    cmd = new SqlCommand("delete from Approvable_account_staff_tbl where Id='" + id + "'", con);
                    cmd.ExecuteNonQuery();
                     txt_search.Text = "Deleted..";
                }
               

            }

        }

        protected void button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_staff.aspx");
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            txt_search.Text = "searched clicked 😊.";
        }
    }
}