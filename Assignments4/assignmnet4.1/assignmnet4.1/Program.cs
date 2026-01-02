using System;

class DuplicateCount
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 5, 1, 3, 3 };
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int duplicate = 0;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    duplicate = 1;
                    break;
                }
            }

            if (duplicate == 1)
            {
                int alreadyCounted = 0;

                for (int k = 0; k < i; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        alreadyCounted = 1;
                        break;
                    }
                }

                if (alreadyCounted == 0)
                {
                    count++;
                }
            }
        }

        Console.WriteLine("Total number of duplicate elements: " + count);
        Console.ReadKey();
    }
}
