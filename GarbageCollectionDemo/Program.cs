using System;

namespace GarbageCollectionDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            long num1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[5000];
                values = null;
            }

            long num2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long num3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);
            }
            Console.WriteLine("######################");
            long bytes1 = GC.GetTotalMemory(false); // get m/r in bytes

            byte[] memory = new byte[1000 * 1000 * 10]; //10 million bytes
            memory[0] = 1; //set m/r(preventallocationfrom being optimized out

            long bytes2 = GC.GetTotalMemory(false);   // get m/r
            long bytes3 = GC.GetTotalMemory(true);   // get m/r

            Console.WriteLine(bytes1);
            Console.WriteLine(bytes2);
            Console.WriteLine(bytes2 -bytes1);
            Console.WriteLine(bytes3);
            Console.WriteLine(bytes3 - bytes2);
            Console.ReadLine();
        }
    }
}