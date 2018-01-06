using System;
using System.Threading;

namespace WankAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Wank myWank = new Wank();
            Console.WriteLine("Please Enter a Command");

            string line = Console.ReadLine();
            while (line != "exit")
            {
                switch (line)
                {
                    case "wank fast":
                        myWank.Do_Fap(Wank.WankSpeed.Fast, 50);
                        line = Console.ReadLine();
                        break;
                    case "wank slow":
                        myWank.Do_Fap(Wank.WankSpeed.Slow, 50);
                        line = Console.ReadLine();
                        break;
                    case "help":
                        Console.WriteLine("wank fast - wanks fast");
                        Console.WriteLine("wank slow - wanks slow");
                        Console.WriteLine("help      - display help");
                        Console.WriteLine("exit      - exits app");
                        break;
                    default:
                        goto case "help";
                }
            }
        }
    }

    class Wank
    {
        int Fapcounter;
        int Blamcounter;
        
        public void Fap()
        {
            Fapcounter++;
            switch (Fapcounter % 6)
            {
                case 0:
                    Console.Write("8====MM=D");
                    Console.SetCursorPosition(Console.CursorLeft - 9, Console.CursorTop);
                    break;
                case 1:
                    Console.Write("8===MM==D");
                    Console.SetCursorPosition(Console.CursorLeft - 9, Console.CursorTop);
                    break;
                case 2:
                    Console.Write("8==MM===D");
                    Console.SetCursorPosition(Console.CursorLeft - 9, Console.CursorTop);
                    break;
                case 3:
                    Console.Write("8=MM====D");
                    Console.SetCursorPosition(Console.CursorLeft - 9, Console.CursorTop);
                    break;
                case 4:
                    Console.Write("8==MM===D");
                    Console.SetCursorPosition(Console.CursorLeft - 9, Console.CursorTop);
                    break;
                case 5:
                    Console.Write("8===MM==D");
                    Console.SetCursorPosition(Console.CursorLeft - 9, Console.CursorTop);
                    break;
            }
        }
        public void Do_Fap(WankSpeed speed, int strokes)
        {
            bool isWanking = true;
            int delayTime = 100;
            switch (speed)
            {
                case WankSpeed.Fast:
                    delayTime = 100;
                    break;

                case WankSpeed.Slow:
                    delayTime = 200;
                    break;
            }
            if (isWanking)
            {
                for (int i = 0; i < strokes; i++)
                {
                    Thread.Sleep(delayTime);
                    Fap();
                }
                Do_Blamm();
                

                isWanking = false;
            }
            Console.Clear();
            Console.WriteLine("Please Enter a Command");

        }
        public void Blamm()
        {
            Blamcounter++;
            switch (Blamcounter % 4)
            {
                case 0:
                    Console.Write("8====MM=D-");
                    Console.SetCursorPosition(Console.CursorLeft - 10, Console.CursorTop);
                    break;
                case 1:
                    Console.Write("8====MM=D --");
                    Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);
                    break;
                case 2:
                    Console.Write("8====MM=D --_");
                    Console.SetCursorPosition(Console.CursorLeft - 13, Console.CursorTop);
                    break;
                case 3:
                    Console.Write("8====MM=D ___");
                    Console.SetCursorPosition(Console.CursorLeft - 13, Console.CursorTop);
                    break;
            }


        }
        public void Do_Blamm()
        {
            bool IsBlamming = true;
            if (IsBlamming)
            {
                for (int i = 0; i < 4; i++)
                {
                    Blamm();
                    System.Threading.Thread.Sleep(200);

                }
                IsBlamming = false;
            }
            Console.Clear();
            Console.WriteLine("Please Enter a Command");
            
        }
        public enum WankSpeed { Fast, Slow }
    }
}
