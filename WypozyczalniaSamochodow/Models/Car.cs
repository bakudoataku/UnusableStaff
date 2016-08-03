using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WypozyczalniaSamochodow.Models
{
    public class Car
    {   
        [Key]
        public int ID { get; set; }
        public string license { get; set; }
        public DateTime registrationDate { get; set; }
        public string ImageName { get; set; }
        public string ImageExtension { get; set; }
        public decimal price { get; set; }

        public class CarRenatlDB : ApplicationDbContext
        {
            public DbSet<Car> Cars { get; set; }
        }

        /*public void Add(Car car)
        {
            DBConnection.ExecuteQuery(
                String.Format(@"INSERT INTO [dbo].[Cars]
                    ([license], [registrationDate], [price], [ImageName], [ImageExtension])
                    VALUES('{0}','{1}',{2},null,null)",
                    car.license, car.registrationDate, car.price, car.ImageName, car.ImageExtension));
        }

        public Car Find(int? id)
        {
            DataSet ds = DBConnection.ExecuteQuery(String.Format(@"SELECT * FROM Cars WHERE id = {0}", id));
            return ds.Tables[0].AsEnumerable().Select(s => new Car
            {
                ID = s.Field<int>("ID"),
                license = s.Field<string>("license"),
                registrationDate = s.Field<DateTime>("registrationDate"),
                ImageName = s.Field<string>("ImageName"),
                ImageExtension = s.Field<string>("ImageExtension"),
                price = s.Field<decimal>("price")
            }).ToList().First();
        }

        public List<Car> ToList()
        {
            DataSet ds = DBConnection.ExecuteQuery(@"SELECT * FROM Cars");
            var data = ds.Tables[0].AsEnumerable().Select(s => new Car
            {
                ID = s.Field<int>("ID"),
                license = s.Field<string>("license"),
                registrationDate = s.Field<DateTime>("registrationDate"),
                ImageName = s.Field<string>("ImageName"),
                ImageExtension = s.Field<string>("ImageExtension"),
                price = s.Field<decimal>("price")
            });
            return data.ToList();
        }
        
        public void Remove(Car car)
        {
            DBConnection.ExecuteQuery(String.Format(@"DELETE FROM Cars WHERE id = {0}", car.ID));
        }*/
    }
}