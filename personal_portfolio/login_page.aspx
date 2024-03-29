<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_page.aspx.cs" Inherits="personal_portfolio.login_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
     <link href="login_css.css" rel="stylesheet" />
    <link rel="icon" href="icons/l2.jpg" type="image/x-icon" />
</head>
<body>
    <form id="form1" runat="server">
         <section>
           <div class="color"></div> 
           <div class="color"></div> 
           <div class="color"></div> 
           <div class="box">
               <div class="container">
                   <div class="form">
                       <h2>Login Form </h2>
                        <div class="inputbox">
                           Login As : 📇 <asp:DropDownList ID="ddl_role_login" runat="server" Width="210px" CssClass="style">
                                
                                <asp:ListItem>🧑‍🎓 Student</asp:ListItem>
                                <asp:ListItem>⚕️ Staff</asp:ListItem>
                               <asp:ListItem>🛂 Admin</asp:ListItem>
                            </asp:DropDownList>
                       </div>

                       <div class="inputbox">

                          📧 <asp:TextBox ID="email_login" Width="310px" runat="server" placeHolder=" Email ID " CssClass="style"></asp:TextBox>
                       </div>
                        <div class="inputbox">

                          🛅 <asp:TextBox ID="email_password" Width="310px" runat="server" placeHolder=" Password " CssClass="style" TextMode="Password" ></asp:TextBox>
                       </div>
                       <div class="inputbox">
                           <asp:CheckBox ID="remember_me_chkbox" runat="server" /> Remember Me 
                           <br />
                       <asp:Label ID="ErrorMessageLabel" runat="server" ForeColor="Red"></asp:Label>
                     
                      </div>

                       <div class="inputbox">
                       <a style="color:white">Did'nt Have Account ? 
                           <asp:LinkButton ID="link" runat="server"   PostBackUrl="~/register.aspx">&nbsp Sign Up ➡️. </asp:LinkButton>
                       </a>
                           </div>

                       <div class="inputbox padd" >

                           <asp:Button ID="button1" runat="server" CssClass="style" Text="👌 Login" ForeColor="White" BackColor="Blue" Width="320px" OnClick="button1_Click" />
                       </div>
                   </div>
               </div>
           </div>
       </section>
    </form>
    
       
</body>
</html>
