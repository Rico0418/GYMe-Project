<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ManageSupplement.aspx.cs" Inherits="Project1._0.View.ManageSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>ManageSupplement</h1>
    <asp:GridView ID="gvSupplements" runat="server" AutoGenerateColumns="false" OnRowEditing="gvSupplements_RowEditing" OnRowDeleting="gvSupplements_RowDeleting">
        <Columns>
            <asp:BoundField DataField="SupplementID" HeaderText="ID" SortExpression="SupplementID"></asp:BoundField>
            <asp:BoundField DataField="SupplementName" HeaderText="Name" SortExpression="SupplementName"></asp:BoundField>
            <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="SupplementExpiryDate"></asp:BoundField>
            <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice"></asp:BoundField>
            <asp:BoundField DataField="SupplementTypeID" HeaderText="TypeID" SortExpression="SupplementTypeID"></asp:BoundField>
            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                    <asp:Button id="EditBtn" runat="server" Text="Edit" UseSubmitBehavior="false" CommandName="Edit"/>
                    <asp:Button id="DeleteBtn" runat="server" Text="Delete" UseSubmitBehavior="false" CommandName="Delete"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div>
        <asp:Label ID="ErrorMsg" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="InsertBtn" runat="server" Text="Insert" onclick="InsertBtn_Click"/>
    </div>
</asp:Content>
