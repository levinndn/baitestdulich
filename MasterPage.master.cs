using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    Data data =new Data();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack) return;
        string query = "select* from loaitour";
        DataTable dt= data.getData(query);
        this.DataList1.DataSource = dt;
        this.DataList1.DataBind();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string maloai = ((LinkButton)sender).CommandArgument;
        Context.Items["ml"] = maloai;
        Server.Transfer("tour.aspx");
    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string ten = this.Login1.UserName;
        string matkhau = this.Login1.Password;
        string query = "select*from khachhang where tendangnhap='" + ten + "' and matkhau='" + matkhau + "'";
        data = new Data();
        DataTable dt=data.getData(query);
        if (dt.Rows.Count != 0)
        {
            Response.Cookies["tendangnhap"].Value = ten;
            Server.Transfer("tour.aspx");
        }
        else
        {
            this.Login1.FailureText = "Nhap sai tendn hoac matkhau";
        }
    }
}
