using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_home : System.Web.UI.Page
{
   hotel_Api data = new hotel_Api();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["admin"]!= null)
        {
            if (!IsPostBack)
            {
                getdata();
            }
        }
        else
        {
            Response.Redirect("admin_login.aspx");
        }
    }

    void getdata()
    {
        GridView1.DataSource = data.getAllpayment();
        GridView1.DataBind();

      
    }
    void alert_true(string info)
    {

        msg.InnerText = info;
        msg.Style.Add("color", "#16a085");
        msg.Style.Add("background-color", "#d0ece7");
        msg.Style.Add("display", "block");
    }

    void alert_false(string info)
    {
        msg.InnerText = info;
        msg.Style.Add("color", "#c0392b");
        msg.Style.Add("background-color", "#f5b7b1");
        msg.Style.Add("display", "block");
    }


    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName != "removefile") return;
        string id = e.CommandArgument.ToString();
       
            data.delete_payment(id.ToString());
            if (data.exe == 1)
            {
                alert_true(data.msg());
                getdata();
            }
            else
            {
                alert_false(data.msg());
            }
       
    }


}