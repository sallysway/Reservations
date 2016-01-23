using ReservationsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservationsApp.Controllers
{
    public class ReservationsController : Controller
    {
        ReservationContext context = new ReservationContext();

        public ActionResult Index()
        {
            List<Reservation> reservations = context.Reservations.ToList();
            return View(reservations);
        }

        public ActionResult Details(int id)
        {
            Reservation reservation = context.Reservations.SingleOrDefault(b => b.ReservationId == id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            return View(reservation);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                context.Reservations.Add(reservation);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reservation);
        }

        public ActionResult Edit(int id)
        {
            Reservation reservation = context.Reservations.Single(p => p.ReservationId == id);
            if (ModelState.IsValid)
            {
                if (reservation == null)
                {
                    return HttpNotFound();
                }
            }
            return View(reservation);
        }

        [HttpPost]
        public ActionResult Edit(int id, Reservation reservation)
        {
            Reservation otherReservation = context.Reservations.Single(s => s.ReservationId == id);
            if (ModelState.IsValid)
            {
                otherReservation.Name = reservation.Name;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reservation);
        }

        public ActionResult Delete(int id)
        {
            Reservation reservation = context.Reservations.Single(t => t.ReservationId == id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            return View(reservation);
        }

        [HttpPost]
        public ActionResult Delete(int id, Reservation reservation)
        {
            Reservation someReservation = context.Reservations.Single(q => q.ReservationId == id);
            context.Reservations.Remove(someReservation);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }
    }
}
