using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //list<data type> name = new List<data type>();
            List<int> favNumbers = new List<int>();
            favNumbers.Add(7);
            favNumbers.Add(25);
            favNumbers.Add(30);

            foreach(int numbers in favNumbers)
            {
                //Console.WriteLine(numbers);
            
            }
            //use count instead of length to find the length of a list
            //Console.WriteLine(favNumbers.Count);
            List<string> books = new List<string> {"Cat in the hat", "Toad and Frog",
                "Green Eggs and ham" ,"Titanic" };
            books.Insert(0, "Hey Honey");
            //Console.WriteLine(books[0]);
            //create a List and add 5 animals using the .Add()
            //Print each animal in the list

            List<string> animalsList = new List<string>();
            animalsList.Add("tiger");
            animalsList.Add("snake");
            animalsList.Add("Koala bear");
            animalsList.Add("bird");
            animalsList.Add("fish");

            foreach(string animals in animalsList)
            {
                Console.WriteLine(animals);
            }

            //Create the following list:
            //a bool list {true, false, false, true, false}
            //Loop through each value
            //if value is true print "Better bring an umbrella"
            //if value is false print "No rain today enjoy the sun"

            /*List<bool> trueFalse = new List<bool> { true, false, false, true, false };

            for(int i = 0; i < trueFalse.Count; i++ )
            {
                if (trueFalse[i] == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }
                else
                {
                    Console.WriteLine("No rain today enjoy the sun");
                }
            }*/
            List<string> favFoods = new List<string> { "Steak", "Fish",
                "BBQ", "Hummus", "Ice Cream" };
            if(favFoods.Contains("BbQ"))
            {
                Console.WriteLine("This food is in your list");
            }


        }
    }
}
