using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11MoviesList
{
    class Program
    {
        public static bool Continue()
        {
            Console.WriteLine("Do you wish to continue? y/n");
            string userInput = Console.ReadLine().ToLower();
            bool goOn;
            if (userInput == "y")
            {
                goOn = true;
            }
            else if (userInput == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, please try again.");
                goOn = Continue();
            }
            return goOn;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            List<Movie> moviesList = new List<Movie>();
            {
                moviesList.Add(new Movie("Incredibles 2", "Animated"));
                moviesList.Add(new Movie("The Grinch", "Animated"));
                moviesList.Add(new Movie("A Star Is Born", "Drama"));
                moviesList.Add(new Movie("A Quiet Place", "Drama"));
                moviesList.Add(new Movie("Insidious: The Last Key", "Horror"));
                moviesList.Add(new Movie("Dead Of The Dead: Bloodline", "Horror"));
                moviesList.Add(new Movie("Halloween", "Horror"));
                moviesList.Add(new Movie("Avengers: Infinity War", "Scifi"));
                moviesList.Add(new Movie("Upgrade", "Scifi"));
                moviesList.Add(new Movie("Ant-Man And The Wasp", "Scifi"));

                while(true)
                {
                    
                    Console.WriteLine("What category of movies would you like to see? \n Animated \n Drama \n Horror \n Scifi");
                    string userCategory = Console.ReadLine();
                    while (userCategory != "Animated" && userCategory != "Drama" && userCategory != "Horror" && userCategory != "Scifi")
                    {
                        Console.WriteLine("Sorry, invalid input. Please try again.");
                        break;
                    }
                    if (userCategory == "Animated")
                    {
                        foreach (Movie movie in moviesList)
                        {
                            //if (movie.Title.Contains(userCategory))
                            //{

                            //if (userCategory == "Animated")
                            //    Console.WriteLine($"Movie: {movie.Title} Category: {movie.Category.Contains("Animated")}");
                            if (movie.Category.Contains("Animated"))
                            {
                                Console.WriteLine($"Movie: {movie.Title}, Category: {movie.Category}");
                            }
                            //}
                        }
                    }
                    else if (userCategory == "Drama")
                    {
                        foreach (Movie movie in moviesList)
                        {
                            if (movie.Category.Contains("Drama"))
                            {
                                Console.WriteLine($"Movie: {movie.Title}, Category: {movie.Category}");
                            }
                        }
                    }
                    else if (userCategory == "Horror")
                    {
                        foreach (Movie movie in moviesList)
                        {
                            if (movie.Category.Contains("Horror"))
                            {
                                Console.WriteLine($"Movie: {movie.Title}, Category: {movie.Category}");
                            }
                        }
                    }
                    else if (userCategory == "Scifi")
                    {
                        foreach (Movie movie in moviesList)
                        {
                            if (movie.Category.Contains("Scifi"))
                            {
                                Console.WriteLine($"Movie: {movie.Title}, Category: {movie.Category}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, invalid input. Please try again.");
                        break;
                           
                    }

                    


                }
            }
        }
    }
}
