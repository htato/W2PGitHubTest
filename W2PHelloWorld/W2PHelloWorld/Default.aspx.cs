using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace W2PHelloWorld
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text.Equals("Show"))
            {
                Image1.Visible = true;
                Button1.Text = "Hide";
            }
            else
            {
                Image1.Visible = false;
                Button1.Text = "Show";
            }
        }
    }
}