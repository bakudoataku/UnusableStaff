using System;
using System.Data.Entity;

namespace WypozyczalniaSamochodow.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string license { get; set; }
        public DateTime registrationDate { get; set; }
        public decimal price { get; set; }
    }

    public class CarRentalDB : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}