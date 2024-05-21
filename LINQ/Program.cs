using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LINQ

{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "Pokemon", "Overwatch", "Apex" };

            foreach(string game in videoGames.OrderBy(videoGames => videoGames.Length))
            {
                Console.WriteLine(game);
            }

          
               
            
            

        }
    }
}
