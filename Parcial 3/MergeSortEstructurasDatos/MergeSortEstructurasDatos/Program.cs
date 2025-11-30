namespace MergeSortEstructurasDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            numeros = new int[] { 3, 2, 1, 5, 4};

            void MergeSort(int[] arr)
            {
                if (arr.Length <= 1)
                    return;

                int mitad = arr.Length / 2;
                int[] izquierda = new int[mitad];
                int[] derecha = new int[arr.Length - mitad];

                for (int i = 0; i < mitad; i++)
                    izquierda[i] = arr[i];

                for (int i = mitad; i < arr.Length; i++)
                    derecha[i - mitad] = arr[i];

                // Orden recursiva
                MergeSort(izquierda);
                MergeSort(derecha);

                // Fusionamos
                Merge(arr, izquierda, derecha);
            }

            void Merge(int[] arr, int[] izquierda, int[] derecha)
            {
                int i = 0, j = 0, k = 0;

                while (i < izquierda.Length && j < derecha.Length)
                {
                    if (izquierda[i] <= derecha[j])
                        arr[k++] = izquierda[i++];
                    else
                        arr[k++] = derecha[j++];
                }

                while (i < izquierda.Length)
                    arr[k++] = izquierda[i++];

                while (j < derecha.Length)
                    arr[k++] = derecha[j++];
            }

            MergeSort(numeros);

            Console.WriteLine("Array ordenado:");
            foreach (var num in numeros)
            {
                Console.Write(num + " ");
            }
        }
    }
}
