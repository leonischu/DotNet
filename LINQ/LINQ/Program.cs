using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
         {
             new Car() {VIN = "A1", Make = "BMW", MOdel = "550i", StickerPrice = 55000, Year = 1980 },
             new Car() {VIN = "B2", Make = "Toyota", MOdel = "4Runner", StickerPrice = 35000, Year = 1990 },
             new Car() {VIN = "C3", Make = "BMW", MOdel = "745li", StickerPrice = 75000, Year = 2000  },
             new Car() {VIN = "E5", Make = "FORD", MOdel = "Escpe", StickerPrice =  25000, Year = 2010 },
             new Car() {VIN = "D4", Make = "BMW", MOdel = "55i", StickerPrice = 57000, Year = 2020  }

         };
            // LINQ query 
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2020
                       select car;
            
           
            */
            //LINQ method
            //  var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2020);

            //var orderedCars = from car in myCars
            //                  orderby car.Year descending
            //    select car;

            var orderedCars = myCars.OrderByDescending(car => car.Year);


            foreach (var bm in myCars)
            {
                Console.WriteLine($"{bm.MOdel},{bm.Make},{bm.VIN},{bm.Year}");
            }


            Console.ReadLine();

        }

    }
    public class Car {
         public string VIN {  get; set; }  
        public string Make { get; set; }    
        public string MOdel { get; set; }   
        public int StickerPrice { get; set; }
        public int Year { get; set; }


    }

}