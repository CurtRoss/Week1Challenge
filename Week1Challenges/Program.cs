using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            //Challenge 1 
            string firstName = "Curt";
            string lastName = "Reigelsperger";
            int age = 33;

            //Challenge 2

            
            string num1 = "Dark Tower";
            string num2 = "Wheel of Time";
            string num3 = "Anything by Brandon Sanderson";
            string num4 = "Anything by John Grisham";

            

            string[] favoriteBooks = { num1, num2, num3, num4 };
            
            foreach(string books in favoriteBooks)
            {
                Console.WriteLine(books);
            }
            Console.ReadLine();

            //Challenge 3

            //--Other Object Examples

            DateTime now = DateTime.Now;
            DateTime random1 = new DateTime(1990, 8, 23);
            DateTime random2 = new DateTime(1986, 12, 25);
            DateTime random3 = new DateTime(2020, 11, 29);
            DateTime random4 = DateTime.UtcNow;

            List<DateTime> listDateTime = new List<DateTime>();
            listDateTime.Add(random1);
            listDateTime.Add(random2);
            listDateTime.Add(random3);
            listDateTime.Add(now);
            listDateTime.Add(random4);

            foreach (var item in listDateTime)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


            //Challenge 4

            int add = age + 7;
            Console.WriteLine(add);
            int subtract = age - 7;
            Console.WriteLine(subtract);
            int multiply = age * 7;
            Console.WriteLine(multiply);
            float divide = age / 7f;
            Console.WriteLine(divide);
            int modulus = age % 7;
            Console.WriteLine(modulus);
            Console.ReadLine();

            //Challenge 5 

            Console.WriteLine("How much sleep did you get last night?");

            string sleep = Console.ReadLine();

            int sleep2 = Convert.ToInt32(sleep);

                if( sleep2 >= 10 )
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
                else if( sleep2 >= 8)
            {
                Console.WriteLine("You should be pretty rested");
            }
                else if(sleep2 >=4)
            {
                Console.WriteLine("Bummer");
            }
                else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
            Console.ReadLine();

            //Challenge 6

            Console.WriteLine("How are you? Possible answers are: Great, Good, Okay, Bad, or :(" );
            
            string howAreYou = Console.ReadLine();

            switch (howAreYou)
            {
                case "Great":
                    Console.WriteLine("I am glad you are having a GREAT day!");
                    break;
                case "Good":
                    Console.WriteLine("Sounds like a good day.");
                    break;
                case "Okay":
                    Console.WriteLine("Well, I guess that is better than bad.");
                    break;
                case "Bad":
                    Console.WriteLine("Ugh.");
                    break;
                case ":(":
                    Console.WriteLine("Can't even type words, huh?");
                    break;
                default:
                    Console.WriteLine("Does not compute!");
                    break;
            }
            Console.ReadLine();
            
























            }
    }
}
