using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstructurasDeDatos;

namespace EstructurasDeDatosTests
{
    [TestClass]
    public class CircularLinkedListTests
    {
        [TestMethod]
        public void InsertAtBeginning_EmptyList_ItemInserted()
        {
            // Arrange
            CircularLinkedList<int> list = new CircularLinkedList<int>();

            // Act
            list.InsertAtBeginning(10);

            // Assert
            Assert.AreEqual(1, list.Size());
            Assert.AreEqual("10", list.ToString());
        }

        [TestMethod]
        public void InsertAtBeginning_NonEmptyList_ItemInserted()
        {
            // Arrange
            CircularLinkedList<int> list = new CircularLinkedList<int>();
            list.InsertAtBeginning(20);

            // Act
            list.InsertAtBeginning(10);

            // Assert
            Assert.AreEqual(2, list.Size());
            Assert.AreEqual("10, 20", list.ToString());
        }

        [TestMethod]
        public void InsertAtEnd_EmptyList_ItemInserted()
        {
            // Arrange
            CircularLinkedList<int> list = new CircularLinkedList<int>();

            // Act
            list.InsertAtEnd(10);

            // Assert
            Assert.AreEqual(1, list.Size());
            Assert.AreEqual("10", list.ToString());
        }

        [TestMethod]
        public void InsertAtEnd_NonEmptyList_ItemInserted()
        {
            // Arrange
            CircularLinkedList<int> list = new CircularLinkedList<int>();
            list.InsertAtEnd(10);

            // Act
            list.InsertAtEnd(20);

            // Assert
            Assert.AreEqual(2, list.Size());
            Assert.AreEqual("10, 20", list.ToString());
        }

        [TestMethod]
        public void InsertAt_ValidIndex_ItemInserted()
        {
            // Arrange
            CircularLinkedList<int> list = new CircularLinkedList<int>();
            list.InsertAtEnd(10);
            list.InsertAtEnd(30);

            // Act
            list.InsertAt(20, 1);

            // Assert
            Assert.AreEqual(3, list.Size());
            Assert.AreEqual("10, 20, 30", list.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertAt_InvalidIndex_ThrowsException()
        {
            // Arrange
            CircularLinkedList<int> list = new CircularLinkedList<int>();
            list.InsertAtEnd(10);

            // Act & Assert
            list.InsertAt(20, 2); // Índice 2 está fuera de rango
        }

        [TestMethod]
        public void RemoveFromBeginning_NonEmptyList_ItemRemoved()
        {
            // Arrange
            CircularLinkedList<int> list = new CircularLinkedList<int>();
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);

            // Act
            list.RemoveFromBeginning();

            // Assert
            Assert.AreEqual(1, list.Size());
            Assert.AreEqual("20", list.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveFromBeginning_EmptyList_ThrowsException()
        {
            // Arrange
            CircularLinkedList<int> list = new CircularLinkedList<int>();

            // Act & Assert
            list.RemoveFromBeginning();
        }

        [TestMethod]
        public void RemoveFromEnd_NonEmptyList_ItemRemoved()
        {
            // Arrange
            CircularLinkedList<int> list = new CircularLinkedList<int>();
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);

            // Act
            list.RemoveFromEnd();

            // Assert
            Assert.AreEqual(1, list.Size());
            Assert.AreEqual("10", list.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveFromEnd_EmptyList_ThrowsException()
        {
            // Arrange
            CircularLinkedList<int> list = new CircularLinkedList<int>();

            // Act & Assert
            list.RemoveFromEnd();
        }

        [TestMethod]
        public void RemoveAt_ValidIndex_ItemRemoved()
        {
            // Arrange
            CircularLinkedList<int> list = new CircularLinkedList<int>();
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);

            // Act
            list.RemoveAt(1);

            // Assert
            Assert.AreEqual(2, list.Size());
            Assert.AreEqual("10, 30", list.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_InvalidIndex_ThrowsException()
        {
            // Arrange
            CircularLinkedList<int> list = new CircularLinkedList<int>();
            list.InsertAtEnd(10);

            // Act & Assert
            list.RemoveAt(1); // Índice 1 está fuera de rango
        }
    }

    [TestClass]
    public class DoubleCircularLinkedListTests
    {
        [TestMethod]
        public void InsertAtBeginning_EmptyList_ItemInserted()
        {
            // Arrange
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>();

            // Act
            list.InsertAtBeginning(10);

            // Assert
            Assert.AreEqual(1, list.Size());
            Assert.AreEqual("10", list.ToString());
        }

        [TestMethod]
        public void InsertAtBeginning_NonEmptyList_ItemInserted()
        {
            // Arrange
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>();
            list.InsertAtBeginning(20);

            // Act
            list.InsertAtBeginning(10);

            // Assert
            Assert.AreEqual(2, list.Size());
            Assert.AreEqual("10, 20", list.ToString());
        }

        [TestMethod]
        public void InsertAtEnd_EmptyList_ItemInserted()
        {
            // Arrange
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>();

            // Act
            list.InsertAtEnd(10);

            // Assert
            Assert.AreEqual(1, list.Size());
            Assert.AreEqual("10", list.ToString());
        }

        [TestMethod]
        public void InsertAtEnd_NonEmptyList_ItemInserted()
        {
            // Arrange
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>();
            list.InsertAtEnd(10);

            // Act
            list.InsertAtEnd(20);

            // Assert
            Assert.AreEqual(2, list.Size());
            Assert.AreEqual("10, 20", list.ToString());
        }

        [TestMethod]
        public void InsertAt_ValidIndex_ItemInserted()
        {
            // Arrange
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>();
            list.InsertAtEnd(10);
            list.InsertAtEnd(30);

            // Act
            list.InsertAt(20, 1);

            // Assert
            Assert.AreEqual(3, list.Size());
            Assert.AreEqual("10, 20, 30", list.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertAt_InvalidIndex_ThrowsException()
        {
            // Arrange
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>();
            list.InsertAtEnd(10);

            // Act & Assert
            list.InsertAt(20, 2); // Índice 2 está fuera de rango
        }

        [TestMethod]
        public void RemoveFromBeginning_NonEmptyList_ItemRemoved()
        {
            // Arrange
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>();
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);

            // Act
            list.RemoveFromBeginning();

            // Assert
            Assert.AreEqual(1, list.Size());
            Assert.AreEqual("20", list.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveFromBeginning_EmptyList_ThrowsException()
        {
            // Arrange
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>();

            // Act & Assert
            list.RemoveFromBeginning();
        }

        [TestMethod]
        public void RemoveFromEnd_NonEmptyList_ItemRemoved()
        {
            // Arrange
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>();
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);

            // Act
            list.RemoveFromEnd();

            // Assert
            Assert.AreEqual(1, list.Size());
            Assert.AreEqual("10", list.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveFromEnd_EmptyList_ThrowsException()
        {
            // Arrange
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>();

            // Act & Assert
            list.RemoveFromEnd();
        }

        [TestMethod]
        public void RemoveAt_ValidIndex_ItemRemoved()
        {
            // Arrange
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>();
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);

            // Act
            list.RemoveAt(1);

            // Assert
            Assert.AreEqual(2, list.Size());
            Assert.AreEqual("10, 30", list.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_InvalidIndex_ThrowsException()
        {
            // Arrange
            DoubleCircularLinkedList<int> list = new DoubleCircularLinkedList<int>();
            list.InsertAtEnd(10);

            // Act & Assert
            list.RemoveAt(1); // Índice 1 está fuera de rango
        }
    }
}