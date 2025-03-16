using System;
using System.Text;

namespace EstructurasDeDatos
{
    // Clase para representar un nodo en la lista circular doble
    public class DoubleNode<T>
    {
        public T Data { get; set; }
        public DoubleNode<T> Next { get; set; }
        public DoubleNode<T> Previous { get; set; }

        public DoubleNode(T data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }

    // Implementación de la lista circular doble
    public class DoubleCircularLinkedList<T>
    {
        private DoubleNode<T> head;
        private int size;

        public DoubleCircularLinkedList()
        {
            head = null;
            size = 0;
        }

        // a. Insertar al inicio
        public void InsertAtBeginning(T data)
        {
            DoubleNode<T> newNode = new DoubleNode<T>(data);

            if (head == null)
            {
                // Si la lista está vacía, el nuevo nodo apunta a sí mismo en ambas direcciones
                head = newNode;
                newNode.Next = head;
                newNode.Previous = head;
            }
            else
            {
                // Si la lista no está vacía
                DoubleNode<T> lastNode = head.Previous; // El último nodo es el anterior al head

                // Establecer referencias para el nuevo nodo
                newNode.Next = head;
                newNode.Previous = lastNode;

                // Actualizar referencias de los nodos existentes
                head.Previous = newNode;
                lastNode.Next = newNode;

                // Actualizar head
                head = newNode;
            }

            size++;
        }

        // b. Insertar al final
        public void InsertAtEnd(T data)
        {
            if (head == null)
            {
                // Si la lista está vacía, es lo mismo que insertar al inicio
                InsertAtBeginning(data);
            }
            else
            {
                DoubleNode<T> newNode = new DoubleNode<T>(data);
                DoubleNode<T> lastNode = head.Previous; // El último nodo es el anterior al head

                // Establecer referencias para el nuevo nodo
                newNode.Next = head;
                newNode.Previous = lastNode;

                // Actualizar referencias de los nodos existentes
                lastNode.Next = newNode;
                head.Previous = newNode;

                size++;
            }
        }

        // c. Insertar en una posición indicada
        public void InsertAt(T data, int index)
        {
            // Verificar si el índice es válido
            if (index < 0 || index > size)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "El índice está fuera de rango");
            }

            // Si el índice es 0, llamar a InsertAtBeginning
            if (index == 0)
            {
                InsertAtBeginning(data);
                return;
            }

            // Si el índice es igual al tamaño, llamar a InsertAtEnd
            if (index == size)
            {
                InsertAtEnd(data);
                return;
            }

            // Insertar en una posición intermedia
            DoubleNode<T> newNode = new DoubleNode<T>(data);
            DoubleNode<T> current = head;

            // Avanzar hasta la posición donde queremos insertar
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            // Establecer referencias para el nuevo nodo
            newNode.Next = current;
            newNode.Previous = current.Previous;

            // Actualizar referencias de los nodos existentes
            current.Previous.Next = newNode;
            current.Previous = newNode;

            size++;
        }

        // d. Eliminar al inicio
        public void RemoveFromBeginning()
        {
            if (head == null)
            {
                throw new InvalidOperationException("No se puede eliminar de una lista vacía");
            }

            if (head.Next == head)
            {
                // Si solo hay un elemento, la lista queda vacía
                head = null;
            }
            else
            {
                DoubleNode<T> secondNode = head.Next;
                DoubleNode<T> lastNode = head.Previous;

                // Actualizar referencias
                secondNode.Previous = lastNode;
                lastNode.Next = secondNode;

                // Actualizar head
                head = secondNode;
            }

            size--;
        }

        // e. Eliminar al final
        public void RemoveFromEnd()
        {
            if (head == null)
            {
                throw new InvalidOperationException("No se puede eliminar de una lista vacía");
            }

            if (head.Next == head)
            {
                // Si solo hay un elemento, la lista queda vacía
                head = null;
            }
            else
            {
                DoubleNode<T> lastNode = head.Previous;
                DoubleNode<T> newLastNode = lastNode.Previous;

                // Actualizar referencias
                newLastNode.Next = head;
                head.Previous = newLastNode;
            }

            size--;
        }

        // f. Eliminar en una posición indicada
        public void RemoveAt(int index)
        {
            // Verificar si el índice es válido
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "El índice está fuera de rango");
            }

            // Si el índice es 0, llamar a RemoveFromBeginning
            if (index == 0)
            {
                RemoveFromBeginning();
                return;
            }

            // Si el índice es igual al tamaño - 1, llamar a RemoveFromEnd
            if (index == size - 1)
            {
                RemoveFromEnd();
                return;
            }

            // Eliminar de una posición intermedia
            DoubleNode<T> current = head;

            // Avanzar hasta la posición que queremos eliminar
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            // Actualizar referencias
            current.Previous.Next = current.Next;
            current.Next.Previous = current.Previous;

            size--;
        }

        // g. Obtener tamaño
        public int Size()
        {
            return size;
        }

        // h. ToString
        public override string ToString()
        {
            if (head == null)
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();
            DoubleNode<T> current = head;

            do
            {
                sb.Append(current.Data);
                current = current.Next;

                if (current != head)
                {
                    sb.Append(", ");
                }
            } while (current != head);

            return sb.ToString();
        }
    }
}