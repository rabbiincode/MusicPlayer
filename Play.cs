using System;

namespace MusicPlayer
{
    internal class Play
    {
        Songs song = new();
        int playInput;
        public void Listen(string listen)
        {
            Console.Write("Play song, input index : ");
            playInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0} now playing", listen[playInput]);
        }

        public void RandomPlay()
        {
            Console.WriteLine("-----Playing in Random order-----");
            Thread.Sleep(1500);

            try
            {
                while (true)
                {
                    Random rnd = new Random();
                    int randIndex = rnd.Next(0, Songs.songs.Count());
                    string random = Songs.songs[randIndex];
                    Songs.songs.RemoveAt(randIndex);
                    Console.WriteLine(random);
                
                    //Listen(random);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("");
            }

        }

        public void Alphabetical()
        {
            Songs.songs.Sort();
            Console.WriteLine("-----Playing in Alphabetical order-----");
            Thread.Sleep(1000);
            foreach (string t in Songs.songs)
            {
                Console.WriteLine(t);
            }
            Thread.Sleep(2000);
        }

        public void PlayInOrder()
        {
            song.songList();
        }
    }
}