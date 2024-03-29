<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student_dashboard.aspx.cs" Inherits="personal_portfolio.student_dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
   <link href="staff_css.css" rel="stylesheet" />
   <link rel="icon" href="icons/l2.jpg" type="image/x-icon" />
    <style>
        .circular-image {
          border-radius: 5%;
        
          padding:5px;
          
         }

        .label-style {
          margin-left: 10px; /* Adjust the margin as needed */
        }
         .label-style1 {
          margin-left: 45px; /* Adjust the margin as needed */
          margin-top:10px;
        }

         .vertical-line-container {
            display: flex;
            align-items: center;
            border-right: 1px solid black; /* Adjust the color as needed */
            padding-right: 10px; 
            margin-left:50px;
            /* Adjust the padding as needed */
        }

         .long-horizontal-line {
            width: 70%;
            border-top: 1px solid black; /* Adjust the color as needed */
            margin: 10px 0; /* Adjust the margin as needed */
        }

        </style>

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
                       <div style="display: flex; align-items: center;">
                              <asp:Image ID="Image2" runat="server" Height="60px" ImageUrl="~/images/ss_pp.png" Width="60px" CssClass="circular-image" />
                              <asp:Label ID="Label1" runat="server" Text="Welcome " CssClass="label-style"></asp:Label><br />&nbsp;<asp:Label ID="lbl_user" runat="server" Text="User"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; 
                              <asp:Button ID="button3" runat="server" CssClass="style" Text=" Log out ✕" ForeColor="White" BackColor="red" Width="120px" OnClick="button3_Click"/>
                          </div>
                       <div class="label-style1">
                            <asp:Label ID="lbl_account_approved_msg" runat="server" Text="" CssClass="style" Visible="False"></asp:Label><br />
                       </div>
                       <div class="inputbox flexing ">

                          
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                           <asp:TextBox ID="txt_search" Width="220px" Height="50px" runat="server" placeHolder=" Search by name " CssClass="style" Visible="False"></asp:TextBox>
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                           <asp:Button ID="btn_search" runat="server" CssClass="style" Text=" Search " ForeColor="White" BackColor="Blue" Width="320px" Height="50px" Visible="False" />
                          &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btn_achievement" runat="server" CssClass="style" Text=" Add Achievement " ForeColor="White" BackColor="Blue" Width="320px" Height="50px" Visible="False" />
                            
                           &nbsp;
                           <br/>
                           <br/>

                        </div>
                       <br/>

                        &nbsp;    &nbsp;   &nbsp;  <asp:Label ID="lbl_ttl_student" runat="server" Text="Total Students : " Visible="False"></asp:Label><asp:Label ID="txt_ttl_std" runat="server" Text="0" Visible="False"></asp:Label><br /><br />
                      
                       

                        &nbsp;    &nbsp;   &nbsp; <asp:Label ID="Label5" runat="server" Text="Yours Details  👇"></asp:Label><br />
                       <hr class="long-horizontal-line" /><br /><br />
                       <div style="overflow-x: auto; max-height: 250px;">
                           <asp:GridView ID="GridView1_studentPanel" runat="server" AutoGenerateColumns="False" Visible="False">
                               <Columns>
                                   <asp:TemplateField HeaderText="id">
                                       <ItemTemplate>
                                           <asp:Label ID="Label1" runat="server" Text='<%# Eval("Id") %>' CssClass="style"></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="First Name">
                                       <ItemTemplate>
                                           <asp:Label ID="Label2" runat="server" Text='<%# Eval("First_Name") %>' CssClass="style"></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Last Name">
                                       <ItemTemplate>
                                           <asp:Label ID="Label3" runat="server" Text='<%# Eval("Last_Name") %>' CssClass="style"></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Email">
                                       <ItemTemplate>
                                           <asp:Label ID="Label4" runat="server" Text='<%# Eval("Email") %>' CssClass="style"></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Image">
                                       <ItemTemplate>
                                           <asp:Image ID="Image1" runat="server" Width="50" Height="50" ImageUrl='<%# Eval("Image") %>' CssClass="circular-image" />
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Approval">
                                       <ItemTemplate>
                                           <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Id") %>' CssClass="style" CommandName="cmd_Approved"> Approved </asp:LinkButton>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Decline">
                                       <ItemTemplate>
                                           <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("Id") %>' CssClass="style" CommandName="cmd_decline"> Decline </asp:LinkButton>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                               </Columns>
                           </asp:GridView>
                       </div>
                   </div>

               </div>
           </div>
              
       </section>
    </form>
</body>
</html>
