using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProjekatPsa.Models;

namespace ProjekatPsa.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Akademija Savremene Tehnologije";
            ViewBag.Description = "Programi iz oblasti softverskog inzenjeringa i informacionih sistema";
            ViewBag.Keywords = "studije, upis, softver, programi";
            return View();
        }

        public ActionResult FormaUpis()
        {
            ViewBag.Programi = UcitajPrograme();
            var model = new PrijavaUpis
            {
                Kandidat = new Kandidat(),
                DatumPrijave = DateTime.Today
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult FormaUpis(PrijavaUpis model)
        {
            ViewBag.Programi = UcitajPrograme();
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            db.Prijave.Add(model);
            db.SaveChanges();

            return View("Potvrda", model);
        }

        public ActionResult Onama()
        {
            ViewBag.Message = "Fokus na prakticnim projektima, mentorstvu i jasnom planu napredovanja.";
            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "Slobodno nas kontaktirajte za informacije o upisu i rasporedu.";
            return View();
        }

        public ActionResult Programi()
        {
            var programi = UcitajPrograme();
            return View(programi);
        }

        public ActionResult Baza()
        {
            var prijave = db.Prijave.ToList();
            return View(prijave);
        }

        private List<StudijskiProgram> UcitajPrograme()
        {
            return new List<StudijskiProgram>
            {
                new StudijskiProgram { Id = 1, Naziv = "Softverski inzenjering", Opis = "Razvoj web i mobilnih aplikacija", TrajanjeSemestara = 6 },
                new StudijskiProgram { Id = 2, Naziv = "Informacioni sistemi", Opis = "Analiza, projektovanje i upravljanje sistemima", TrajanjeSemestara = 6 },
                new StudijskiProgram { Id = 3, Naziv = "UX i produkt dizajn", Opis = "Dizajn korisnickog iskustva i prototipi", TrajanjeSemestara = 4 }
            };
        }
    }
}
