using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //gennerate hello world! buy using overly complicated tactics.
            //Console.WriteLine("Hello World!");
            //made in 30 minutes on 11/3/2021 
            //made by ryan
            //the goal of this program is to be the most complicated hello world! program ever
            //in order for the program to have sucsess it must randomly generate each character in hello world! on its first try when mixed in with the entire ascii pool
            // 1 in 494 chance to hit the proper charachter 
            // 12 times.
            //494^12 
            //average clock is 6000 
            //and about 1 ish seconds to execute one itteration depending on processor.
            //its not impossible.
            //the stats and readout are simply there to keep you entertained on your adventure
            //happy hunting.

            List<string> outPut = new(12);
            bool running = true;
            string s;
            int count = 1;
            int clock = 0;
            int last = 0;
            int fast = int.MaxValue;
            int slow = int.MinValue;
            int avg = 0;
            int itt = 0;
            while (running == true)
            {
                clock++;
                bool sucsess = false;
                s = generateChar();

                sucsess = displayOutPut(outPut, s, count, last, fast, slow, avg, itt);
                if (sucsess)
                {
                    outPut.Add(s);
                    count++;
                    sucsess = false;
                }
                if (count == 13)
                {
                    Console.Clear();
                    foreach (string item in outPut)
                    {
                        Console.Write(item);
                        running = false;
                        
                    }
                    Console.WriteLine("\n" + clock);
                    if (clock != 12)
                    {
                        running = true;
                        count = 1;
                        if (clock < fast)
                        {
                            fast = clock;
                        }
                        if (clock > slow)
                        {
                            slow = clock;
                        }
                        avg += clock;
                        last = clock;
                        clock = 0;
                        outPut.Clear();
                    }
                    itt++;
                }
            }
        }
        static public string generateChar()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 494);
            char c = (char)i;
            string s = c.ToString();
            return s;
        }
        static public bool displayOutPut(List<string> outPut, string s, int i,int last ,int fast, int slow, int avg, int itt)
        {
            bool sucsess = false;
            if (fast == int.MaxValue)
            {
                fast = 0;
            }
            if (slow == int.MinValue)
            {
                slow = 0;
            }
            if (itt != 0)
            {
                avg = avg / itt;
            }
            
            Console.Write("fastest: " + fast + "\tslowest: " + slow + "\taverage: "+ avg + "\titteration: " + (itt + 1) + "\tlast: " + last + "\t\t");
            foreach (string item in outPut)
            {
                Console.Write(item);
            }
            Console.Write(s + "\n");
            if (i == 1)
            {
                if (s == "H")
                {
                    sucsess = true;
                }
                else 
                {
                    sucsess = false;
                }
            }
            else if (i == 2)
            {
                if (s == "e")
                {
                    sucsess = true;
                }
                else
                {
                    sucsess = false;
                }
            }
            else if (i == 3)
            {
                if (s == "l")
                {
                    sucsess = true;
                }
                else
                {
                    sucsess = false;
                }
            }
            else if (i == 4)
            {
                if (s == "l")
                {
                    sucsess = true;
                }
                else
                {
                    sucsess = false;
                }
            }
            else if (i == 5)
            {
                if (s == "o")
                {
                    sucsess = true;
                }
                else
                {
                    sucsess = false;
                }
            }
            else if (i == 6)
            {
                if (s == " ")
                {
                    sucsess = true;
                }
                else
                {
                    sucsess = false;
                }
            }
            else if (i == 7)
            {
                if (s == "W")
                {
                    sucsess = true;
                }
                else
                {
                    sucsess = false;
                }
            }
            else if (i == 8)
            {
                if (s == "o")
                {
                    sucsess = true;
                }
                else
                {
                    sucsess = false;
                }
            }
            else if (i == 9)
            {
                if (s == "r")
                {
                    sucsess = true;
                }
                else
                {
                    sucsess = false;
                }
            }
            else if (i == 10)
            {
                if (s == "l")
                {
                    sucsess = true;
                }
                else
                {
                    sucsess = false;
                }
            }
            else if (i == 11)
            {
                if (s == "d")
                {
                    sucsess = true;
                }
                else
                {
                    sucsess = false;
                }
            }
            else if (i == 12)
            {
                if (s == "!")
                {                    
                    sucsess = true;
                }
                else
                {
                    sucsess = false;
                }
            }
            return sucsess;
        }
    }
}
