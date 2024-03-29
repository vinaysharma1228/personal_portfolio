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
    public partial class Site1 : System.Web.UI.MasterPage
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            getConn();
            cmd = new SqlCommand("insert into conatct_info_tbl (Name,Email,Subject,Message) values('" + txt_name.Text + "','" + txt_subject.Text + "','" + txt_msg.Text + "') ", con);
            cmd.ExecuteNonQuery();
        }
    }
}