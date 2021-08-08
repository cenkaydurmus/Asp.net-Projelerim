using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OnlineLibrarySystem.Models;
using OnlineLibrarySystem.Models.Classes;

namespace OnlineLibrarySystem.Controllers
{
    public class UserController : Controller
    {
        KütüphaneÖdevEntities db = new KütüphaneÖdevEntities();

       [HttpGet]
        public ActionResult SignUp()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SignUp(TabloKullanıcı tempUser)
        {
            if (ModelState.IsValid )
            {
                var sameNickUser = db.TabloKullanıcı.Where(i => i.KullanıcıAdı == tempUser.KullanıcıAdı);
                if (sameNickUser==null)
                {
                    string newPass = Sha256Class.ComputeSha256Hash(tempUser.Şifre);
                    tempUser.Şifre = newPass;
                    db.TabloKullanıcı.Add(tempUser);
                    db.SaveChanges();
                    return View();
                }
                else
                {
                    Response.Write("This username exists");
                    return View();
                }


              
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(TabloKullanıcı tempUser)
        {
            if (ModelState.IsValid)
            {
                var pass = Sha256Class.ComputeSha256Hash(tempUser.Şifre);
                tempUser.Şifre = pass;
                var loggingUser = db.TabloKullanıcı.Where(i => i.KullanıcıAdı == tempUser.KullanıcıAdı && i.Şifre == tempUser.Şifre).SingleOrDefault();
                if (loggingUser == null)
                {
                    Response.Write("Kullanıcı adı veya şifre yanlış");
                    return View();
                }
                else
                {
                    if (tempUser.KullanıcıAdı=="Admin")
                    {
                        Variables.loggedUser = tempUser;
                        return RedirectToAction("ListBooksAdmin", "Book");
                    }
                    else
                    {
                        Variables.loggedUser = tempUser;
                        Response.Write("Giriş başarılı");
                        return RedirectToAction("ListBooks", "Book");
                    }
                 
                }
            }
            else
            {
                Response.Write("Kullanıcı adı veya şifre boş girilemez");
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Variables.loggedUser = null;
            return RedirectToAction("SignIn");
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult AboutUsForNonUsers()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UserChangePassword()
        {   
            return View(Variables.loggedUser);
        }

        [HttpPost]
        public ActionResult UserChangePassword(TabloKullanıcı tempUser)
        {
            if (Sha256Class.ComputeSha256Hash(tempUser.nullableOldPassword)==Variables.loggedUser.Şifre)
            {
                var editingUser = db.TabloKullanıcı.Where(i => i.KullanıcıAdı == Variables.loggedUser.KullanıcıAdı).SingleOrDefault();
                editingUser.Şifre =Sha256Class.ComputeSha256Hash(tempUser.nullableNewPassword);
                db.SaveChanges();
                Response.Write("Password changed successfully.");
                return RedirectToAction("LogOut");
              
            }
            else
            {
                Response.Write("Cannot change password.Please enter your old password correctly.");
                return RedirectToAction("/Book/ListBooks");
            }
          
        }
    }
}