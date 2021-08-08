using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stok_Takip_Sitesi.Models;

namespace Stok_Takip_Sitesi.Controllers
{
    public class ÜrünlerController : Controller
    {
        StokTakipVeritabanıEntities dB = new StokTakipVeritabanıEntities();

        public ActionResult ÜrünListele()
        {
            var ürünler = dB.URUNTABLOSU.ToList();
            return View(ürünler);
        }

        [HttpGet]
        public ActionResult ÜrünEkle()
        {
            List<SelectListItem> urunler = (from i in dB.KATEGORITABLOSU.ToList() select new SelectListItem { Text = i.KATEGORIAD, Value = i.KATEGORIID.ToString()}).ToList();

            ViewBag.urn = urunler;

            return View();
        }

        [HttpPost]
        public ActionResult ÜrünEkle(URUNTABLOSU p)
        {
            var ktgr = dB.KATEGORITABLOSU.Where(k => k.KATEGORIID == p.KATEGORITABLOSU.KATEGORIID).FirstOrDefault();

            p.KATEGORITABLOSU = ktgr;

            dB.URUNTABLOSU.Add(p);

            dB.SaveChanges();

            return RedirectToAction("ÜrünListele");


        }

        public ActionResult ÜrünSil(int id)
        {
            var urun = dB.URUNTABLOSU.Find(id);

            dB.URUNTABLOSU.Remove(urun);

            dB.SaveChanges();

            return RedirectToAction("ÜrünListele");
        }
    }
}