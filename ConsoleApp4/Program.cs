namespace ConsoleApp4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] myArray = { 5, 2, 9, 1, 5, 6 };

            int maxElement = myArray[0];
            int maxIndex = 0;

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > maxElement)
                {
                    maxElement = myArray[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine($"Максимальный элемент: {maxElement}, индекс: {maxIndex}");

            int minElement = myArray[0];
            int minIndex = 0;

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minElement)
                {
                    minElement = myArray[i];
                    minIndex = i;
                }
            }

            Console.WriteLine($"Минимальный элемент: {minElement}, индекс: {minIndex}");

            myArray[maxIndex] = minElement;
            myArray[minIndex] = maxElement;

            Console.WriteLine("Массив после замены:");
            PrintArray(myArray);

            int count = Math.Abs(maxIndex - minIndex) - 1;
            Console.WriteLine($"Количество элементов между max и min: {count}");
            Console.ReadKey();
        }

        public static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

    }
}
