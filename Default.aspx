<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList2" runat="server" CellSpacing="15" RepeatColumns="3">
    <ItemTemplate>
        <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("maloai") %>' Height="150px" ImageAlign="Middle" ImageUrl='<%# "~/img/"+Eval("hinh") %>' Width="250px" OnClick="ImageButton1_Click" />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("maloai") %>' Text='<%# Eval("tenloai") %>' OnClick="LinkButton2_Click"></asp:LinkButton>
    </ItemTemplate>
</asp:DataList>
</asp:Content>

