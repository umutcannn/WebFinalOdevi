using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFinal.Controllers
{
    public class BankaController : Controller
    {
       
        public IActionResult Listele()
        {

            using (var session = NhibernateHelper.OpenSession())
            {
                var bankalar = session.Query<Models.Banka>().ToList();
                return View(bankalar);
            }
        }


        public IActionResult Ekle()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Ekle(Models.Banka bank)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var banka = new Models.Banka();
                bank.Ad = bank.Ad;
                bank.Soyad = bank.Soyad;
                bank.Telefon = bank.Telefon;
                bank.Sehir = bank.Sehir;
                bank.Ilce = bank.Ilce;
                session.SaveOrUpdate(bank);
                session.Flush();
            }

            return RedirectToAction("Listele");
        }


        public IActionResult Guncelle(int id)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var guncelle = session.Query<Models.Banka>().FirstOrDefault(b => b.Id == id);
                return View(guncelle);
            }
        }

        [HttpPost]
        public IActionResult Guncelle(Models.Banka bank)
        {


            using (var session = NhibernateHelper.OpenSession())
            {
                var guncelle = session.Query<Models.Banka>().FirstOrDefault(b => b.Id == bank.Id);
                guncelle.Ad = bank.Ad;
                guncelle.Soyad = bank.Soyad;
                guncelle.Telefon = bank.Telefon;
                guncelle.Sehir = bank.Sehir;
                guncelle.Ilce = bank.Ilce;
                guncelle.Banka_Ad = bank.Banka_Ad; 
                session.SaveOrUpdate(guncelle);
                session.Flush();
            }

            return RedirectToAction("Listele");

        }

        public IActionResult Detaylar(int id)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var detay = session.Query<Models.Banka>().FirstOrDefault(b => b.Id == id);
                return View(detay);
            }

        }


        public IActionResult Sil(int id)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var sil = session.Query<Models.Banka>().FirstOrDefault(b => b.Id == id);
                return View(sil);
            }

        }

        [HttpPost]
        public IActionResult Sil(Models.Banka bank)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var sil = session.Query<Models.Banka>().FirstOrDefault(b => b.Id == bank.Id);
                session.Delete(sil);
                session.Flush();
            }

            return RedirectToAction("Listele");

        }

    }
}
