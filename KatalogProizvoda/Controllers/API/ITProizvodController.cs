using KatalogProizvoda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KatalogProizvoda.Controllers.API
{
    public class ITProizvodController : ApiController
    {
        public ApplicationDbContext _appContext;
        public ITProizvodController()
        {
            _appContext = new ApplicationDbContext();
        }

        //GET/api/ITProizvodi
        public IHttpActionResult GetMovies()
        {
            var iTProizvodi = _appContext.ITProizvodi.ToList();
            return Ok(iTProizvodi);
        }

        //GET/api/iTProizvod/1
        public IHttpActionResult GetMovie(int id)
        {
            var iTProizvodi = _appContext.ITProizvodi.SingleOrDefault(m => m.Id == id);

            if (iTProizvodi == null)
                return NotFound();

            return Ok(iTProizvodi);
        }

        //POST/api/ITProizvodi
        [HttpPost]
        public IHttpActionResult CreateMovie(ITProizvod iTProizvod)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _appContext.ITProizvodi.Add(iTProizvod);
            _appContext.SaveChanges();

            return Ok(iTProizvod.Id);
        }

        //PUT/api/ITProizvodi
        [HttpPut]
        public void UpdateMovie(int id, ITProizvod iTProizvod)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var proizvodDb = _appContext.ITProizvodi.SingleOrDefault(m => m.Id == id);

            if (proizvodDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _appContext.SaveChanges();
        }

        //DELETE/api/ITProizvodi/1
        public void DeleteMovie(int id)
        {
            var proizvodDb = _appContext.ITProizvodi.SingleOrDefault(m => m.Id == id);

            if (proizvodDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _appContext.ITProizvodi.Remove(proizvodDb);
            _appContext.SaveChanges();
        }
    }
}
