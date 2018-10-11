<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="tourchitiet.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">giohang</asp:LinkButton>
    <asp:DataList ID="DataList2" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td rowspan="4">
                        <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl='<%# "~/img/"+Eval("hinh") %>' style="text-align: center" Width="150px" />
                    </td>
                    <td class="auto-style2">thuong hieu</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("thuonghieu") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">mo ta</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("mota") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">don gia</td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("dongia") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">so luong</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <br />
                        <asp:Button ID="Button" runat="server" CommandArgument='<%# Eval("matour") %>' OnClick="Button_Click" Text="OK" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

