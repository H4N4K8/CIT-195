using System;
namespace music
{
    class Program
    {
        enum Genre
        {
            Action,
            Horror,
            SciFi,
            RomCom,
            Drama
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\Album: " + Rating + "\nLength" + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite movie?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the album?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("How long is it?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("R - Rock\nC - Country\nP - Pop\nR - Rap\nO - Other");
            Genre tempGenre = Genre.Action;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'C':
                    tempGenre = Genre.Country;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'R':
                    tempGenre = Genre.Rap;
                    break;
                case 'O':
                    tempGenre = Genre.Other;
                    break;
            }
            Music music = new Music(tempTitle, tempAlbum, tempArtist, tempLength, tempGenre);
            Console.WriteLine($"{music.Display()}");
        }
    }
}