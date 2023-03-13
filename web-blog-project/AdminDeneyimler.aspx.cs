using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_blog_project
{
    public partial class AdminDeneyimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DeneyimTableAdapter dt = new DataSet1TableAdapters.TBL_DeneyimTableAdapter();
            Repeater1.DataSource = dt.DeneyimListesi();
            Repeater1.DataBind();

        }
    }
}