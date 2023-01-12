using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //List = data structure that represent list of object that can be accessed by index.
            //      Similar to array, but can dynamically increase/decrease in size
            //        using system.collection.generic;

            /*String[] food = new string[3];

            food[0] = "Pizza";
            food[1] = "hamburger";
            food[2] = "hotdog";
            food[3] = "Fries";*/
            
            List<string> food = new List<string>();


            food.Add("Fries");
            food.Add("Pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("Fries");

            // food.Remove("Fries");
            //food.Insert(0, "sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("Pizza"));
            //Console.WriteLine(food.LastIndexOf("Pizza"));
            //Console.WriteLine(food.Contains("Pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();   

            String[] foodArray= food.ToArray();

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }
            

            

            Console.ReadKey();
        }
       
        }



    }
}



