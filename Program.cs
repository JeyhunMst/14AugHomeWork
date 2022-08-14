using _14AugHomeWork.Models;
using System;

namespace _14AugHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name of Singer:");
            string nameSinger = Console.ReadLine();
            Console.Write("Enter surname of Singer:");
            string surNameSing = Console.ReadLine();
            Console.Write("Enter the age of Singer:");
            int age = Convert.ToInt32(Console.ReadLine());
            Singer SingerNo1 = new Singer
            {
                Name = nameSinger,
                SurName= surNameSing,
                Age = age
            };
            Console.Write("Enter the song name:");
            string nameSong = Console.ReadLine();
            Console.Write("Enter the song genre:");
            string genreSong = Console.ReadLine();


            Song SongNo1 = new Song()
            {
                Name = nameSong,
                Genre = genreSong,
                Singer = SingerNo1
                
            };
            int purpose = 1;
            while (purpose==1)
            {
                Console.WriteLine("Enter your rating for song:");
                decimal rating = Convert.ToDecimal(Console.ReadLine());
                SongNo1.AddRating(rating);
                Console.WriteLine($"Do you want to add new rating? \n " +
                    "  If you want exit press 0 \n  " +
                    "  If you want contunie press 1 \n  " +
                    "Please do not touch other buttons  ");
                purpose = Convert.ToInt32(Console.ReadLine());
                SongNo1.FindAvarageRating();
            }





            #region Without Readline
            //SongNo1.AddRating(4);
            //SongNo1.AddRating(3);
            //SongNo1.AddRating(7);
            //SongNo1.FindAvarageRating();
            //Console.WriteLine(SongNo1.GetAverageRating());
            #endregion
            SongNo1.ShowInfo();

        }
    }
}
