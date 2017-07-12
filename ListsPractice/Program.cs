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

            foreach (int numbers in favNumbers)
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

            /*List<string> animalsList = new List<string>();
            animalsList.Add("tiger");
            animalsList.Add("snake");
            animalsList.Add("Koala bear");
            animalsList.Add("bird");
            animalsList.Add("fish");

            foreach (string animals in animalsList)
            {
                Console.WriteLine(animals);
            }*/

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

            /*List<string> favFoods = new List<string> { "Steak", "Fish",
                "BBQ", "Hummus", "Ice Cream" };
            if(favFoods.Contains("BbQ"))
            {
                Console.WriteLine("This food is in your list");
            */

            //Create a list with the following numbers : 1 23 9 77 922 6 32 63 14 5
            //use the contains method with the following values: 23 77 15
            //remove these elements: 23 77 32 and 
            //use Contains()   again on these values: 23, 77, 15

            /*List<int> numList = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            if (numList.Contains(23))
            {
                Console.WriteLine("23 is in the list");
            }
            else
            {
                Console.WriteLine("23 is not in the list");
            }
            if (numList.Contains(77))
            {
                Console.WriteLine("77 is in the list");
            }
            else
            {
                Console.WriteLine("77 is not in the list");
            }
            if (numList.Contains(15))
            {
                Console.WriteLine("15 is in the list");
            }
            else
            {
                Console.WriteLine("15 is not in the list");
            }            
                numList.Remove(23);            
                numList.Remove(77);            
                numList.Remove(15);            
                numList.Remove(6);
            
            foreach (int number in numList)
            {
                Console.WriteLine(number);
            }*/

            //Create an app "Movie ordering service"
            //You will have a list of movies, ask the user to enter movies
            //If the movie is in the list, let the user know the movie is on the way
            //If the movie is not in the list, add it 
            //inform the user that the movie has been added
            //if the user enters quit, the program should exit
            //the user should be able to add as many movies as they want

            List<string> movieList = new List<string> { "SHARK", "HALLOWEEN","MI2", "MI3",
                "OCEAN'S 11", "OCEAN'S 12", "OCEAN'S 13","JACK REACHER" };
            string userAnswer;
            List<string> userAddedMovies = new List<string>();
            Console.WriteLine("Welcome to Black Box. \n");
            do
            {
                Console.WriteLine("Please enter a movie or type \"quit\" to exit.");
                userAnswer = Console.ReadLine().ToUpper();
                string movieAdd = userAnswer;
                if (userAnswer != "QUIT")
                {
                    userAddedMovies.Add(movieAdd);
                }
                else if(userAnswer == "QUIT")
                {
                    break;
                }
                if (!movieList.Contains(userAnswer))
                {
                    Console.Clear();
                    movieList.Add(movieAdd);
                    Console.WriteLine("\n" + userAnswer + " is not available.\n" +
                    "It has been added and will be available immediately. \n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n" + movieAdd + " is on the way. \n");
                }
            } while (userAnswer != "QUIT");
            Console.Clear();
            Console.WriteLine("Thank you for your order!\n");
            Console.WriteLine("You have ordered: ");
            foreach (string movie in userAddedMovies)
            {
                Console.WriteLine(movie);
            }
            
        }
       
    }
}

