using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReservationsApp.Models
{
    [Table("Reservations")]
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public string Name { get; set; }

        public int UserId { get; set; }
    }
}