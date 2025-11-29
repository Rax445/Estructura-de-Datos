namespace RecursionEstructurasDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso de la función recursiva para calcular el factorial
            Console.WriteLine("Ingrese un número para calcular su factorial:");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Solo se pueden numeros positivos o 0");
            }
            else
            {
                Console.WriteLine($"El factorial de {numero} es: {CalcularFactorial(numero)}");
            }

            int CalcularFactorial(int numero){
                if (numero <= 1)
                {
                    return 1;
                }
                else
                {
                    return numero * CalcularFactorial(numero - 1);
                }
            }
        }
    }
}
