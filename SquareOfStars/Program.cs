using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {

        

        static void Main(string[] args)
        {


            var COUNTER = int.Parse(Console.ReadLine());
            const string BLANK = " ";
            const string STAR = "*";
            const string SLASH = "/";
           
            for (int y = 0; y < COUNTER; y++)
            {
                for (int x = 0; x < COUNTER; x++)
                {
                    if (y > 0)
                    {
                        //Print either star or space
                        //Blank if inside square
                    }
                    else
                    {
                        Console.Write(STAR);
                    }
                    /*for (int b = 0; b < ; b++)
                    {
                        Console.Write(BLANK);
                    }*/
                }
                Console.WriteLine();
            }









        }
    }
}
