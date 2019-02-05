using System;
using System.Collections;

namespace BitArrayDemo
{
    class Program
    {
        static void Main()
        {
            //var bits = new BitArray(3);
            //bits[0] = false;
            //bits[1] = true;
            //bits[2] = false;

            //var moreBits = new BitArray(3);
            //moreBits[0] = true;
            //moreBits[1] = true;
            //moreBits[2] = false;

            //var xorBits = bits.Xor(moreBits);

            //foreach (bool bit in xorBits)
            //{
            //    Console.WriteLine(bit);
            //}

            var bits = new BitArray(3);
            bits[0] = false;
            bits[1] = true;
            bits[2] = false;

            var morebits = new BitArray(3);
            morebits[0] = true;
            morebits[1] = true;
            morebits[2] = false;

            var xorBits = bits.Xor(morebits);

            foreach (bool bit in xorBits)
            {
                Console.WriteLine(bit);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
