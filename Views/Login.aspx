<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Raamen.Views.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
                <asp:Label ID="LblUsername" runat="server" Text="Username"></asp:Label>
                <br />
                <asp:TextBox ID="tbUsername" runat="server" Width="196px"></asp:TextBox>
                <br />
                <asp:Label ID="LblError1" runat="server" Text=" " ForeColor="red"></asp:Label>
                <br />
                <asp:Label ID="LblPassword" runat="server" Text="Password"></asp:Label>
                <br />
                <asp:TextBox ID="tbPassword" runat="server" Width="196px"></asp:TextBox>
                <br />
                <asp:Label ID="LblError2" runat="server" Text=" " ForeColor="red"></asp:Label>
                <br />
                <asp:CheckBox ID="CbRemember" runat="server" />
                <asp:Label ID="lblRemember" runat="server" Text="Remember Me"></asp:Label>
                <br />
                <asp:Button ID="Button3" runat="server" Text="Login" OnClick="Button3_Click" Width="207px" />
</asp:Content>
