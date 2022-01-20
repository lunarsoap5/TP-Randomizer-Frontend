using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace TPRandomizer

{
    static class Program
    {
        static Randomizer currentRandomizer = new Randomizer();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            currentRandomizer.start(args[0], args[1]);
        }
    }
}
