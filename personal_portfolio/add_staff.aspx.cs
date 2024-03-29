using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace personal_portfolio
{
    public partial class add_staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_dashboard.aspx");
        }
    }
}