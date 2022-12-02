namespace MusicPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            bool starting = true;
            Application start = new ();

            begin: start.App();

            Console.BackgroundColor = ConsoleColor.Red;
            begin1: Console.Write("Do you want to continue? : ");
            answer = Console.ReadLine().ToLower();

            while (starting)
            {
                if (answer == "y")
                {
                    Console.Clear();
                    goto begin;

                }
                else if (answer == "n")
                {
                    Console.WriteLine("Thanks for using genie music");
                    starting = false;
                }
                else
                {
                    Console.WriteLine("Input a valid option");
                    goto begin1;
                }
            }

        }
    }
}