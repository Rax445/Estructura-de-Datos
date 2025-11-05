using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosEjercicio1
{
    internal class Fila<T>
    {
        private List<T> elementos; // Almacenamiento interno

        // Constructor
        public Fila()
        {
            elementos = new List<T>();
        }

        // Método para agregar un elemento al final de la fila (Encolar)
        public void Push(T item)
        {
            elementos.Add(item);
        }

        // Método para quitar el primer elemento de la fila (Desencolar)
        public T Pop()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La fila está vacía.");

            T primero = elementos[0];
            elementos.RemoveAt(0);
            return primero;
        }

        // Devuelve el primer elemento sin quitarlo
        public T Frente()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La fila está vacía.");

            return elementos[0];
        }

        // Propiedad para obtener el número de elementos en la fila
        public int Tamaño
        {
            get { return elementos.Count; }
        }

        // Verifica si la fila está vacía
        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }

        // Muestra el contenido de la fila (solo para visualización)
        public string Mostrar()
        {
            string contenido = "Contenido de la fila:\n";

            foreach (T item in elementos)
            {
                contenido = $"- {item}\n";
            }

            return contenido;
        }
    }
}
