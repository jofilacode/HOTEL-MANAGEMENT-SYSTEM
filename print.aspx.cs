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
            data.get_booking_details(Session["room_id"].ToString());
            roomid.InnerText = data.b_room_id;
            fullname.InnerText = data.b_fullname;
            apartment_name.InnerText = data.b_apartment_name;
            apartment_type.InnerText = data.b_apartment_type;
            amount.InnerText = data.b_amount;
            address.InnerText = data.b_address;
            phone.InnerText = data.b_phone;
            date.InnerText = data.b_date;
        }
        else
        {
            Response.Redirect("default.aspx");
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


   
}