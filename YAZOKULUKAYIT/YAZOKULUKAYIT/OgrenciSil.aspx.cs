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
    public partial class OgrenciSil : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"]);
            EntityOgrenciler ent = new EntityOgrenciler();
            
            Response.Write(x);
            ent.Id = x.ToString();
            BLLOgrenciler.DeleteStudentBLL(int.Parse(ent.Id));
            //Tekrar beni yönlendir
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}