<%@ Page Language="C#" AutoEventWireup="true" CodeFile="print.aspx.cs" Inherits="_Default" %>

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
        <h3>Print Booking Details</h3>
        <div id="msg" class="msg" runat="server"></div>
        
                <div style="padding:20px;">
            <div style="padding:3px; margin:3px;">Room ID: <span id="roomid" runat="server" style="font-weight:bold;"></span></div>
            <div  style="padding:3px; margin:3px;">Fullname: <span id="fullname" runat="server" style="font-weight:bold;"></span></div>
            <div  style="padding:3px; margin:3px;">Apartment Name: <span id="apartment_name" runat="server" style="font-weight:bold;"></span></div>
            <div  style="padding:3px; margin:3px;">Apartment Type: <span id="apartment_type" runat="server" style="font-weight:bold;"></span></div>
            <div  style="padding:3px; margin:3px;">Amount: <span id="amount" runat="server" style="font-weight:bold;"></span></div>
            <div  style="padding:3px; margin:3px;">Address: <span id="address" runat="server" style="font-weight:bold;"></span></div>
            <div  style="padding:3px; margin:3px;">Phone Number: <span id="phone" runat="server" style="font-weight:bold;"></span></div>
            <div  style="padding:3px; margin:3px;">Date:  <span id="date" runat="server" style="font-weight:bold;"></span></div>
                </div>
                <hr />
                 <div style="text-align:center;">
        <asp:Button ID="Button1" runat="server" Text="Print Reciept" OnClientClick="window.print()" style="padding:4px; cursor:pointer;"    /> </div>
        </div>
            </div>
       <div class="clear"></div>
        <div id="footer">
    All  right Reserved copyright &copy; 2023.&nbsp;&nbsp;&nbsp;&nbsp;Project by &nbsp;<a href="#" style="font-weight:bold; text-decoration:none; color:#000;">YAHUZA ABDULMALIK (HNDCS/021/596)</a>
    </div>

    </form>
</body>
</html>
