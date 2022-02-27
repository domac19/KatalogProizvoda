using KatalogProizvoda.Models;
using KatalogProizvoda.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatalogProizvoda.Controllers
{
    public class ITProizvodiController : Controller
    {
        private ApplicationDbContext _appContext;       
        public ITProizvodiController()
        {
            _appContext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _appContext.Dispose();
        }

        public ViewResult Index()
        {
            return View("Index");
        }
        public ActionResult New()
        {
            var itProizvodi = _appContext.ITProizvodi.ToList();
            var viewModel = new ITProizvodViewModel
            {
                ITProizvod = new ITProizvod(),
            };

            return View("ITProizvodForm", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(ITProizvod iTProizvod)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new ITProizvodViewModel
                {
                    ITProizvod = iTProizvod
                };
                return View("ITProizvodForm", viewModel);
            }
            if (iTProizvod.Id == 0)
            {
                _appContext.ITProizvodi.Add(iTProizvod);
            }
            else
            {
                var iTproizvodDb = _appContext.ITProizvodi.Single(m => m.Id == iTProizvod.Id);

                iTproizvodDb.Kamera = iTProizvod.Kamera;
                iTproizvodDb.Laptop = iTProizvod.Laptop;
                iTproizvodDb.Miš = iTProizvod.Miš;
                iTproizvodDb.PC = iTProizvod.PC;
                iTproizvodDb.Slušalice = iTProizvod.Slušalice;
                iTproizvodDb.Tipkovnica = iTProizvod.Tipkovnica;
                iTproizvodDb.Zvučnik = iTProizvod.Zvučnik;
            }
            _appContext.SaveChanges();

            return RedirectToAction("Index", "ITProizvodi");
        }
        public ActionResult Edit(int id)
        {
            var iTProizvod = _appContext.ITProizvodi.SingleOrDefault(m => m.Id == id);
            if (iTProizvod == null)
                return HttpNotFound();

            var viewModel = new ITProizvodViewModel
            {
                ITProizvod = iTProizvod
            };

            return View("FormMovies", viewModel);
        }
        public ActionResult Details(int id)
        {
            var iTProizvodi = _appContext.ITProizvodi.SingleOrDefault(m => m.Id == id);
            return View(iTProizvodi);
        }
    }
}