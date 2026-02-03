using System;

namespace MusicArray
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

            public void setGenre(MusicGenre genre)
            {
                _Genre = genre;
            }

            public string Display()
            {
                return $"Title: {_Title}\nArtist: {_Artist}\nAlbum: {_Album}\nLength: {_Length}\nGenre: {_Genre}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());

            Music[] collection = new Music[size];

            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"\nEntering song #{i + 1}");

                    Console.Write("Enter the song title: ");
                    collection[i].setTitle(Console.ReadLine());

                    Console.Write("Enter the artist: ");
                    collection[i].setArtist(Console.ReadLine());

                    Console.Write("Enter the album: ");
                    collection[i].setAlbum(Console.ReadLine());

                    Console.Write("Enter the length (e.g., 3:45): ");
                    collection[i].setLength(Console.ReadLine());

                    Console.WriteLine("Select the genre:");
                    Console.WriteLine("P - Pop\nR - Rock\nJ - Jazz\nC - Classical\nH - HipHop");
                    char g = char.Parse(Console.ReadLine().ToUpper());
                    MusicGenre genre = MusicGenre.Pop; 
                    switch (g)
                    {
                        case 'P':
                            genre = MusicGenre.Pop;
                            break;
                        case 'R':
                            genre = MusicGenre.Rock;
                            break;
                        case 'J':
                            genre = MusicGenre.Jazz;
                            break;
                        case 'C':
                            genre = MusicGenre.Classical;
                            break;
                        case 'H':
                            genre = MusicGenre.HipHop;
                            break;
                        default:
                            Console.WriteLine("Invalid genre selected. Defaulting to Pop.");
                            break;
                    }
                    collection[i].setGenre(genre);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Argument error: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("\nYour music collection:");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"\nSong #{i + 1}:");
                    Console.WriteLine(collection[i].Display());
                }
            }
        }
    }
}
