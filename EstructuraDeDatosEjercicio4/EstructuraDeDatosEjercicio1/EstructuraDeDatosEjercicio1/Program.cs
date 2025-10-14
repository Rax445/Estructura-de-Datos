namespace EstructuraDeDatosEjercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila<char> miPila = new Pila<char>();

            string texto;

            char[] simbolos = { '(', ')', '{', '}', '[', ']' };
            char[] simbolosApertura = { '(', '{', '[' };

            Console.WriteLine("Ingrese la cadena de texto a verificar");
            texto = Console.ReadLine();

            if (VerificarTexto())
            {
                Console.WriteLine("La cadena de texto está balanceada");
            }
            else
            {
                Console.WriteLine("La cadena de texto no está balanceada");
            }

            Console.ReadKey();

            bool VerificarTexto()
            {
                for (int i = 0; i < texto.Length; i++)
                {
                    if (!simbolos.Contains(texto[i]))
                    {
                        continue;
                    }

                    if (simbolosApertura.Contains(texto[i]))
                    {
                        miPila.Push(texto[i]);
                        continue;
                    }

                    if (miPila.EstaVacia())
                    {
                        return false;
                    }

                    char ultimoSimboloApertura = miPila.Pop();

                    if (!Coinciden(ultimoSimboloApertura, texto[i]))
                    {
                        return false;
                    }
                }

                if (miPila.EstaVacia())
                {
                    return true;
                }

                return false;
            }

            bool Coinciden(char apertura, char cierre)
            {
                return (apertura == '(' && cierre == ')') ||
                       (apertura == '{' && cierre == '}') ||
                       (apertura == '[' && cierre == ']');

            }
        }
    }
}
