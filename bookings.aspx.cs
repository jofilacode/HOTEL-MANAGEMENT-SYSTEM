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
        if (Request.QueryString["id"] != null)
        {
                data.get_apartmentData(Request.QueryString["id"].ToString());
                alert_true(data.msg());
                apartmentname.InnerText = data.g_apartmentname;
                apartnametype.InnerText = data.g_apartmenttype;
                apartmentamount.InnerText = data.g_amount;
               
                pics1.Src = data.g_houseview1;
                pics2.Src = data.g_houseview2;
                pics3.Src = data.g_houseview3;
                houseid.Value = Request.QueryString["id"].ToString();
                bookpics.Style.Add("display", "block");
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
    protected void confirm_house(object sender, EventArgs e)
    {
        if(houseid.Value=="")
        {
            alert_false("Please enter house-ID to confirm apartment");
        }
        else
        {

            data.get_apartmentData(houseid.Value);
            if(data.exe==1)
            {
                alert_true(data.msg());
                apartmentname.InnerText = data.g_apartmentname;
                apartnametype.InnerText = data.g_apartmenttype;
                apartmentamount.InnerText = data.g_amount;
              
                pics1.Src = data.g_houseview1;
                pics2.Src = data.g_houseview2;
                pics3.Src = data.g_houseview3;
                bookpics.Style.Add("display", "block");
            }
            else
            {
                alert_false(data.msg());
                bookpics.Style.Add("display", "none");
            }
        }
    }
    protected void book_house(object sender, EventArgs e)
    {
        if(fullname.Value=="" || address.Value=="" || phone_number.Value=="")
        {
            alert_false("Please provide your information correctly [Fullname, Address and Phone number]");
        }
        else
        {
            data.new_book(fullname.Value, houseid.Value, apartmentname.InnerText, apartnametype.InnerText, apartmentamount.InnerText, address.Value, phone_number.Value);
            if(data.exe ==1)
            {
                alert_true(data.msg());
                fullname.Value = "";
                address.Value = "";
                phone_number.Value = "";
                houseid.Value = "";
                fullname.Focus();
                Session["room_id"] = Request.QueryString["id"].ToString();
                Response.Redirect("make_payment.aspx");
            }
            else
            {
                alert_false(data.msg());
            }
        }
    }
}