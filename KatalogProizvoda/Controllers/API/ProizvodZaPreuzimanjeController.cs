using KatalogProizvoda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace KatalogProizvoda.Controllers.API
{
    public class ProizvodZaPreuzimanjeController : ApiController
    {
        public ApplicationDbContext _appContext;
        public ProizvodZaPreuzimanjeController()
        {
            _appContext = new ApplicationDbContext();
        }

        //GET/api/ProizvodiZaPreuzimanje
        public IHttpActionResult GetMovies()
        {
            var proizvodZaPreuzimanje = _appContext.ProizvodiZaPreuzimanjes.ToList();
            return Ok(proizvodZaPreuzimanje);
        }

        //GET/api/ProizvodiZaPreuzimanje/1
        public IHttpActionResult GetMovie(int id)
        {
            var proizvodZaPreuzimanje = _appContext.ProizvodiZaPreuzimanjes.SingleOrDefault(m => m.Id == id);

            if (proizvodZaPreuzimanje == null)
                return NotFound();

            return Ok(proizvodZaPreuzimanje);
        }

        //POST/api/ProizvodiZaPreuzimanje
        public IHttpActionResult CreateMovie(ProizvodZaPreuzimanje proizvodZaPreuzimanje)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _appContext.ProizvodiZaPreuzimanjes.Add(proizvodZaPreuzimanje);
            _appContext.SaveChanges();

            return Ok(proizvodZaPreuzimanje.Id);
        }

        //PUT/api/ProizvodiZaPreuzimanje
        public void UpdateMovie(int id, ProizvodZaPreuzimanje proizvodZaPreuzimanje)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var proizvodDb = _appContext.ProizvodiZaPreuzimanjes.SingleOrDefault(m => m.Id == id);

            if (proizvodDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _appContext.SaveChanges();
        }

        //DELETE/api/ProizvodiZaPreuzimanje/1
        public void DeleteMovie(int id)
        {
            var proizvodDb = _appContext.ProizvodiZaPreuzimanjes.SingleOrDefault(m => m.Id == id);

            if (proizvodDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _appContext.ProizvodiZaPreuzimanjes.Remove(proizvodDb);
            _appContext.SaveChanges();
        }
    }
}