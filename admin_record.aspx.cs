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
        GridView1.DataSource = data.getAllhouse();
        GridView1.DataBind();

        GridView2.DataSource = data.getAllbook();
        GridView2.DataBind();
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

    protected void GridView1_OnRowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName != "removefile") return;
        string id = e.CommandArgument.ToString();
        if (CheckBox1.Checked == true)
        {
            data.delete_house(id.ToString());
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
        else
        {
            alert_false("Confirm Delete before proceeding...Note: All data on specified house information will be lost");
        }

    }



    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName != "removefile") return;
        string id = e.CommandArgument.ToString();
        if (CheckBox1.Checked == true)
        {
            data.delete_booking(id.ToString());
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
        else
        {
            alert_false("Confirm Delete before proceeding...Note: All data on specified house information will be lost");
        }
    }
}