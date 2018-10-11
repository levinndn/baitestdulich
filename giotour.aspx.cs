using System;
using System.Data;
using System.Web.UI;

public partial class _Default : System.Web.UI.Page
{
    Data data=new Data();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack) return;
        if (Request.Cookies["tendangnhap"] == null)
        {
            this.Label1.Text = "Vui long dang nhap de xem gio hang";
            return;
        }
        string ten = Request.Cookies["tendangnhap"].Value;
        string query = "select * from giotour where tendangnhap='"+ten+"'";
        DataTable dt=data.getData(query);
        this.GridView1.DataSource = dt;
        this.GridView1.DataBind();
    }
}