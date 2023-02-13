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
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
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

            Music music = new Music(tempTitle, tempAlbum, tempArtist, tempLength, tempGenre);
            // Copying the structure variable
            Music newMusic = music;
            //changing values in the new structure variable
            Console.WriteLine("What is the next song on the album?");
            newMusic.setTitle = Console.ReadLine();
            Console.WriteLine("How long is the song?");
            newMusic.setLength = Console.ReadLine();
            //Printing the new movie
            Console.WriteLine("Here's song #1");
            Console.WriteLine($"{music.Display()}");
            Console.WriteLine();
            //Printing the original
            Console.WriteLine("Here's song #2");
            Console.WriteLine($"{newMusic.Display()}");
        }
    }
}