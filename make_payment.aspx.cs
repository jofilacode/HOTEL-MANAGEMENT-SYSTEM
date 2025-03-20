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
        if(Session["room_id"]!=null)
        {
            houseid.Value = Session["room_id"].ToString();
            Button2.Style.Add("display", "block");
        }
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


    protected void pay_house(object sender, EventArgs e)
    {
        if(houseid.Value=="" || contactno.Value=="" || occupant.Value=="")
        {
            alert_false("Please fill all the required information");
        }
        else
        {
            data.new_payment(houseid.Value, contactno.Value, "Online", occupant.Value, "Successfully");
            if(data.exe==1)
            {
                alert_true(data.msg());
                houseid.Value = "";
                contactno.Value = "";
                occupant.Value = "";
                houseid.Focus();
            }
            else
            {
                alert_false(data.msg());
            }
        }
    }

    protected void print_booking(object sender, EventArgs e)
    {
        Response.Redirect("print.aspx");
    }
}