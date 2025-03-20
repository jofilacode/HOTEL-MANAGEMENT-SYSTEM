using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;


public class hotel_Api
{
    public OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\WEB DEV\HOTEL MANAGEMENT SYSTEM\database\hotel.mdb");
    public string status;
    public int exe;
    public string g_apartmentname, g_apartmenttype, g_amount, g_address, g_landlordname, g_phonenumber, g_houseview1, g_houseview2, g_houseview3;
    public string b_room_id, b_fullname, b_apartment_name, b_apartment_type, b_amount, b_address, b_phone, b_date;

	public hotel_Api()
	{
		
	}

    private void checkconn()
    {
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
    }
    public string msg()
    {
        return status;
    }
    string get_room_id()
    {
        Random rnd = new Random();
        return "Room-" + rnd.Next(10000, 90000).ToString();
    }

     string get_book_id()
    {
        Random rnd = new Random();
        return "Book-" + rnd.Next(10000, 90000).ToString();
    }

     string get_payment_id()
    {
        Random rnd = new Random();
        return "Trans/Ref-" + rnd.Next(10000, 90000).ToString();
    }
    public void new_house(string apartment_name, string apartment_type, string amount, string roomview1,string roomview2, string roomview3)
    {
        checkconn();
        conn.Open();
        string check = "select * from post_rooms where apartment_name=@apartment_name";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@apartment_name", apartment_name);
        OleDbDataReader dr = cmd.ExecuteReader();

        if (dr.Read() == true)
        {
            exe = 0;
            status = "You have previously uploaded this room information!";
        }
        else
        {

            save_house( apartment_name,  apartment_type,  amount,  roomview1, roomview2,  roomview3);
            dr.Close();
            dr.Dispose();

        }
    }

