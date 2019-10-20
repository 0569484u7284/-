using System;

namespace ArraysStringsDemo
{
    class Table
    {
        public static void TableCal()
        {
            int[] intArrayL = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] intArrayR = intArrayL;

            int temp;

            for (int item = 0; item < intArrayL.Length; item++)
            {
                for (int items = 0; items < intArrayR.Length; items++)
                {
                    temp = intArrayL[item] * intArrayR[items];
                    Console.Write($"{ intArrayL[item]} *{intArrayR[items]} = {temp}\n");
                }
                Console.WriteLine("");
            }
        }

    }
    class Program
    {
        static void Main()
        {
            //Object o = new Object();

            //Object o2 = null;
            //Object o3;

            //String s = "Hello";
            //string s2 = "Hello";


            //int[] intArray2 = new int[3];

            //int[][] tDArray = new int[2][];


            //tDArray[0] = intArray;
            //tDArray[1] = intArray2;

            //foreach (var item in tDArray)
            //{
            //    //Console.WriteLine(item);
            //    foreach (var item2 in item)
            //    {
            //        Console.Write(item2 + " ");
            //    }
            //    Console.WriteLine();
            //}

            Table.TableCal();

            // String s1 = new String("Hello");
        }
    }
}