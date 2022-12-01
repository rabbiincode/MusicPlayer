namespace MusicPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Application start = new ();

            start.App();

            start1: Console.Write("Do you want to continue? : ");
            answer = Console.ReadLine().ToLower();

            if (answer == "Y")
                start.App();
            else if (answer == "N")
            {
                Console.WriteLine("Thanks for using genie music");
            }
            else
            {
                Console.WriteLine("Input a valid option");
                goto start1;
            }

        }
    }
}