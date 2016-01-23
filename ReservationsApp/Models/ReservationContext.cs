using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReservationsApp.Models
{
    public class ReservationContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }

    }
}