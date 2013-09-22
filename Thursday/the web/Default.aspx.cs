using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int x = 1;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["x"]!=null)
        {
            x = (int)Session["x"];
            x++;

        }
       
        Label1.Text = x.ToString();
        Session["x"] = x;
    }
}