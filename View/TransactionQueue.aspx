<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="TransactionQueue.aspx.cs" Inherits="Project1._0.View.TransactionQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Queue</h1>
    <asp:GridView ID="gvTransactions" runat="server" AutoGenerateColumns="false" OnRowEditing="gvTransactions_RowEditing" OnRowUpdating="gvTransactions_RowUpdating">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate"></asp:BoundField>
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status"></asp:BoundField>
            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                    <asp:Button ID="HandledBtn" runat="server" Text="Handle" UseSubmitBehavior="false" CommandName="Update"/> 
                    <asp:Button ID="SelectBtn" runat="server" Text="Select" UseSubmitBehavior="false" CommandName="Edit"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div>
        <asp:Label ID="ErrorMsg" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
