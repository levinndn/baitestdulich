<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="tour.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList2" runat="server" RepeatColumns="3" style="text-align: center">
    <ItemTemplate>
        <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("matour") %>' Height="150px" ImageUrl='<%# "~/img/"+Eval("hinh") %>' OnClick="ImageButton1_Click" Width="150px" />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("matour") %>' OnClick="LinkButton2_Click" Text='<%# Eval("thuonghieu") %>'></asp:LinkButton>
    </ItemTemplate>
</asp:DataList>
</asp:Content>

