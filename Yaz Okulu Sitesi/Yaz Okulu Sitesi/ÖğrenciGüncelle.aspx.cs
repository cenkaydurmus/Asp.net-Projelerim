using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusniessLogicLayer;

public partial class ÖğrenciGüncelle : System.Web.UI.Page
{
    int x;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack==false)
        {
            x = Convert.ToInt32(Request.QueryString["OgrID"]);

            List<EntityOGR> ogrlist = BLLOGR.bllogrguncellegoster(x);

            txtboxad.Text = ogrlist[0].OGRAD.ToString();
            txtboxsoyad.Text = ogrlist[0].OGRSOYAD.ToString();
            txtboxmail.Text = ogrlist[0].OGRMAIL.ToString();
            txtboxokulno.Text = ogrlist[0].OGROKULNO.ToString();
            txtboxsifre.Text = ogrlist[0].OGRSIFRE.ToString();
        }
    }

    protected void btnkayıtol_Click(object sender, EventArgs e)
    {
        x = Convert.ToInt32(Request.QueryString["OgrID"]);

        EntityOGR ent = new EntityOGR();

        ent.OGRAD = txtboxad.Text;
        ent.ID = x;
        ent.OGRSOYAD = txtboxsoyad.Text;
        ent.OGRMAIL = txtboxmail.Text;
        ent.OGROKULNO = txtboxokulno.Text;
        ent.OGRSIFRE = txtboxsifre.Text;

        BLLOGR.bllogrguncelle(ent);

        Response.Redirect("ÖğrenciListele.aspx");
    }
}