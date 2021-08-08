using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusniessLogicLayer;

public partial class ÖğrenciListele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityOGR> ogrenciler = BLLOGR.bllogrlistele();
        Repeater1.DataSource = ogrenciler;
        Repeater1.DataBind();
    }
}