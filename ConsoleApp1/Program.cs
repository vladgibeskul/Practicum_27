using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размер массива:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Func(array);
            Сonclusion(array);
            Console.ReadKey();

        }
        public static void Func(int[] array)  
        {
            
            Console.WriteLine("Введите элемнет массива:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            
        }
        public static void  Сonclusion(int[] array)
        { 
        Array.Reverse(array);
            Console.WriteLine("Массивы в обратном порядке:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }



    }
}
