namespace EstructurasDeDatosEjercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Burbuja();
        }

        static void Burbuja()
        {
            int i, j;
            int TamañoArreglo;
            int NumeroTemporal;

            Console.Write("Ingrese el tamaño del arreglo: ");
            TamañoArreglo = int.Parse(Console.ReadLine());

            int[] arreglo = new int[TamañoArreglo];

            Console.WriteLine("Ingrese los elementos del arreglo:");
            for (i = 0; i < arreglo.Length; i++)
            {
                Console.Write("Elemento {0}: ", i + 1);
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < arreglo.Length - 1; i++)
            {
                for (j = 0; j < arreglo.Length - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        NumeroTemporal = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = NumeroTemporal;
                    }
                }
            }

            Console.WriteLine("Arreglo ordenado:");
            for (i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i]);
            }
        }
    }
}
