<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_upload.aspx.cs" Inherits="admin_home" %>

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
      
        <div id="content">
            <div class="form">
            <h3>Post House</h3>
            <div id="msg" runat="server" class="msg"></div>
                <input type="text" runat="server" id="apartmentname" placeholder="Apartment Name" class="txtbox" />
                <asp:DropDownList ID="apartment_type" runat="server" CssClass="txtbox2">
                    <asp:ListItem>Single Room</asp:ListItem>
                     <asp:ListItem>Double</asp:ListItem>
                     <asp:ListItem>Suite</asp:ListItem>
                     <asp:ListItem>Family</asp:ListItem>
                     <asp:ListItem>Presidential</asp:ListItem>
                </asp:DropDownList>
                <input type="text" runat="server" id="amount" placeholder="Amount" class="txtbox" />
               

                <p style="margin:10px;">
                    <asp:FileUpload ID="FileUpload1" runat="server" /> <asp:Button ID="Button2" runat="server" Text="Upload" OnClick="upload_house1" /> <img src="#" id="photo1" runat="server" alt="House View 1" height="100" width="100" style="margin:10px;" />  <asp:HiddenField ID="photo_value1" runat="server" />
                </p>
                <p style="margin:10px;">
                    <asp:FileUpload ID="FileUpload2" runat="server" /> <asp:Button ID="Button3" runat="server" Text="Upload" OnClick="upload_house2" /> <img src="#" id="photo2" runat="server" alt="House View 2"  height="100" width="100" style="margin:10px;" />   <asp:HiddenField ID="photo_value2" runat="server" />
                </p>
                <p style="margin:10px;">
                    <asp:FileUpload ID="FileUpload3" runat="server" /> <asp:Button ID="Button4" runat="server" Text="Upload" OnClick="upload_house3" /> <img src="#" id="photo3" runat="server" alt="House View 3"  height="100" width="100" style="margin:10px;" />  <asp:HiddenField ID="photo_value3" runat="server" />
                </p>

                <asp:Button ID="Button1" runat="server" Text="Post House" CssClass="btn" OnClick="post_house"  />
           </div>

        </div>
       <div class="clear"></div>
        <div id="footer">
    All  right Reserved copyright &copy; 2023.&nbsp;&nbsp;&nbsp;&nbsp;Project by &nbsp;<a href="#" style="font-weight:bold; text-decoration:none; color:#000;">YAHUZA ABDULMALIK (HNDCS/021/596)</a>
    </div>

    </form>
</body>
</html>

