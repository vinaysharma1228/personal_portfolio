<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addStudents.aspx.cs" Inherits="personal_portfolio.addStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add students</title>
     <link href="add_students_css.css" rel="stylesheet" />
    <link rel="icon" href="icons/l2.jpg" type="image/x-icon" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section>
           <div class="color"></div> 
           <div class="color"></div> 
           <div class="color"></div> 
           <div class="box">
               <div class="container">
                   <div class="form">
                       <h2>Add Student🧑‍🎓 </h2>

                       <div class="inputbox">
                           👤<asp:TextBox ID="txt_fnm" runat="server" width="140px" placeHolder=" First Name " CssClass="style"></asp:TextBox>
                          
                           👤 <asp:TextBox ID="txt_lnm" runat="server" width="140px" placeHolder=" Last Name " CssClass="style"></asp:TextBox>

                       </div>
                       <div class="inputbox">
                           📅
                           <asp:DropDownList ID="drop_date" runat="server" CssClass="style">
                               <asp:ListItem Value="Date" ></asp:ListItem>
                               <asp:ListItem Value="01" ></asp:ListItem>
                               <asp:ListItem Value="02" ></asp:ListItem>
                               <asp:ListItem Value="03" ></asp:ListItem>
                               <asp:ListItem Value="04" ></asp:ListItem>
                               <asp:ListItem Value="05" ></asp:ListItem>
                               <asp:ListItem Value="06" ></asp:ListItem>
                               <asp:ListItem Value="07" ></asp:ListItem>
                               <asp:ListItem Value="08" ></asp:ListItem>
                               <asp:ListItem Value="09" ></asp:ListItem>
                               <asp:ListItem Value="10" ></asp:ListItem>
                               <asp:ListItem Value="11" ></asp:ListItem>
                               <asp:ListItem Value="12" ></asp:ListItem>
                               <asp:ListItem Value="13" ></asp:ListItem>
                               <asp:ListItem Value="14" ></asp:ListItem>
                               <asp:ListItem Value="15" ></asp:ListItem>
                               <asp:ListItem Value="16" ></asp:ListItem>
                               <asp:ListItem Value="17" ></asp:ListItem>
                               <asp:ListItem Value="18" ></asp:ListItem>
                               <asp:ListItem Value="19" ></asp:ListItem>
                               <asp:ListItem Value="20" ></asp:ListItem>
                               <asp:ListItem Value="21" ></asp:ListItem>
                               <asp:ListItem Value="22" ></asp:ListItem>
                               <asp:ListItem Value="23" ></asp:ListItem>
                               <asp:ListItem Value="24" ></asp:ListItem>
                               <asp:ListItem Value="25" ></asp:ListItem>
                               <asp:ListItem Value="26" ></asp:ListItem>
                               <asp:ListItem Value="27" ></asp:ListItem>
                               <asp:ListItem Value="28" ></asp:ListItem>
                               <asp:ListItem Value="29" ></asp:ListItem>
                               <asp:ListItem Value="30" ></asp:ListItem>
                               <asp:ListItem Value="31" ></asp:ListItem>
                           </asp:DropDownList>

                           <asp:DropDownList ID="drop_month" runat="server" CssClass="style">

                               <asp:ListItem Value="Month"></asp:ListItem>
                               <asp:ListItem Value="Jan"></asp:ListItem>
                               <asp:ListItem Value="Feb"></asp:ListItem>
                               <asp:ListItem Value="Mar"></asp:ListItem>
                               <asp:ListItem Value="Apr"></asp:ListItem>
                               <asp:ListItem Value="May"></asp:ListItem>
                               <asp:ListItem Value="Jun"></asp:ListItem>
                               <asp:ListItem Value="Jul"></asp:ListItem>
                               <asp:ListItem Value="Aug"></asp:ListItem>
                               <asp:ListItem Value="Sep"></asp:ListItem>
                               <asp:ListItem Value="Oct"></asp:ListItem>
                               <asp:ListItem Value="Nov"></asp:ListItem>
                               <asp:ListItem Value="Dec"></asp:ListItem>

                           </asp:DropDownList>

                           <asp:DropDownList ID="drop_year" runat="server" CssClass="style">
                               <asp:ListItem Value="Year"></asp:ListItem>
                               <asp:ListItem Value="2023"></asp:ListItem>
                               <asp:ListItem Value="2022"></asp:ListItem>
                               <asp:ListItem Value="2021"></asp:ListItem>
                               <asp:ListItem Value="2020"></asp:ListItem>
                               <asp:ListItem Value="2019"></asp:ListItem>
                               <asp:ListItem Value="2018"></asp:ListItem>
                               <asp:ListItem Value="2017"></asp:ListItem>
                               <asp:ListItem Value="2016"></asp:ListItem>
                               <asp:ListItem Value="2015"></asp:ListItem>
                               <asp:ListItem Value="2014"></asp:ListItem>
                               <asp:ListItem Value="2013"></asp:ListItem>
                               <asp:ListItem Value="2012"></asp:ListItem>
                               <asp:ListItem Value="2011"></asp:ListItem>
                               <asp:ListItem Value="2010"></asp:ListItem>
                               <asp:ListItem Value="2009"></asp:ListItem>
                               <asp:ListItem Value="2008"></asp:ListItem>
                               <asp:ListItem Value="2007"></asp:ListItem>
                               <asp:ListItem Value="2006"></asp:ListItem>
                               <asp:ListItem Value="2005"></asp:ListItem>
                               <asp:ListItem Value="2004"></asp:ListItem>
                               <asp:ListItem Value="2003"></asp:ListItem>
                               <asp:ListItem Value="2002"></asp:ListItem>
                               <asp:ListItem Value="2001"></asp:ListItem>
                               <asp:ListItem Value="2000"></asp:ListItem>
                               <asp:ListItem Value="1999"></asp:ListItem>
                               <asp:ListItem Value="1998"></asp:ListItem>
                               <asp:ListItem Value="1997"></asp:ListItem>
                               <asp:ListItem Value="1996"></asp:ListItem>
                               <asp:ListItem Value="1995"></asp:ListItem>
                               <asp:ListItem Value="1994"></asp:ListItem>
                               <asp:ListItem Value="1993"></asp:ListItem>
                               <asp:ListItem Value="1992"></asp:ListItem>
                               <asp:ListItem Value="1991"></asp:ListItem>
                               <asp:ListItem Value="1990"></asp:ListItem>
                           </asp:DropDownList>
                       </div>
                       <div class="inputbox">
                           🧬
                           <asp:DropDownList ID="drop_gender" Width="310px" runat="server" CssClass="style">
                               <asp:ListItem Value="Gender" ></asp:ListItem>
                               <asp:ListItem Value="Male" ></asp:ListItem>
                               <asp:ListItem Value="Female" ></asp:ListItem>
                               <asp:ListItem Value="Other" ></asp:ListItem>
                           </asp:DropDownList>
                       </div>

                       <div class="inputbox">

                          📧 <asp:TextBox ID="txt_eml" Width="310px" runat="server" placeHolder=" Email ID " CssClass="style"></asp:TextBox>
                       </div>
                        <div class="inputbox">

                          🛅 <asp:TextBox ID="txt_pass" Width="310px" runat="server" placeHolder=" Password " CssClass="style" TextMode="Password"></asp:TextBox>
                       </div>
                        <div class="inputbox">

                          🛅 <asp:TextBox ID="txt_cpass" Width="310px" runat="server" placeHolder=" Confirm Password " CssClass="style" TextMode="Password"></asp:TextBox>
                       </div>
                        <div class="inputbox">
                       <asp:Label ID="ErrorMessageLabel2" runat="server" ForeColor="Red"></asp:Label>
                     
                      </div>

                      

                       <div class="inputbox" >

                           <asp:Button ID="button1" runat="server" CssClass="style" Text="🧑‍🎓 Add Student" ForeColor="White" BackColor="Blue" Width="340px " OnClick="button1_Click"/>
                       </div>

                       <div class="inputbox" >

                           <asp:Button ID="button2" runat="server" CssClass="style" Text="👈 Back to Home" ForeColor="White" BackColor="Blue" Width="340px " OnClick="button2_Click"/>
                       </div>
                   </div>
               </div>
           </div>
       </section>
        </div>
    </form>
</body>
</html>
