namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = { 3, 2, 1, 5, 4 };

            QuickSort(numeros, 0, numeros.Length - 1);

            Console.WriteLine("Array ordenado:");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            void QuickSort(int[] arr, int inicio, int fin)
            {
                if (inicio < fin)
                {
                    int indicePivote = Particionar(arr, inicio, fin);
                    QuickSort(arr, inicio, indicePivote - 1);
                    QuickSort(arr, indicePivote + 1, fin);
                }
            }

            int Particionar(int[] arr, int inicio, int fin)
            {
                int pivote = arr[fin];
                int i = inicio - 1;

                for (int j = inicio; j < fin; j++)
                {
                    if (arr[j] < pivote)
                    {
                        i++;
                        Intercambiar(arr, i, j);
                    }
                }

                Intercambiar(arr, i + 1, fin);
                return i + 1;
            }

            void Intercambiar(int[] arr, int a, int b)
            {
                int temp = arr[a];
                arr[a] = arr[b];
                arr[b] = temp;
            }
        }
    }
}
