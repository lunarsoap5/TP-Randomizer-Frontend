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
            Randomizer.Start(args[0], args[1]);
        }
    }
}
