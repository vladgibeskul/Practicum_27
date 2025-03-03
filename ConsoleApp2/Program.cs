namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {  
            int[] myArray = new int[10]; 
            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(1, 100); 
            }

            Console.WriteLine("Неотсортированный массив:");
            PrintArray(myArray);

            BubbleSort(myArray);

            Console.WriteLine("\n Отсортированный массив (c помощью пузырьков):");
            PrintArray(myArray);

            random.NextBytes(new byte[1]); // Сброс генератора random
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(1, 100); 
            }
            Array.Sort(myArray);

            Console.WriteLine("\n Отсортированный массив (Array):");
            PrintArray(myArray);
            Console.ReadLine();
        }

        public static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
