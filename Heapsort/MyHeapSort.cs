namespace Heapsort;

public class MyHeapSort
{
    public  void HeapSort(int[] array)
        {
            int length = array.Length;
            for (int i = length / 2 - 1; i >= 0; i--) 
                Heapify(array, length, i);

            for (int i = length-1; i>=0; i--)
            {
                (array[0], array[i]) = (array[i], array[0]);
                Heapify(array, i, 0);
            }
        }
        private void Heapify(int[] arr, int heapSize, int rootIndex)
        {
            int largest = rootIndex;
            int leftEl = 2*rootIndex + 1;
            int rightEl = 2*rootIndex + 2; 
     
            // Если левый дочерний элемент больше корня
            if (leftEl < heapSize && arr[leftEl] > arr[largest])
                largest = leftEl;
     
            // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
            if (rightEl < heapSize && arr[rightEl] > arr[largest])
                largest = rightEl;
     
            // Если самый большой элемент не корень
            if (largest != rootIndex)
            {
                (arr[rootIndex], arr[largest]) = (arr[largest], arr[rootIndex]);
                Heapify(arr, heapSize, largest);
            }
        }
    }