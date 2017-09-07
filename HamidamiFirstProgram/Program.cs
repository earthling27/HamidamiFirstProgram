using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace HamidamiFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

    

            //string testdata= Console.ReadLine();
            //Console.WriteLine("Looking for the data with that name");
            //var test = (RGBcolor)Enum.Parse(typeof(RGBcolor), testdata);
            //Console.WriteLine(test);

            //foreach (var VARIABLE in testdata)         {
            //    Console.WriteLine(VARIABLE);
            //}
            //Console.WriteLine("End of the line");
            var random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine((int)testdata[i]);
                

            //}

            int   a = 'a' + random.Next();
            char b = 'b';

            Console.WriteLine(a);


        }

        public void blue()
        {
            Console.WriteLine("This is the blue color section");
        }
    }

    public  struct cord
    {
        static  int red = 0;
        static  int blue =0;
        static  int green = 0;

        public bool setcolor(int red, int green, int blue)
        {
            cord.red = red;
            cord.green = green;
            cord.blue = blue;
            return true;
        }

        public  int[] getColor()
        {
            int [] color = {cord.red, cord.blue, cord.green};
            return color;
        }
    }
}

