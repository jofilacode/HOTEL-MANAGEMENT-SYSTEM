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

        }
        else
        {
            Response.Redirect("admin_login.aspx");
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

    protected void post_house(object sender, EventArgs e)
    {
        int k;
        double num;
        if(apartmentname.Value=="" || apartment_type.Text=="" || amount.Value=="" || photo_value1.Value=="" || photo_value2.Value=="" || photo_value3.Value=="" )
        {
            alert_false("All fields are required");
        }
       
     
        else
        {
            data.new_house(apartmentname.Value, apartment_type.Text, amount.Value, photo_value1.Value, photo_value2.Value, photo_value3.Value);
            if(data.exe==1)
            {
                alert_true(data.msg());
                clear();
            }
            else
            {
                alert_false(data.msg());
            }
        }
    }

    void clear()
    {
        apartmentname.Value = "";
        apartment_type.SelectedIndex = 0;
        amount.Value = "";
     
        photo_value1.Value = "";
        photo_value2.Value = "";
        photo_value2.Value = "";
        photo1.Src = "#";
        photo2.Src = "#";
        photo3.Src = "#";
        apartmentname.Focus();
    }
    protected void upload_house1(object sender, EventArgs e)
    {
        if(FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("/house/" + FileUpload1.PostedFile.FileName));
            photo_value1.Value = "/house/" + FileUpload1.PostedFile.FileName;
            photo1.Src = "/house/" + FileUpload1.PostedFile.FileName;
            alert_true("Uploaded Successfully");
        }
        else
        {
            alert_false("Browse file before upload");
        }


    }


    protected void upload_house2(object sender, EventArgs e)
    {
        if (FileUpload2.HasFile)
        {
            FileUpload2.SaveAs(Server.MapPath("/house/" + FileUpload2.PostedFile.FileName));
            photo_value2.Value = "/house/" + FileUpload2.PostedFile.FileName;
            photo2.Src = "/house/" + FileUpload2.PostedFile.FileName;
            alert_true("Uploaded Successfully");
        }
        else
        {
            alert_false("Browse file before upload");
        }


    }


    protected void upload_house3(object sender, EventArgs e)
    {
        if (FileUpload3.HasFile)
        {
            FileUpload3.SaveAs(Server.MapPath("/house/" + FileUpload3.PostedFile.FileName));
            photo_value3.Value = "/house/" + FileUpload3.PostedFile.FileName;
            photo3.Src = "/house/" + FileUpload3.PostedFile.FileName;
            alert_true("Uploaded Successfully");
        }
        else
        {
            alert_false("Browse file before upload");
        }


    }

    



}