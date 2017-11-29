using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace jelbrek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            jelbrekInitialise();
            Console.ReadKey();
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789ÅÄÖ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        static void jelbrekInitialise()
        {

            string Black = "Black";
            string Cyan = "Cyan";
            string Green = "Green";
            string Magenta = "Magenta";
            string DarkMagenta = "DarkMagenta";
            string Red = "red";
            string DarkRed = "DarkRed";
            string Blue = "DarkBlue";
            string White = "White";
            string Yellow = "Yellow";

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            string[] colorArray = new string[10];
            colorArray[0] = Black;
            colorArray[1] = Cyan;
            colorArray[2] = Green;
            colorArray[3] = Magenta;
            colorArray[4] = DarkMagenta;
            colorArray[5] = Red;
            colorArray[6] = DarkRed;
            colorArray[7] = Blue;
            colorArray[8] = Yellow;
            colorArray[9] = White;
            

            int sleepTime = 100;
            int i = 0;
            Console.WriteLine("Welcome to jelbrek JAILBREAK. Please plug in your device.");
            Console.WriteLine("Which device do you have?");
            string device = Console.ReadLine();
            Console.WriteLine("Initializing jailbreak process on device: " + device);
            Console.WriteLine("Exploiting using 69kpwn:");
            Console.WriteLine("--");
            Thread.Sleep(sleepTime);
            Console.WriteLine("---");
            Thread.Sleep(sleepTime);
            Console.WriteLine("----");
            Thread.Sleep(sleepTime);
            Console.WriteLine("-----");
            Thread.Sleep(sleepTime);
            Console.WriteLine("------");
            Thread.Sleep(sleepTime);
            Console.WriteLine("-------");
            Thread.Sleep(sleepTime);
            Console.WriteLine("--------");
            Thread.Sleep(sleepTime);
            Console.WriteLine("---------");
            Thread.Sleep(sleepTime);
            Console.WriteLine("---------- Done sending the 69kpwn exlpoit, Please wait while Cyxty9 is installing.");
            Thread.Sleep(3000);
            while (i < 20000)
            {
                int randColor = random.Next(0, colorArray.Length);


                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Convert.ToString(randColor));
                Console.WriteLine(RandomString(100));
                i++;
            }
            Console.WriteLine("Done installing Cyxty9");
            Console.WriteLine("Jailbreak process is done, please feel free to disconnect your device.");
            Thread.Sleep(10000);
        }
    }
}
