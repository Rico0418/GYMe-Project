<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="UpdateSupp.aspx.cs" Inherits="Project1._0.View.UpdateSupp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Supplement</h1>
    <div>
        <asp:Label ID="LblName" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TboxName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LblExpiry" runat="server" Text="Expiry: "></asp:Label>
        <asp:TextBox ID="TboxExpiry" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LblPrice" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="TboxPrice" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LblTypeId" runat="server" Text="Type ID: "></asp:Label>
        <asp:TextBox ID="TboxTypeId" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="ErrorMsg" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click"/>
    </div>
    <div>
        <asp:Button ID="BackBtn" runat="server" Text="Back to Management"  OnClick="BackBtn_Click"/>
    </div>
</asp:Content>
