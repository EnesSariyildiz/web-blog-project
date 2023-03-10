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
            if (Page.IsPostBack == false)
            {
                //PostBack kullanarak sadece sayfa ilk kez yüklendiği zaman veri tabanından bilgileri almış oluyor.
                //Aşağıda verileri güncellediğimiz zaman güncellenen veriler gözükecektir.

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_HakkımdaTableAdapter dt1 = new DataSet1TableAdapters.TBL_HakkımdaTableAdapter();
            dt1.HakkimdaGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
            Response.Redirect("WebForm1.Aspx");
        }
    }
}