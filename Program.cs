using System;
using System.ComponentModel.DataAnnotations;
namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            Rap,
            Country,
            HipHop,
            Alternative,
            Rock
        }
        struct Music
        {
            private string _Title;
            private string _Artist;
            private string _Album;
            private string _Length;
            private Genre? _Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                _Title = title;
                _Artist = artist;
                _Album = album;
                _Length = length;
                _Genre = genre;
            }

            public void setTitle(string title)
            {
                _Title = title;
            }
            public void setArtist(string artist)
            {
                _Artist = artist;
            }
            public void setAlbum(string album)
            {
                _Album = album;
            }
            public void setLength(string length)
            {
                _Length = length;
            }
            public void setGenre(Genre genre)
            {
                _Genre = genre;
            }

            public string Display()
            {
                return "Title: " + _Title + "\nArtist: " + _Artist +
                    "\nAlbum: " + _Album + "\nLength: " + _Length + "\nGenre: " + _Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the album?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the length?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("R - Rap\nC - Country\nH - HipHop\nA - Alternative\nO - Rock");
            Genre tempGenre = Genre.Rap;
            char g = char.ToUpper(Console.ReadLine()[0]);

            switch (g)
            {
                case 'R':
                    tempGenre = Genre.Rap;
                    break;
                case 'C':
                    tempGenre = Genre.Country;
                    break;
                case 'H':
                    tempGenre = Genre.HipHop;
                    break;
                case 'A':
                    tempGenre = Genre.Alternative;
                    break;
                case 'O':
                    tempGenre = Genre.Rock;
                    break;
            }

            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Music moreMusic = music;
            moreMusic.setArtist("The Beatles");
            moreMusic.setTitle("I've Just Seen a Face");
            Console.WriteLine("Here's song #2");
            Console.WriteLine($"{moreMusic.Display()}");
            Console.WriteLine();
            Console.WriteLine("Here's song #1");
            Console.WriteLine($"{music.Display()}");
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();

        }

    }
}
