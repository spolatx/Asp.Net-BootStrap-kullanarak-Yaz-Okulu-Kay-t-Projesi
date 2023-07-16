using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer;



namespace YAZOKULUKAYIT
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                List<EntityDersler> EntDers = BLLDersler.ListBLL();
                DdlDersler.DataSource = BLLDersler.ListBLL();
                DdlDersler.DataTextField = "DERSAD";
                DdlDersler.DataValueField = "ID";
                DdlDersler.DataBind();
            }
           

        }

        protected void BtnTalep_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm entity = new EntityBasvuruForm();
            entity.BasvuruOgrId=int.Parse(TxtOgrenci.Text);
            entity.BasvuruDersId = int.Parse(DdlDersler.SelectedValue.ToString());
            BLLBasvuruForm.ClassRequestBLL(entity);
        }
    }
}