<%@ Page Language="C#" AutoEventWireup="true" CodeFile="make_payment.aspx.cs" Inherits="_Default" %>

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
        <h3>Demo Pay For Apartment &nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Print Booking" OnClick="print_booking" style="cursor:pointer; background-color:#1eb031; color:#fff; border:0; border-radius:10px; padding:10px; display:none;" />  </h3>
        <div id="msg" class="msg" runat="server"></div>
        <input type="text" runat="server" id="houseid" placeholder="Enter Room-ID" class="txtbox" />
        <input type="text" runat="server" id="contactno" placeholder="Contact Phone Number" class="txtbox" />
        <input type="text" runat="server" id="occupant" placeholder="Occupant (Your Name)" class="txtbox" />
                <hr />
                  <div style="text-align:center;"> <img src="images/card.jpg" alt="cardpics" style="width:60%; height:60px;" /></div>

           <input type="text" id="amount" runat="server" placeholder="Amount" class="txtbox" style="width:15%;"  />
          <input type="text" id="orderid" runat="server" placeholder="Order-ID" class="txtbox" style="width:26%;"  />
          <input type="text" id="cardno" runat="server" placeholder="Card Number" class="txtbox" style="width:45%;"  />
            <input type="text" id="exp" runat="server" placeholder="Exp(MM/YY)" class="txtbox" style="width:29%;"  />
            <input type="text" id="cvv" runat="server" placeholder="CVV" class="txtbox"  style="width:29%;" />
            <input type="password" id="pin" runat="server" placeholder="Pin" class="txtbox"  style="width:28%;"  />
        <asp:Button ID="Button1" runat="server" Text="Make Payment" CssClass="btn" OnClick="pay_house"  />
            <hr />

        </div>
       <div class="clear"></div>
        <div id="footer">
    All  right Reserved copyright &copy; 2023.&nbsp;&nbsp;&nbsp;&nbsp;Project by &nbsp;<a href="#" style="font-weight:bold; text-decoration:none; color:#000;">YAHUZA ABDULMALIK (HNDCS/021/596)</a>
    </div>

    </form>
</body>
</html>
