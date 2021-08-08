using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusniessLogicLayer;


public partial class ÖğrenciEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnkayıtol_Click(object sender, EventArgs e)
    {
        EntityOGR ent = new EntityOGR();

        ent.OGRAD = txtboxad.Text;
        ent.OGRSOYAD = txtboxsoyad.Text;
        ent.OGRMAIL = txtboxmail.Text;
        ent.OGRSIFRE = txtboxsifre.Text;
        ent.OGROKULNO = txtboxokulno.Text;

        BLLOGR.bllogrekle(ent);
    }
}