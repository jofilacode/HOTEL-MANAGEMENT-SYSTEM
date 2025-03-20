<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_payment_record.aspx.cs" Inherits="admin_home" %>

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
            <h3> Payment Record</h3>
                    <div id="msg" class="msg" runat="server"></div>
            </div>
            <asp:GridView ID="GridView1" runat="server" EmptyDataText="No record available yet" OnRowCommand="GridView1_RowCommand">
                  <Columns>
                    <asp:TemplateField ShowHeader="False" >
                   <ItemTemplate>
                            <asp:Button ID="mydelbtn" CssClass="delbtn" runat="server" CausesValidation="false" CommandName="removefile" style="padding:10px; background-color:#bd3d3d;color:#fff; border:0; cursor:pointer; border-radius:10px;"
                             Text="Delete Payment" CommandArgument='<%# Eval("id") %>' />
                      </ItemTemplate>
                    </asp:TemplateField>

                     </Columns>
            </asp:GridView>

        </div>
       <div class="clear"></div>
        <div id="footer">
    All  right Reserved copyright &copy; 2023.&nbsp;&nbsp;&nbsp;&nbsp;Project by &nbsp;<a href="#" style="font-weight:bold; text-decoration:none; color:#000;">YAHUZA ABDULMALIK (HNDCS/021/596)</a>
    </div>

    </form>
</body>
</html>

