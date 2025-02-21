using System;
// Added a parent GoalManager where all the different goal types are managed and all the inheritance logic and functionality are implemented
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the EternalQuest Project.\n-------------------------------------------------------------------------------\n");
        GoalManager manager = new GoalManager();
        bool run = true;
        bool quit;

        do
        {
            manager.Start();

            Console.Write("Are you sure you want to quit? (yes/no)\n>  ");
            string rsp = Console.ReadLine();

            do
            {
                quit = true;

                if (rsp.ToLower() == "yes")
                {
                    run = false;
                    Console.WriteLine("\nThanks for indulging the collective");
                }
                else if (rsp.ToLower() == "no")
                {
                    run = true;
                }
                else
                {
                    Console.Write("Invalid response, choose between (yes) and (no)\n>");
                    rsp = Console.ReadLine();
                    quit = false;
                }
            } while (!quit);

        } while (run);
    }
}