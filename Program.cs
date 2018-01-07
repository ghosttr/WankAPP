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
                        myWank.Do_Fap(Wank.FapSpeed.Fast, 50);
                        line = Console.ReadLine();
                        break;
                    case "wank slow":
                        myWank.Do_Fap(Wank.FapSpeed.Slow, 50);
                        line = Console.ReadLine();
                        break;
                    case "flick fast":
                        myWank.Do_BeanFlick(Wank.FapSpeed.Fast, 50);
                        line = Console.ReadLine();
                        break;
                    case "flick slow":
                        myWank.Do_BeanFlick(Wank.FapSpeed.Slow, 50);
                        line = Console.ReadLine();
                        break;
                    case "help":
                        Console.Clear();
                        Console.WriteLine("Help: ");
                        Console.WriteLine("wank fast - wanks fast");
                        Console.WriteLine("wank slow - wanks slowly");
                        Console.WriteLine("flick fast - flicks fast");
                        Console.WriteLine("flick slow - flicks slowly");
                        Console.WriteLine("help      - display help");
                        Console.WriteLine("exit      - exits app");
                        Thread.Sleep(5000);
                        Console.Clear();
                        Console.WriteLine("Please Enter a Command");
                        line = Console.ReadLine();
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
        public void BeanFlick()
        {
            Fapcounter++;
            switch (Fapcounter % 3)
            {
                case 0:
                    Console.Write(@"/  /\  {(UU.)}  /\  \");
                    Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop);
                    break;
                case 4:
                    Console.Write(@"/  /\  {(U.U)}  /\  \");
                    Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop);
                    break;
                case 2:
                    Console.Write(@"/  /\  {(.UU)}  /\  \");
                    Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop);
                    break;
                case 3:
                    Console.Write(@"/  /\  {(U.U)}  /\  \");
                    Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop);
                    break;
            }
        }
        public void Do_Fap(FapSpeed speed, int strokes)
        {
            bool isWanking = true;
            int delayTime = 100;
            switch (speed)
            {
                case FapSpeed.Fast:
                    delayTime = 100;
                    break;

                case FapSpeed.Slow:
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

        }
        public void Do_BeanFlick(FapSpeed speed, int flicks)
        {
            bool isBeanFlicking = true;
            int delayTime = 100;
            switch (speed)
            {
                case FapSpeed.Fast:
                    delayTime = 100;
                    break;

                case FapSpeed.Slow:
                    delayTime = 200;
                    break;
            }
            if (isBeanFlicking)
            {
                for (int i = 0; i < flicks; i++)
                {
                    Thread.Sleep(delayTime);
                    BeanFlick();
                }
                Do_Moist();

                isBeanFlicking = false;
            }

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
        public void Moist()
        {
            Blamcounter++;
            switch (Blamcounter % 4)
            {
                case 0:
                    Console.Write(@"/  /\  {(U.U)}  /\  \");
                    Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop);
                    break;
                case 1:
                    Console.Write(@"/  /\  {(-_-)}  /\  \");
                    Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop);
                    break;
                case 2:
                    Console.Write(@"/  /\  {(_-_)}  /\  \");
                    Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop);
                    break;
                case 3:
                    Console.Write(@"/  /\  {(___)}  /\  \");
                    Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop);
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
        public void Do_Moist()
        {
            bool IsMoist = true;
            if (IsMoist)
            {
                for (int i = 0; i < 3; i++)
                {
                    Moist();
                    System.Threading.Thread.Sleep(200);

                }
                IsMoist = false;
            }
            Console.Clear();
            Console.WriteLine("Please Enter a Command");

        }
        public enum FapSpeed { Fast, Slow }
    }
}
