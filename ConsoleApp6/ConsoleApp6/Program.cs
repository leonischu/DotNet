/*using System;
namespace TypeConversion
{

    class program 
    {
         static void Main(String[] args)
        {
            try
            {


                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch(Exception) {
                Console.WriteLine("The number could not be converted");
            }
        }
    }

}

using System;
namespace Classes
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("hi {0}, I am {1}", to, Name);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class program
    {
        static void Main(string[] args)
        {

            var person = Person.Parse("Test");
            person.Introduce("Mosh");

        }
    }
}


using System;
namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give away");
            Console.WriteLine("choose door 1,2,3");
            string userValue = Console.ReadLine();

            /*
            if (userValue == "1")
            {
                Console.WriteLine("you won");
            }
            else if (userValue == "2")
            {
                Console.WriteLine("youve won car");

            }
            else if (userValue == "3")
            {
                Console.WriteLine("you lost");
            }
            else
            {
                Console.WriteLine("Error");
            }

            string message = (userValue == "1") ? "boat" : "nothing";
            Console.WriteLine("The number you have entered is {0}.So you have won {1}",userValue,message);
            Console.ReadLine();
        }
    }
}

using System;
namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ///Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found seven");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}

using System;
namespace ArrayLearn
{
    class Person
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            Console.WriteLine(numbers.Length);
            *
            string[] names = new string[] { "eddie", "aaa", "bbb", "ccc", };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);    
            // string[] names = new string[] { "eddie", "aaa", "bbb", "ccc", };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();
            string zig = "hello what is your" + "name";
            char[] charArray =zig.ToCharArray();
            Array.Reverse(charArray);
            foreach(char c in charArray )
            {
                Console.WriteLine(c);
            }
         }


    }
}

using System;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString();
            Console.WriteLine();
        }

        private static void ReverseString()
        {
            Console.WriteLine("Enter your message:");
            string message = Console.ReadLine();

            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            foreach (char c in messageArray)
            {
                Console.WriteLine(c);
            }
        }
    }
}

using System;
namespace WhileIteration
{
    class program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true) {
              displayMenu =  MainMenu();
            }
           
            
        }
        private static bool MainMenu() {
            Console.Clear();
            Console.WriteLine("chose option 1");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        private static void PrintNumbers() {
            Console.Clear();
            Console.WriteLine("Print Numbers");
            Console.WriteLine("Type a number");

            int result = int.Parse(Console.ReadLine());
            int Counter = 1;
            while (Counter < result + 1) {
                
                    Console.Write(Counter);
                    Console.Write("-");
                    Counter++;
                }
                Console.ReadLine();
            }

        
        private static void GuessingGame() {
            Console.Clear();
            Console.WriteLine("Guessing game");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;
            do
            {
                Console.WriteLine("Guess a number betweeen 1 and 10:");
                string result = Console.ReadLine();
                guesses++;

                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("incorrect");

            }
            while (incorrect);
            Console.WriteLine("Correct! It took you {0} guesses",guesses);
            Console.ReadLine();


        }
    }
}

using System;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = String.Format("{0:C}",123.45);
            //string myString = String.Format("{0:N}",1234567890);
            //string myString = String.Format("{0:P}", 123.45);
            //string myString = String.Format("{0:(###) ###-####}", 1234567890);
            //string myString = " ";
            //myString = myString.Substring(5);


            //for(int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i.ToString();
            //}
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++) {

                myString.Append("--");
                myString.Append(i);

            }


            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
*/



