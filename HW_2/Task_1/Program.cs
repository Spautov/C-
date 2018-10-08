using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartArray<int> smArr = new SmartArray<int>();
            try
            {
                smArr.Begin = -25;
                smArr.End = -1;
                smArr.Begin = -15;
                smArr.End = -1;
                smArr[-15] = 4;
                Console.WriteLine(smArr[-15]);
                smArr.Begin = -25;
                smArr.End = -10;
                Console.WriteLine(smArr[-25]);
                Console.WriteLine(smArr[-15]);
                Console.WriteLine("Begin:" + smArr.Begin);
                Console.WriteLine("End:" + smArr.End);
                Console.WriteLine("Длина массива:" + smArr.Length);
            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
