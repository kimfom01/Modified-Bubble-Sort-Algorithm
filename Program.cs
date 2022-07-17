using System;

namespace Modified_Bubble_Sort
{
    class Program
    {
        const int ELEMENTS = 20;
        static void Main(string[] args)
        {
            int i;
            Random rnd = new Random();

            int[] arr = new int[ELEMENTS];
            for(i=0; i<=ELEMENTS-1; i++)
            {
                arr[i] = rnd.Next(100);
            }

            ModifiedBubbleSort(arr);
            for(i=0; i<=ELEMENTS-1; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }

        static void ModifiedBubbleSort(int[] arr)
        {
            int i, j, temp;
            bool flag;
            for(i = 1; i <= arr.Length - 1; i++)
            {
                flag = false;
                for(j = arr.Length - 1; j >= i; j--)
                {
                    if(arr[j] < arr[j-1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;

                        flag = true;
                    }
                }

                if(flag == false)
                {
                    break;
                }
            }
        }
    }
}
