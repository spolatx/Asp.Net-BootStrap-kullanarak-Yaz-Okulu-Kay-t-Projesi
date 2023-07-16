using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YAZOKULUKAYIT
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"]);
            TxtId.Text = x.ToString();
            //ID pasif olmalı. 
            TxtId.Enabled = false;
            if (Page.IsPostBack==false)
            {
                
                EntityOgrenciler ent = new EntityOgrenciler();
                List<EntityOgrenciler> OgrList = BLLOgrenciler.UpdateListBLL(x);
                TxtAd.Text = OgrList[0].Ad.ToString();
                TxtSoyad.Text = OgrList[0].Soyad.ToString();
                TxtNumara.Text = OgrList[0].Numara.ToString();
                TxtSifre.Text = OgrList[0].Sifre.ToString();
                TxtFotograf.Text = OgrList[0].Fotograf.ToString();
            }
            


        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenciler ent = new EntityOgrenciler();
            ent.Ad = TxtAd.Text;
            ent.Sifre = TxtSifre.Text;
            ent.Numara = TxtSifre.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Fotograf = TxtFotograf.Text;
            ent.Id = TxtId.Text;
            BLLOgrenciler.UpdateStudentBLL(ent);

        }
    }
}