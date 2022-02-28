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
    public class JednostavniProizvodController : ApiController
    {
        public ApplicationDbContext _appContext;
        public JednostavniProizvodController()
        {
            _appContext = new ApplicationDbContext();
        }

        //GET/api/JednostavniProizvodi
        public IHttpActionResult GetMovies()
        {
            var jednostavniProizvodi = _appContext.JednostavniProizvodi.ToList();
            return Ok(jednostavniProizvodi);
        }

        //GET/api/JednostavniProizvod/1
        public IHttpActionResult GetMovie(int id)
        {
            var jednostavniProizvod = _appContext.JednostavniProizvodi.SingleOrDefault(m => m.Id == id);

            if (jednostavniProizvod == null)
                return NotFound();

            return Ok(jednostavniProizvod);
        }

        //POST/api/JednostavniProizvodi
        public IHttpActionResult CreateMovie(JednostavniProizvod jednostavniProizvod)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _appContext.JednostavniProizvodi.Add(jednostavniProizvod);
            _appContext.SaveChanges();

            return Ok(jednostavniProizvod.Id);
        }

        //PUT/api/JednostavniProizvod
        public void UpdateMovie(int id, JednostavniProizvod jednostavniProizvod)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var proizvodDb = _appContext.JednostavniProizvodi.SingleOrDefault(m => m.Id == id);

            if (proizvodDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _appContext.SaveChanges();
        }

        //DELETE/api/JednostavniProizvod/1
        public void DeleteMovie(int id)
        {
            var proizvodDb = _appContext.JednostavniProizvodi.SingleOrDefault(m => m.Id == id);

            if (proizvodDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _appContext.JednostavniProizvodi.Remove(proizvodDb);
            _appContext.SaveChanges();
        }
    }
}