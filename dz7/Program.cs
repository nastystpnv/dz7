using System;
using System.Collections.Generic;

namespace tumakov8
{

    class Program
    {  
            public class StringManipulator
            {
                public static string ReverseLetters(string input)
                {
                    char[] charArray = input.ToCharArray();
                    Array.Reverse(charArray);
                     return new string(charArray);
                }
                 public static void Main(string[] args)
                 {
                Console.WriteLine("номер 8.2");
                Console.WriteLine("введите строку: ");
                    string inputString = Console.ReadLine();
                    string reversedString = ReverseLetters(inputString);
                    Console.WriteLine($"строка в обратном порядке: {reversedString}");
                 }
             }

        static void Main(string[] args)
        {
            Console.WriteLine("номер 8.2 дз");
            Song song1 = new Song();
            song1.SetName("sweater weather");
            song1.SetAuthor("the neighbourhood");

            Song song2 = new Song();
            song2.SetName("friends");
            song2.SetAuthor("chase atlantic");

            Song song3 = new Song();
            song3.SetName("i love you so");
            song3.SetAuthor("kenye west");

            Song song4 = new Song();
            song4.SetName("cpr");
            song4.SetAuthor("cupcakke");

            song2.SetPreviousSong(song1);
            song3.SetPreviousSong(song2);
            song4.SetPreviousSong(song3);

            List<Song> songsList = new List<Song> { song1, song2, song3, song4 };
            foreach (Song song in songsList)
            {
                Console.WriteLine(song.Title());
            }
            Console.WriteLine("cравнение первой и второй песни: " + song1.Equals(song2));


        }
    }

}