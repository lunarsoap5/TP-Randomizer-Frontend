using System;

namespace TPRandomizer
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string command = args[0];

            switch (command)
            {
                case "generate_legacy":
                    Randomizer.Start(args[1], args[2]);
                    break;
            }
        }
    }
}
