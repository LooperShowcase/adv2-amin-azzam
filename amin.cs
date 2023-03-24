using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Amin_Azzam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("Welcome to Amin game");

            char[] lines = { '_' , '_' , '_' , '_'  };
            for (int i = 0; i < lines.Length; i++)
            {
                Console.Write(lines[i] + " ");
            }
            Console.WriteLine();
            string tw = getTodayWord();
            int heart = tw.Length;

            while (heart > 0)
            {

                char ch = askUser();
                int result = checkletter(tw, ch, lines);
                if (result == -1)
                {
                    heart--;
                    Console.WriteLine( "you have " +  heart +  " left");
                }
                else
                {
                    lines[result] = ch;
                    Console.Write(lines);


                }
                if(checkWin(lines)== true)
                {
                    Console.WriteLine("you win");
                }

                
            }

            Console.WriteLine("You lost");
        }
        public static char askUser()
        {
            Console.WriteLine(" Please enter a char");
            char c = Console.ReadLine()[0];
            return c;
        }
        public static string getTodayWord()
        {
            string[] words = { "dogs", "cats", "bird", "loop", "home", "wall", "amin", "moon", "char", "door", "love","true","line" };
            Random rd = new Random();
            int rand = rd.Next(words.Length);
            return words[rand];

        }
        public static int checkletter(string todayword, char ch, char[] lines)
        {
            for (int i = 0; i < todayword.Length; i++)
            {
                if (todayword[i] == ch && lines[i]!=ch)
                {
                    return i;
                }
            }
            return -1;
            

        }

        public static int checkWin(string todayWord, char[] lines)
        {
            for(int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == '_')
                {
                    return -1;
                }
               
            }
            return 1;
        }
    }
}
