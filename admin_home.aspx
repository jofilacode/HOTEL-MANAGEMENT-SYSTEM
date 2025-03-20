<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_home.aspx.cs" Inherits="admin_home" %>

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
               <li><a href="admin_home.aspx">Home</a></li>
                <li><a href="admin_upload.aspx">Post Apartments</a></li>
                <li><a href="admin_record.aspx">Apartments Record</a></li>
                <li><a href="admin_payment_record.aspx">Payments Record</a></li>  
                <li><a href="admin_login.aspx">logout</a></li>           
            </ul>


        </div>
       <div id="banner">
            <img src="images/admin_banner.jpg" alt="image" />
        </div>
        <div id="content">
            

        </div>
       <div class="clear"></div>
        <div id="footer">
    All  right Reserved copyright &copy; 2023.&nbsp;&nbsp;&nbsp;&nbsp;Project by &nbsp;<a href="#" style="font-weight:bold; text-decoration:none; color:#000;"> YAHUZA ABDULMALIK (HNDCS/021/596)</a>
    </div>

    </form>
</body>
</html>

