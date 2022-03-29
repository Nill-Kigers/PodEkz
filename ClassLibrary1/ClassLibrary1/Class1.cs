using System;
using System.Linq;

namespace ClassLibrary1
{
    public class Class1
    {
        public static double MinAVG(string[] Marks)
        {
            double result = 0;
            int[] array = new int[Marks.Length];
            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            double sum = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                int num;
                bool isNum = int.TryParse(Marks[i], out num);
                if (isNum)
                {
                    array[i] = Convert.ToInt32(Marks[i]);
                    Console.WriteLine(array[i]);
                    sum += array[i];
                }
                else 
                {
                    result = 0;
                }
            }
            if (Marks.Length == 0)
            {
                result = 0;
            }
            else
            {
                result = sum / Marks.Length;
            }
            return result;

        }
    }
}
