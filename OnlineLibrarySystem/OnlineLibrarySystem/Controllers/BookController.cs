using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineLibrarySystem.Models;
using OnlineLibrarySystem.Models.Classes;

namespace OnlineLibrarySystem.Controllers
{
    public class BookController : Controller
    {
        KütüphaneÖdevEntities db = new KütüphaneÖdevEntities();
        public ActionResult ListBooks()
        {
            var listBooks = db.TabloKitap.ToList();
            return View(listBooks);
        }

        public ActionResult ListBooksForNonUsers()
        {
            var listBooks = db.TabloKitap.ToList();
            return View(listBooks);
        }

        public ActionResult ReserveBook(int id)
        {
            var selectedBook = db.TabloKitap.Find(id);
            selectedBook.Adet -= 1;

            AlınanTablosu sendingBook = new AlınanTablosu();
            sendingBook.KitapAd = selectedBook.Ad;
            sendingBook.AlanKullanıcı =Variables.loggedUser.KullanıcıAdı;
            sendingBook.AlınmaTarihi = DateTime.Now.Date;

            db.AlınanTablosu.Add(sendingBook);

            db.SaveChanges();

            return RedirectToAction("ListBooks");
        }

      
        public ActionResult BooksOnMe()
        {
            return RedirectToAction("BooksOnMeLoad",Variables.loggedUser);
        }


       
        public ActionResult BooksOnMeLoad(TabloKullanıcı user)
        {
            var listReservedBooks = db.AlınanTablosu.Where(i => i.AlanKullanıcı == user.KullanıcıAdı).ToList();
            return View(listReservedBooks);
        }


        public ActionResult RebateBook(int id)
        {
            var rebatingBook = db.AlınanTablosu.Find(id);

            var rebatingBookName = rebatingBook.KitapAd.ToString();

            db.AlınanTablosu.Remove(rebatingBook);

            Tabloİade sendingBook = new Tabloİade();
            sendingBook.Ad = rebatingBookName;
            sendingBook.Kullanıcı = Variables.loggedUser.KullanıcıAdı;
            sendingBook.Tarih = DateTime.Now.Date;

            db.Tabloİade.Add(sendingBook);

            db.SaveChanges();

            return RedirectToAction("BooksOnMeLoad",Variables.loggedUser);
        }

        public ActionResult ListBooksAdmin()
        {
            var listBooks = db.TabloKitap.ToList();
            return View(listBooks);
        }

        public ActionResult DeleteBookAdmin(int id)
        {
            var deletingBook = db.TabloKitap.Find(id);
            db.TabloKitap.Remove(deletingBook);
            db.SaveChanges();
            return RedirectToAction("ListBooksAdmin");
        }

        [HttpGet]
        public ActionResult AddBookAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBookAdmin(TabloKitap tempBook)
        {
                db.TabloKitap.Add(tempBook);
                db.SaveChanges();
                return RedirectToAction("ListBooksAdmin");
        }

        [HttpGet]
        public ActionResult EditBookAdmin(int id)
        {
            var selectedBook = db.TabloKitap.Find(id);
            return View(selectedBook);
        }

        [HttpPost]
        public ActionResult EditBookAdmin(TabloKitap tempBook)
        {
            var editingBook = db.TabloKitap.Find(tempBook.ID);
            editingBook.Ad = tempBook.Ad;
            editingBook.Adet = tempBook.Adet;
            editingBook.Kategori = tempBook.Kategori;
            editingBook.Sayfa = tempBook.Sayfa;
            editingBook.Yazar = tempBook.Yazar;
            editingBook.Yıl = tempBook.Yıl;


            db.SaveChanges();

            return RedirectToAction("ListBooksAdmin");
        }

        public ActionResult SeeRebateBooksAdmin()
        {
            var listRebates = db.Tabloİade.ToList();
            return View(listRebates);
        }

        public ActionResult ApproveRebateAdmin(int id)
        {
            var approvingBook = db.Tabloİade.Find(id);

            var approvingBookName = approvingBook.Ad.ToString();

            db.Tabloİade.Remove(approvingBook);

            var addingBookCount = db.TabloKitap.Where(i => i.Ad == approvingBookName).SingleOrDefault();

            addingBookCount.Adet +=1;

            db.SaveChanges();

            return RedirectToAction("SeeRebateBooksAdmin");
        }
    }
}