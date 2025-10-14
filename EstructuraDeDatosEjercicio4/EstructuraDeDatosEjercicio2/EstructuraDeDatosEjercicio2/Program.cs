using EstructuraDeDatosEjercicio1;

namespace EstructuraDeDatosEjercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila<char> miPila = new Pila<char>();

            string palabra = "", palabraInvertida = "";

            Console.WriteLine("Ingrese una palabra:");
            palabra = Console.ReadLine();

            for (int i = 0; i < palabra.Length; i++)
            {
                miPila.Push(palabra[i]);
            }

            for (int i = 0; i < palabra.Length; i++)
            {
                palabraInvertida += miPila.Pop().ToString();
            }

            palabra = palabra.ToLower();
            palabraInvertida = palabraInvertida.ToLower();

            if (palabraInvertida == palabra)
            {
                Console.WriteLine($"La palabra '{palabra}' es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"La palabra '{palabra}' no es un palíndromo.");
            }

            //Texto de prueba
        }
    }
}
