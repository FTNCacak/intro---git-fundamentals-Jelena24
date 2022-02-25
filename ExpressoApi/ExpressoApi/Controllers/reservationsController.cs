using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ExpressoApi.Data;
using ExpressoApi.Models;

namespace ExpressoApi.Controllers
{
    public class reservationsController : ApiController
    {
        private ExpressoDbContext expressoDbContext = new ExpressoDbContext();


        public IHttpActionResult getReservations()
        {
            var reservations = expressoDbContext.Reservations;
            return Ok(reservations);
        }

        public IHttpActionResult Post(Reservation reservation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            expressoDbContext.Reservations.Add(reservation);
            expressoDbContext.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }
    }
}
