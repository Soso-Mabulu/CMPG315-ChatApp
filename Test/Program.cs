using CommonLibs.Data;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                DataConverter.FromInt(521125, out var byte1, out var byte2, out var byte3, out var byte4);

                Console.WriteLine(DataConverter.ToInt(byte1, byte2, byte3, byte4));
                Console.ReadKey();
            }

        }
    }
}
