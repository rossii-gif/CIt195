using System;

namespace FunWithMusic
{
    class Program
    {
        enum MusicGenre
        {
            Pop,
            Rock,
            Jazz,
            Classical,
            HipHop
        }

        struct Music
        {
            private string _Title;
            private string _Artist;
            private string _Album;
            private string _Length;
            private MusicGenre _Genre;

            public Music(string title, string artist, string album, string length, MusicGenre genre)
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

            public void setLength(string length)
            {
                _Length = length;
            }

            public string Display()
            {
                return $"Title: {_Title}\nArtist: {_Artist}\nAlbum: {_Album}\nLength: {_Length}\nGenre: {_Genre}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the title of your favorite song:");
            string tempTitle = Console.ReadLine();

            Console.WriteLine("Enter the artist:");
            string tempArtist = Console.ReadLine();

            Console.WriteLine("Enter the album:");
            string tempAlbum = Console.ReadLine();

            Console.WriteLine("Enter the length (e.g., 3:45):");
            string tempLength = Console.ReadLine();

            Console.WriteLine("Select the genre:");
            Console.WriteLine("P - Pop\nR - Rock\nJ - Jazz\nC - Classical\nH - HipHop");

            MusicGenre tempGenre = MusicGenre.Pop; // default
            char g = char.Parse(Console.ReadLine().ToUpper());
            switch (g)
            {
                case 'P':
                    tempGenre = MusicGenre.Pop;
                    break;
                case 'R':
                    tempGenre = MusicGenre.Rock;
                    break;
                case 'J':
                    tempGenre = MusicGenre.Jazz;
                    break;
                case 'C':
                    tempGenre = MusicGenre.Classical;
                    break;
                case 'H':
                    tempGenre = MusicGenre.HipHop;
                    break;
                default:
                    Console.WriteLine("Invalid genre selected. Defaulting to Pop.");
                    break;
            }
            Music song1 = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);

            Music moreMusic = song1;

            Console.WriteLine("\nEnter the title for the second song:");
            string secondTitle = Console.ReadLine();
            Console.WriteLine("Enter the length for the second song (e.g., 4:05):");
            string secondLength = Console.ReadLine();

            moreMusic.setTitle(secondTitle);
            moreMusic.setLength(secondLength);

            Console.WriteLine("\nSong #1:");
            Console.WriteLine(song1.Display());
            Console.WriteLine("\nSong #2:");
            Console.WriteLine(moreMusic.Display());
        }
    }
}
