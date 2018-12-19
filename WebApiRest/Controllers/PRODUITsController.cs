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
using WebApiRest.Models;

namespace WebApiRest.Controllers
{
    public class PRODUITsController : ApiController
    {
        private venteproEntities db = new venteproEntities();

        // GET: api/PRODUITs
        public IQueryable<PRODUIT> GetPRODUIT()
        {
            return db.PRODUIT;
        }

        // GET: api/PRODUITs/5
        [ResponseType(typeof(PRODUIT))]
        public IHttpActionResult GetPRODUIT(decimal id)
        {
            PRODUIT pRODUIT = db.PRODUIT.Find(id);
            if (pRODUIT == null)
            {
                return NotFound();
            }

            return Ok(pRODUIT);
        }

        // PUT: api/PRODUITs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPRODUIT(decimal id, PRODUIT pRODUIT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pRODUIT.IDPRODUIT)
            {
                return BadRequest();
            }

            db.Entry(pRODUIT).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PRODUITExists(id))
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

        // POST: api/PRODUITs
        [ResponseType(typeof(PRODUIT))]
        public IHttpActionResult PostPRODUIT(PRODUIT pRODUIT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PRODUIT.Add(pRODUIT);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PRODUITExists(pRODUIT.IDPRODUIT))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pRODUIT.IDPRODUIT }, pRODUIT);
        }

        // DELETE: api/PRODUITs/5
        [ResponseType(typeof(PRODUIT))]
        public IHttpActionResult DeletePRODUIT(decimal id)
        {
            PRODUIT pRODUIT = db.PRODUIT.Find(id);
            if (pRODUIT == null)
            {
                return NotFound();
            }

            db.PRODUIT.Remove(pRODUIT);
            db.SaveChanges();

            return Ok(pRODUIT);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PRODUITExists(decimal id)
        {
            return db.PRODUIT.Count(e => e.IDPRODUIT == id) > 0;
        }
    }
}