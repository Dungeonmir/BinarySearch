using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] searchArea = new[] { 1, 3, 10, 5, 2, 20, 15, 40, 30, 25 };
            int low = 0;
            int high = searchArea.Length;

            int temp;
            for (int i = 0; i < searchArea.Length - 1; i++)
            {
                for (int j = i + 1; j < searchArea.Length; j++)
                {
                    if (searchArea[i] > searchArea[j])
                    {
                        temp = searchArea[i];
                        searchArea[i] = searchArea[j];
                        searchArea[j] = temp;
                    }

                }


            }

        }
    }
}
