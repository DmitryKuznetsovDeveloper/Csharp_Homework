using System.Threading.Channels;

namespace Heapsort
{
    internal class Program
    {
        static void PrintArray(int[] arr) => Console.Write($"\n{string.Join(" ", arr)}");
        static void FillArray(int[] array)
        {
            var random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(1, 20);
        }
        
        static void Main()
        {
            var myHeapsort = new MyHeapSort();
             int[] myArray = new int[20];
             FillArray(myArray);
             PrintArray(myArray);
             myHeapsort.HeapSort(myArray);
             PrintArray(myArray);
         }   
    }
}

