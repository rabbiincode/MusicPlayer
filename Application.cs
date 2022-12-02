using System;

namespace MusicPlayer
{
    internal class Application
    {
        public void App()
        {
            int input;
            Songs song = new();
            Play music = new();

            Console.WriteLine("Genie Music");

            Console.WriteLine(".........Menu.........");
            Console.WriteLine(" >Play -- press 1\n >Add song -- press 2\n >Remove song -- press 3\n" +
                " >Edit song -- press 4\n >Create PlayList -- press 5\n >Play randomly -- press 6\n" +
                " >Play in order -- press 7\n >Play alphabetically -- press 8");

            start: Console.Write("Enter Selection : ");

            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input > 8)
                {
                    throw new CustomException("input invalid");
                    Console.Clear();
                    goto start;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter a valid input");
                goto start;
            }

            switch (input)
            {
                case 1:
                    Console.WriteLine("Playing...");
                    foreach (string s in Songs.songs)
                    {
                        Console.WriteLine(s);
                    }
                    Thread.Sleep(2000);
                    break;
                case 2:
                    song.Add();
                    break;
                case 3:
                    song.Remove();
                    break;
                case 4:
                    song.Edit();
                    break;
                case 5:
                    Console.WriteLine("Playlist coming soon");
                    break;
                case 6:
                    music.RandomPlay();
                    break;
                case 7:
                    music.PlayInOrder();
                    break;
                case 8:
                    music.Alphabetical();
                    break;
            }
        }
    }
}
