using System;
namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args) {

            Car.MyMethod();
            /*
     Car myCar = new Car();

        myCar.Make = "oldmobile";
        myCar.Model = "cutlas supreme";
        myCar.Year = 1986;
        myCar.Color = "silver";

     Car myOtherCar;
     myOtherCar = myCar;

     //Console.WriteLine($"{myOtherCar.Make},{myOtherCar.Model},{myOtherCar.Year},{myOtherCar.Color}");

     myOtherCar.Model = "98";
     Console.WriteLine($"{myCar.Make},{myCar.Model},{myCar.Year},{myCar.Color}");

     myOtherCar = null;

     myCar = null;

     Car myThirdCar = new Car("Ford", "Escape", 2005, "White");
     Console.WriteLine($"{myThirdCar.Make},{myThirdCar.Model},{myThirdCar.Year},{myThirdCar.Color}");
    */


            Console.ReadLine();



        }

    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


        public Car()
        {


            this.Make = "Nissan";
        }
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;

        }
        public static void myMethod()
        {
            Console.WriteLine("Called the static MyMethod");
        }
    
    
    public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
        }

    }
}