    public void save_house(string apartment_name, string apartment_type, string amount, string roomview1,string roomview2, string roomview3)
    {
        checkconn();
        conn.Open();
        string save = "insert into post_rooms values(@id,@apartname,@aparttype,@amount,@hv1,@hv2,@hv3,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        //cmd.Parameters.AddWithValue("@id", student_ID());
        cmd.Parameters.AddWithValue("@id", get_room_id());
        cmd.Parameters.AddWithValue("@apartname", apartment_name);
        cmd.Parameters.AddWithValue("@aparttype", apartment_type);
        cmd.Parameters.AddWithValue("@amount", amount);
        cmd.Parameters.AddWithValue("@hv1", roomview1);
        cmd.Parameters.AddWithValue("@hv2", roomview2);
        cmd.Parameters.AddWithValue("@hv3", roomview3);
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Room information has been created successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while creating record!";
            exe = 0;
        }
    }

    public DataTable getAllhouse()
    {
        checkconn();
        string check = "select * from post_rooms";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }


    //Book house


    public void new_book(string fullname, string houseid, string apartment_name, string apartment_type, string amount, string address, string phone_number)
    {
        checkconn();
        conn.Open();
        string check = "select * from book_rooms where apartment_name=@apartment_name";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@apartment_name", apartment_name);
        OleDbDataReader dr = cmd.ExecuteReader();

        if (dr.Read() == true)
        {
            exe = 0;
            status = "You have previously booked this room !";
        }
        else
        {

            save_book(fullname, houseid, apartment_name, apartment_type, amount,  address, phone_number);
            dr.Close();
            dr.Dispose();

        }
    }



    public void save_book(string fullname, string houseid, string apartment_name, string apartment_type, string amount, string address, string phone_number)
    {
        checkconn();
        conn.Open();
        string save = "insert into book_rooms values(@id,@houseid,@fullname,@apartname,@aparttype,@amount,@address,@phone,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        //cmd.Parameters.AddWithValue("@id", student_ID());
        cmd.Parameters.AddWithValue("@id", get_book_id());
        cmd.Parameters.AddWithValue("@houseid", houseid);
        cmd.Parameters.AddWithValue("@fullname", fullname);
        cmd.Parameters.AddWithValue("@apartname", apartment_name);
        cmd.Parameters.AddWithValue("@aparttype", apartment_type);
        cmd.Parameters.AddWithValue("@amount", amount);
        cmd.Parameters.AddWithValue("@address", address);
        cmd.Parameters.AddWithValue("@phone", phone_number);     
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "You have successfully book this house please proceed to make payment";
            exe = 1;
        }
        else
        {
            status = "Error while creating record!";
            exe = 0;
        }
    }




    public DataTable getAllbook()
    {
        checkconn();
        string check = "select * from book_rooms";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }


    // PAYMENT MODULE

    public void new_payment(string room_id, string phone_number, string payment_type, string occupant, string p_status)
    {
        checkconn();
        conn.Open();

        string check = "select * from book_rooms where room_id=@room_id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@room_id", room_id);
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string check2 = "select * from payment where room_id=@room_id";
            OleDbCommand cmd2 = new OleDbCommand(check2, conn);
            cmd2.Parameters.AddWithValue("@room_id", room_id);
            OleDbDataReader dr2 = cmd2.ExecuteReader();

            if (dr2.Read() == true)
            {
                exe = 0;
                status = "This room has been booked and paid for already - Please try again!";
            }
            else
            {

                save_pay(room_id, phone_number, payment_type, occupant, p_status);
                dr.Close();
                dr.Dispose();

            }
        }
        else
        {
            status = "Rooms has not been booked or does not exist";
            exe = 0;
        }
    }



    public void save_pay(string room_id, string phone_number, string payment_type, string occupant, string p_status)
    {
        checkconn();
        conn.Open();
        string save = "insert into payment values(@id,@room_id,@phone,@payment_type,@occupant,@p_status,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        //cmd.Parameters.AddWithValue("@id", student_ID());
        cmd.Parameters.AddWithValue("@id", get_payment_id());
        cmd.Parameters.AddWithValue("@room_id", room_id);
        cmd.Parameters.AddWithValue("@phone", phone_number);
        cmd.Parameters.AddWithValue("@payment_type", payment_type);
        cmd.Parameters.AddWithValue("@occupant", occupant);
        cmd.Parameters.AddWithValue("@p_status", p_status);
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Payment successful!";
            exe = 1;
        }
        else
        {
            status = "Error while making payment!";
            exe = 0;
        }
    }




    public DataTable getAllpayment()
    {
        checkconn();
        string check = "select * from payment";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public void get_apartmentData(string room_id)
    {
        checkconn();
        conn.Open();
        string check = "select * from post_rooms where id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", room_id);
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            g_apartmentname = dr[1].ToString();
            g_apartmenttype = dr[2].ToString();
            g_amount = dr[3].ToString();
            g_houseview1 = dr[4].ToString();
            g_houseview2= dr[5].ToString();
            g_houseview3= dr[6].ToString();
            status = " Room found successfully";
            exe = 1;
        }
        else
        {
            status = "No room found with the spcified room-ID";
            exe = 0;
        }


    }


    public void get_booking_details(string book_id)
    {
        checkconn();
        conn.Open();
        string check = "select * from book_rooms where room_id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", book_id);
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            b_room_id = dr[1].ToString();
            b_fullname = dr[2].ToString();
            b_apartment_name = dr[3].ToString();
            b_apartment_type = dr[4].ToString();
            b_amount = dr[5].ToString();
            b_address = dr[6].ToString();
            b_phone = dr[7].ToString();
            b_date = dr[8].ToString();
            status = " Booking found successfully";
            exe = 1;
        }
        else
        {
            status = "No room found with the spcified book-ID";
            exe = 0;
        }


    }


    //DELETE HOUSE INFORMATION

    public void delete_house(string room_id)
    {
        checkconn();
        conn.Open();
        string check = "delete from post_rooms where id=@id";
        string check2 = "delete from book_rooms where room_id=@id2";
        string check3 = "delete from payment where room_id=@id3";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", room_id);
        OleDbCommand cmd2 = new OleDbCommand(check2, conn);
        cmd2.Parameters.AddWithValue("@id2", room_id);
        OleDbCommand cmd3 = new OleDbCommand(check3, conn);
        cmd3.Parameters.AddWithValue("@id3", room_id);
        cmd2.ExecuteNonQuery();
        cmd3.ExecuteNonQuery();
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "House Information has been deleted successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while deleting record!";
            exe = 0;
        }
       
    }

    public void delete_booking(string id)
    {
        checkconn();
        conn.Open();
        string check = "delete from book_rooms where id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", id);
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Booking Information has been deleted successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while deleting record!";
            exe = 0;
        }

    }

    public void delete_payment(string id)
    {
        checkconn();
        conn.Open();
        string check = "delete from payment where id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", id);
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Payment Information has been deleted successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while deleting record!";
            exe = 0;
        }

    }




    

}