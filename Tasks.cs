using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFCS._4
{
    public static class Tasks
    {
        public static string Task1(int number)
        {
            int numberPlus1 = number + 1;
            int numberMinus1 = number - 1;

            return $"{numberMinus1}{number}{numberPlus1}";
        }

        public static int[] Task2(int[] array, int elementNumber)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            var temp = new List<int>(array);

            for (int i = temp.Count / elementNumber * elementNumber - 1; i >= 0; i -= elementNumber)
            {
                temp.RemoveAt(i);
            }
            var result = temp.ToArray();

            return result;
        }

    }
}
