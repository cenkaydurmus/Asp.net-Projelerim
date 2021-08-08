using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stok_Takip_Sitesi.Models;

namespace Stok_Takip_Sitesi.Controllers
{
    public class KategoriController : Controller
    {
        StokTakipVeritabanıEntities dB = new StokTakipVeritabanıEntities();

        public ActionResult KategoriListele()
        {
            var kategoriler = dB.KATEGORITABLOSU.ToList();

            return View(kategoriler);
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(KATEGORITABLOSU tempkategori)
        {
            dB.KATEGORITABLOSU.Add(tempkategori);

            dB.SaveChanges();

            Response.Redirect("KategoriListele");

            return View();

           
        }

        public ActionResult KategoriSil(int id)
        {
            var ktgr = dB.KATEGORITABLOSU.Find(id);

            dB.KATEGORITABLOSU.Remove(ktgr);

            dB.SaveChanges();

            return RedirectToAction("KategoriListele");
        }

        public ActionResult KategoriGüncelleAç(int id)
        {
            var ktgr = dB.KATEGORITABLOSU.Find(id);

            return View("KategoriGüncelleAç", ktgr);
        }

        public ActionResult KategoriGüncelle(KATEGORITABLOSU p1)
        {
            var ktgr = dB.KATEGORITABLOSU.Find(p1.KATEGORIID);
            ktgr.KATEGORIAD = p1.KATEGORIAD;
            dB.SaveChanges();
            return RedirectToAction("KategoriListele");
        }
    }
}