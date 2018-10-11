using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Data data=new Data();
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack) return;
        string q;
        if (Context.Items["ml"] == null) q = "select* from tour";
        else
        {
            string maloai = Context.Items["ml"].ToString();
            q = "select* from tour where maloai='"+maloai+"'";
        }
        DataTable table=data.getData(q);
        this.DataList2.DataSource = table;
        this.DataList2.DataBind();
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string matour = ((ImageButton)sender).CommandArgument;
        Context.Items["mt"] = matour;
        Server.Transfer("tourchitiet.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        string matour = ((LinkButton)sender).CommandArgument;
        Context.Items["mt"] = matour;
        Server.Transfer("tourchitiet.aspx");
    }
}