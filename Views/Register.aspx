<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Raamen.Views.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                    <br />
                    <asp:TextBox ID="tbUsername" runat="server" Width="196px"></asp:TextBox>
                    <br />
                </div>
                <div>
                    <asp:Label ID="LblEmail" runat="server" Text="Email"></asp:Label>
                    <br />
                    <asp:TextBox ID="tbEmail" runat="server" Width="196px"></asp:TextBox>
                    <br />
                </div>
                <div>
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Gender"></asp:Label>
                    <asp:RadioButtonList ID="radioGender" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
               </div>

                </div>
                <div>
                    <asp:Label ID="LblPassword" runat="server" Text="Password"></asp:Label>
                    <br />
                    <asp:TextBox ID="TbPassword" runat="server" Width="196px"></asp:TextBox>
                    <br />
                </div>
                <div>
                    <asp:Label ID="LblPasswordConfirm" runat="server" Text="Password Confirmation"></asp:Label>
                    <br />
                    <asp:TextBox ID="tbPasswordConfirm" runat="server" Width="196px"></asp:TextBox>
                    <br />
                </div>
                <div>
                    <asp:Label ID="LblRole" runat="server" Text="Role"></asp:Label> <br />
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                </div>
                <asp:Button ID="Button3" runat="server" Text="Register" OnClick="Button3_Click" Width="207px" />
</asp:Content>
