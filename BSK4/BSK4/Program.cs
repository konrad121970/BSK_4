using System;
using System.Collections.Generic;

namespace BSK4
{
    class Program
    {
        static void Main(string[] args)
        {
            LSFR.Init("100101");

            for(int i = 0; i < Math.Pow(2, 9) - 1; i++)
            {
                var bit = LSFR.GenerateBit();
                Console.Write(bit);
            }
        }
    }
}