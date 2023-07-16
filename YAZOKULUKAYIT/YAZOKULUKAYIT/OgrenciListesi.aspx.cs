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
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CallOgrList();
        }
        void CallOgrList()
        {
            List<EntityOgrenciler> OgrList = BLLOgrenciler.ListBLL();
            Repeater1.DataSource = OgrList;
            Repeater1.DataBind();
        }
    }
}