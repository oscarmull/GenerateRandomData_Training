﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PropertySearcher.Models;

namespace PropertySearcher.Controllers
{
    public class ResearchersController : ApiController
    {
        private PropertySearcherContext db = new PropertySearcherContext();

        // GET: api/Researchers
        public IQueryable<Researcher> GetResearchers()
        {
            return db.Researchers;
        }

        // GET: api/Researchers/5
        [ResponseType(typeof(Researcher))]
        public IHttpActionResult GetResearcher(int id)
        {
            Researcher researcher = db.Researchers.Find(id);
            if (researcher == null)
            {
                return NotFound();
            }

            return Ok(researcher);
        }

        // PUT: api/Researchers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutResearcher(int id, Researcher researcher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != researcher.Id)
            {
                return BadRequest();
            }

            db.Entry(researcher).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResearcherExists(id))
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

        // POST: api/Researchers
        [ResponseType(typeof(Researcher))]
        public IHttpActionResult PostResearcher(Researcher researcher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Researchers.Add(researcher);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = researcher.Id }, researcher);
        }

        // DELETE: api/Researchers/5
        [ResponseType(typeof(Researcher))]
        public IHttpActionResult DeleteResearcher(int id)
        {
            Researcher researcher = db.Researchers.Find(id);
            if (researcher == null)
            {
                return NotFound();
            }

            db.Researchers.Remove(researcher);
            db.SaveChanges();

            return Ok(researcher);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ResearcherExists(int id)
        {
            return db.Researchers.Count(e => e.Id == id) > 0;
        }
    }
}