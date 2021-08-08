using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stok_Takip_Sitesi.Models;

namespace Stok_Takip_Sitesi.Controllers
{
    public class MüşteriController : Controller
    {
        StokTakipVeritabanıEntities dB = new StokTakipVeritabanıEntities();

        public ActionResult MüşteriListele()
        {
            var musteriler = dB.MUSTERITABLOSU.ToList();
            return View(musteriler);
        }

        [HttpGet]
        public ActionResult MüşteriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MüşteriEkle(MUSTERITABLOSU tempmusteri)
        {
            dB.MUSTERITABLOSU.Add(tempmusteri);

            dB.SaveChanges();

            Response.Redirect("MüşteriListele");

            return View();
        }

        public ActionResult MüşteriSil(int id)
        {
            var mstr = dB.MUSTERITABLOSU.Find(id);

            dB.MUSTERITABLOSU.Remove(mstr);

            dB.SaveChanges();

            return RedirectToAction("MüşteriListele");
        }

        public ActionResult GüncelleAç(int id)
        {
            var mstr = dB.MUSTERITABLOSU.Find(id);

            return View("GüncelleAç", mstr);
        }

        public ActionResult MüşteriGüncelle(MUSTERITABLOSU p)
        {
            var mstr = dB.MUSTERITABLOSU.Find(p.MUSTERIID);

            mstr.MUSTERIAD = p.MUSTERIAD;

            mstr.MUSTERISOYAD = p.MUSTERISOYAD;

            dB.SaveChanges();

            return RedirectToAction("MüşteriListele");
        }
    }
}