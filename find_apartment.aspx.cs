using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
   hotel_Api data = new hotel_Api();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        getdata();
    }

    void getdata()
    {
        Repeater1.DataSource = data.getAllhouse();
        Repeater1.DataBind();
    }
}