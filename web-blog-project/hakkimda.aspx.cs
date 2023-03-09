using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_blog_project
{
    public partial class hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_HakkımdaTableAdapter hakkımdaTablosu = new DataSet1TableAdapters.TBL_HakkımdaTableAdapter();
            TextBox1.Text = hakkımdaTablosu.HakkımdaListele()[0].AD;
            TextBox2.Text = hakkımdaTablosu.HakkımdaListele()[0].SOYAD;
            TextBox3.Text = hakkımdaTablosu.HakkımdaListele()[0].ADRES;
            TextBox4.Text = hakkımdaTablosu.HakkımdaListele()[0].MAIL;
            TextBox5.Text = hakkımdaTablosu.HakkımdaListele()[0].TELEFON;
            TextBox6.Text = hakkımdaTablosu.HakkımdaListele()[0].KISANOT;
            TextBox7.Text = hakkımdaTablosu.HakkımdaListele()[0].FOTOGRAF;
        }
    }
}