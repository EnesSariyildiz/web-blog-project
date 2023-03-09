using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_blog_project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_HakkımdaTableAdapter hakkımdaTable = new DataSet1TableAdapters.TBL_HakkımdaTableAdapter();
            //TableAdepter'ı burada veri tabanından oluşturduğumuz nesneyi okumak için kullanıyoruz.
            Repeater1.DataSource = hakkımdaTable.HakkımdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.TBL_DeneyimTableAdapter deneyimTable = new DataSet1TableAdapters.TBL_DeneyimTableAdapter();
            Repeater2.DataSource = deneyimTable.DeneyimListesi();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBL_EgitimTableAdapter egitimTable = new DataSet1TableAdapters.TBL_EgitimTableAdapter();
            Repeater3.DataSource = egitimTable.EgitimListele();
            Repeater3.DataBind();
            //Verileri sayfada görüntüler.
            
        }
    }
}