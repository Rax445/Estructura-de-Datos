using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosEjercicio1
{
    internal class Pila<T>
    {
        private List<T> elementos; // Lista interna para guardar los elementos

        public Pila()
        {
            elementos = new List<T>();
        }

        // Método para agregar (apilar) un elemento
        public void Push(T elemento)
        {
            elementos.Add(elemento);
        }

        // Método para quitar (desapilar) el último elemento
        public T Pop()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila está vacía.");

            T elemento = elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1);
            return elemento;
        }

        // Método para ver el elemento superior sin quitarlo
        public T Cima()
        {
            if (EstaVacia())
            {
                Console.WriteLine("Esta vacia");
                throw new InvalidOperationException("La pila está vacía.");
            }
                

            return elementos[elementos.Count - 1];
        }

        // Método para comprobar si la pila está vacía
        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }

        // Propiedad para obtener el número de elementos en la pila
        public int Tamaño
        {
            get { return elementos.Count; }
        }

        // Mostrar todos los elementos (opcional)
        public void Mostrar()
        {
            Console.WriteLine("Elementos en la pila:");
            for (int i = elementos.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(elementos[i]);
            }
        }
    }
}
