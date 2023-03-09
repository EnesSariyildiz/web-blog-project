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
            Repeater1.DataSource = hakkımdaTable.HakkımdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.TBL_DeneyimTableAdapter deneyimTable = new DataSet1TableAdapters.TBL_DeneyimTableAdapter();
            //veri kümesi olan DataSet1 içindeki TBL_Egitim tablosuna erişmek için kullanılan TBL_EgitimTableAdapter sınıfından
            //bir örnek oluşturuluyor ve egitimTable adında bir değişkene atılıyor.
            Repeater2.DataSource = deneyimTable.DeneyimListesi();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBL_EgitimTableAdapter egitimTable = new DataSet1TableAdapters.TBL_EgitimTableAdapter();
            Repeater3.DataSource = egitimTable.EgitimListele();
            Repeater3.DataBind();
            //Verileri sayfada görüntüler.

            DataSet1TableAdapters.TBL_HobilerTableAdapter hobilerTable = new DataSet1TableAdapters.TBL_HobilerTableAdapter();
            Repeater5.DataSource = hobilerTable.HobiListesi();
            Repeater5.DataBind();

            DataSet1TableAdapters.TBL_OdullerTableAdapter odullerTable = new DataSet1TableAdapters.TBL_OdullerTableAdapter();
            Repeater6.DataSource = odullerTable.OdulListesi();
            Repeater6.DataBind();

        }
    }
}