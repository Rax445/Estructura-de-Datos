namespace InsertionSortEstructurasDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 3, 2, 1, 5, 4 };

            InsertionSort(numeros);

            Console.WriteLine("Array ordenado:");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            void InsertionSort(int[] arr)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    int elemento = arr[i];
                    int j = i - 1;

                    while (j >= 0 && arr[j] > elemento)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }

                    arr[j + 1] = elemento;
                }
            }
        }
    }
}
