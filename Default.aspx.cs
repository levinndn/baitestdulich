using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack) return;
        Data data = new Data();
        string q = "select* from loaitour";
        DataTable dt = data.getData(q);
        this.DataList2.DataSource = dt;
        this.DataList2.DataBind();
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string maloai = ((ImageButton)sender).CommandArgument;
        Context.Items["ml"] = maloai;
        Server.Transfer("tour.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        string maloai = ((LinkButton)sender).CommandArgument;
        Context.Items["ml"] = maloai;
        Server.Transfer("tour.aspx");
    }
}