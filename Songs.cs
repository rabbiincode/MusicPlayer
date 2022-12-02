using System;

namespace MusicPlayer
{
    public class Songs
    {
        string answer;
        int remove;
        string edit;
        int editIndex;
        bool adding = true;
        public static List <string> songs = new List <string> 
        { 
            "We love task ...alex ft onah",
            "Disappoint ...amaka ft stephen", 
            "Task no go kill us ...success ft bello", 
            "Task them till em' die ...alex", 
            "Snr devs ...Big ben ft fredric ft bello"
        };

        public void songList()
        {
            Console.WriteLine("Genie PlayLists");
            foreach (string s in songs)
            {
                int index = songs.IndexOf(s);
                Console.WriteLine("{0} ------- {1}", s, index);
            }
        }

        public void Put()
        {
            Console.Write("Add song : ");
            songs.Add(Console.ReadLine());
        }

        public void Question()
        {
            while (adding)
            {
                songList();
                Console.Write("Do you want to add more songs? Y / N : ");
                answer = Console.ReadLine();

                if (answer == "Y")
                {
                    Put();
                    Console.Clear();
                }
                else if (answer == "N") 
                {
                    Console.WriteLine("No");
                    break;
                }


                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input --Enter a valid option");
                }
                
            }

        }

        public void Add()
        {
            Put();
            Console.Clear();
            Question();
        }

        public void Remove()
        {
            removeSong: Console.WriteLine(".....Remove song.....");
            Console.Write("Enter song index : ");
            try
            {
                remove = Convert.ToInt32(Console.ReadLine());
                songs.RemoveAt(remove);
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter a valid id");
                goto removeSong;
            }
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} deleted", songs[remove]);

            Console.BackgroundColor = ConsoleColor.Green;
            songList();
        }

        public void Edit()
        {
            editSong:  Console.Write("Enter song index you wish to edit : ");

            try
            {
                editIndex = Convert.ToInt32(Console.ReadLine());
                songs.RemoveAt(remove);
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter a valid id");
                goto editSong;
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("'Edit {0}' : ", songs[editIndex]);
            Console.Write("Edit : ");
            edit = Console.ReadLine();

            songs.RemoveAt(remove);
            songs.Insert(editIndex, edit);

            songList();
        }

    }
}