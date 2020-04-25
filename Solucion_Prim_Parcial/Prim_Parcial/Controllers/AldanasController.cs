using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Prim_Parcial.Models;

namespace Prim_Parcial.Controllers
{
    public class AldanasController : ApiController
    {
        private DataContext db = new DataContext();

        public object PostAldana(object aldanas)
        {
            throw new NotImplementedException();
        }

        [Authorize]
        // GET: api/Aldanas
        public IQueryable<Aldana> GetAldanas()
        {
            return db.Aldanas;
        }
        [Authorize]
        // GET: api/Aldanas/5
        [ResponseType(typeof(Aldana))]
        public IHttpActionResult GetAldana(int id)
        {
            Aldana aldana = db.Aldanas.Find(id);
            if (aldana == null)
            {
                return NotFound();
            }

            return Ok(aldana);
        }
        [Authorize]
        // PUT: api/Aldanas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAldana(int id, Aldana aldana)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aldana.AldanaId)
            {
                return BadRequest();
            }

            db.Entry(aldana).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AldanaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        [Authorize]
        // POST: api/Aldanas
        [ResponseType(typeof(Aldana))]
        public IHttpActionResult PostAldana(Aldana aldana)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Aldanas.Add(aldana);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = aldana.AldanaId }, aldana);
        }
        [Authorize]
        // DELETE: api/Aldanas/5
        [ResponseType(typeof(Aldana))]
        public IHttpActionResult DeleteAldana(int id)
        {
            Aldana aldana = db.Aldanas.Find(id);
            if (aldana == null)
            {
                return NotFound();
            }

            db.Aldanas.Remove(aldana);
            db.SaveChanges();

            return Ok(aldana);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AldanaExists(int id)
        {
            return db.Aldanas.Count(e => e.AldanaId == id) > 0;
        }
    }
}