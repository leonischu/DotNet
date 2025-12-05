/*
using System;
namespace ObjectLifeTime
{
   class Program
   {
       static void Main(string[] args) {

           Car.MyMethod();

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
 */

using System;

namespace UnderstandingScope
{
    class Program
    {

        private static string k = "";


        static void Main(string[] args)
        {

           
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j= i.ToString();    
                Console.WriteLine(i);
                k=i.ToString();

                if (i == 9)
                {
                    string l = i.ToString();

                }



            }
            Console.WriteLine("Outside of the for: " + j + k);
            HelperMethod();

            Car myCar= new Car();
            myCar.DoSomething(); 

            Console.ReadLine(); 

        }

    static void HelperMethod()
        {
            Console.WriteLine("Value of k from helper mwthod " + k);
        }

    }

    class Car 
    {
    public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }
        private string helperMethod()
        {
            return "Hello world";
        }
    
    }







}