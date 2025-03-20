<%@ Page Language="C#" AutoEventWireup="true" CodeFile="find_apartment.aspx.cs" Inherits="_Default" %>

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
        <h3>Latest Available Accomodation</h3>
       </div>

        <div id="housecon"> 

            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    
                    <div id="housebox">
        <p><%#Eval("apartment_name") %></p>
         <p> <img  src='<%#Eval("house_view1") %> ' alt="House Pics" /> </p>
         <p>  <a href="bookings.aspx?id=<%#Eval("id") %>" style="text-align:center; text-decoration:none; padding:7px; background-color:#17a589; color:#fff; border-radius:10px; margin-right:20px;" >Book Room</a> 
              <%#Eval("amount") %>


         </p>
        </div> 

                </ItemTemplate>

            </asp:Repeater>



            


            
             
        </div>

       
       
         </div>

       <div class="clear"></div>
        <div id="footer">
    All  right Reserved copyright &copy; 2023.&nbsp;&nbsp;&nbsp;&nbsp;Project by &nbsp;<a href="#" style="font-weight:bold; text-decoration:none; color:#000;">YAHUZA ABDULMALIK (HNDCS/021/596)</a>
    </div>

    </form>
</body>
</html>
