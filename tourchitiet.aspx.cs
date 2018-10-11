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
        string matour = Context.Items["mt"].ToString();
        string query = "select* from tour where matour='" + matour + "'";
        DataTable dt=data.getData(query);
        this.DataList2.DataSource = dt;
        this.DataList2.DataBind();
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Server.Transfer("giotour.aspx");
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        
            Button ok = ((Button)sender);
            string matour = ok.CommandArgument.ToString();
            DataListItem item = (DataListItem)ok.Parent;
            string songuoi = ((TextBox)item.FindControl("TextBox1")).Text;
            if (Request.Cookies["tendangnhap"] == null) return;
            
                string ten = Request.Cookies["tendangnhap"].Value;
                string q = "select*from giotour where tendangnhap='" + ten + "' and matour='" + matour + "'";
                DataTable dt = data.getData(q);
                if (dt.Rows.Count != 0)
                {
                    q = "update giotour set songuoi=songuoi+'" + songuoi + "' where tendangnhap='" + ten + "' and matour='" + matour + "'";
                }
                else
                {
                    q = "insert into giotour values('" + ten + "','" + matour + "','" + songuoi + "')";
                }
                data.Update(q);

            
    }



    
}