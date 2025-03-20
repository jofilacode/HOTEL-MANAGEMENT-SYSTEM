<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bookings.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>HOTEL MANAGEMENT SYSTEM</title>
    <script src="js/jquery.js"></script>
     <script src="js/script.js"></script>
    <link href="css/design.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
    <h1>HOTEL MANAGEMENT SYSTEM</h1>
    </div>
        <div id="nav">
            <ul>
                <li><a href="default.aspx">Home</a></li>
                <li><a href="find_apartment.aspx">Find Apartment</a></li>
                <li><a href="bookings.aspx">Bookings</a></li>
                <li><a href="make_payment.aspx">Make Payment</a></li>
                <li><a href="admin_login.aspx">Admin Login</a></li>               
            </ul>


        </div>
       
        <div id="content">
        <div class="form">
        <h3>Book House</h3>
        <div id="msg" class="msg" runat="server"></div>
        <input type="text" runat="server" id="houseid" placeholder="Enter Room-ID" class="txtbox" />
        <asp:Button ID="Button1" runat="server" Text="Confirm Apartment" CssClass="btn" OnClick="confirm_house"  />
            <hr />
        <div class="bookpics" id="bookpics" runat="server">
            <img id="pics1" runat="server" src="#" alt="house_pics" />
            <img id="pics2" runat="server" src="#" alt="house_pics" />
            <img id="pics3" runat="server" src="#" alt="house_pics" />

            <p style="clear:both;"></p>

            <div class="house_info" >

            <span>Apartment-Name: </span>
             <p id="apartmentname" runat="server"></p>

            <span>Apartment-Type: </span>
             <p id="apartnametype" runat="server"></p>

             <span>Apartment-Amount: </span>
             <p id="apartmentamount" runat="server"></p>

            

            </div>
            <hr />

            <input type="text" runat="server" id="fullname" placeholder="Fullname" class="txtbox" />
            <input type="text" runat="server" id="address" placeholder="address" class="txtbox" />
            <input type="text" runat="server" id="phone_number" placeholder="Phone Number" class="txtbox" />

                

        <asp:Button ID="Button2" runat="server" Text="Book Apartment" CssClass="btn" OnClick="book_house"  />
        </div>
       </div>

        </div>
       <div class="clear"></div>
        <div id="footer">
    All  right Reserved copyright &copy; 2023.&nbsp;&nbsp;&nbsp;&nbsp;Project by &nbsp;<a href="#" style="font-weight:bold; text-decoration:none; color:#000;">YAHUZA ABDULMALIK (HNDCS/021/596)</a>
    </div>

    </form>
</body>
</html>
