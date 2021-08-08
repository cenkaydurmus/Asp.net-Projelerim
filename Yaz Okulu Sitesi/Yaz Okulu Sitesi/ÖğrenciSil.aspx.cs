using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusniessLogicLayer;

public partial class ÖğrenciSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["OgrID"]);

        EntityOGR ent = new EntityOGR();

        ent.ID = id;

        BLLOGR.bllogrsil(ent.ID);

        Response.Redirect("ÖğrenciListele.aspx");
    }
}