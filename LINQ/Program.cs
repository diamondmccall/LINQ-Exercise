using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace LINQ
{
    public class Program
    {
      

        static void Main(string[] args)
        {
            List<string> videoGames = new List<string> { "Mario bros", "Street Fighter", "Donkey Kong", "2K", "Guitar Hero" };

            var games = videoGames.OrderBy(str => str.Length);

            foreach (var videogames in games)
            {
                Console.WriteLine(videogames);
            }

            Console.WriteLine($"***************");


            var letterA = videoGames.Where(letter => letter.Contains("a"));
            foreach (var letter in letterA)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine($"***************");

            var name = videoGames.OrderByDescending(str => str.Length) ;
            foreach (var names in name)
            {
                Console.WriteLine(names);
            }

            Console.WriteLine($"****************");

            var twoK = videoGames.Select(choice => choice.Contains("2"));
            foreach (var twoks in twoK)
            {
                Console.WriteLine(twoks);
            }
        }
    }
}
