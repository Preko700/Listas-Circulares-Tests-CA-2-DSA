using System;
using System.Text;

namespace EstructurasDeDatos
{
    // Clase para representar un nodo en la lista circular
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    // Implementación de la lista circular simple
    public class CircularLinkedList<T>
    {
        private Node<T> head;
        private int size;

        public CircularLinkedList()
        {
            head = null;
            size = 0;
        }

        // a. Insertar al inicio
        public void InsertAtBeginning(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                // Si la lista está vacía, el nuevo nodo apunta a sí mismo
                head = newNode;
                newNode.Next = head;
            }
            else
            {
                // Si la lista no está vacía, necesitamos encontrar el último nodo
                Node<T> current = head;
                while (current.Next != head)
                {
                    current = current.Next;
                }

                // Insertar el nuevo nodo al inicio
                newNode.Next = head;
                head = newNode;

                // Hacer que el último nodo apunte al nuevo head para mantener la circularidad
                current.Next = head;
            }

            size++;
        }

        // b. Insertar al final
        public void InsertAtEnd(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                // Si la lista está vacía, es lo mismo que insertar al inicio
                head = newNode;
                newNode.Next = head;
            }
            else
            {
                // Encontrar el último nodo
                Node<T> current = head;
                while (current.Next != head)
                {
                    current = current.Next;
                }

                // Insertar el nuevo nodo al final
                current.Next = newNode;
                newNode.Next = head;
            }

            size++;
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
            Node<T> newNode = new Node<T>(data);
            Node<T> current = head;

            // Avanzar hasta la posición anterior a donde queremos insertar
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            // Insertar el nuevo nodo
            newNode.Next = current.Next;
            current.Next = newNode;

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
                // Encontrar el último nodo
                Node<T> lastNode = head;
                while (lastNode.Next != head)
                {
                    lastNode = lastNode.Next;
                }

                // Actualizar el head y el apuntador del último nodo
                head = head.Next;
                lastNode.Next = head;
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
                // Encontrar el penúltimo nodo
                Node<T> current = head;
                Node<T> previous = null;

                while (current.Next != head)
                {
                    previous = current;
                    current = current.Next;
                }

                // Actualizar el apuntador del penúltimo nodo
                previous.Next = head;
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
            Node<T> current = head;

            // Avanzar hasta la posición anterior a donde queremos eliminar
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            // Eliminar el nodo
            current.Next = current.Next.Next;

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
            Node<T> current = head;

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
