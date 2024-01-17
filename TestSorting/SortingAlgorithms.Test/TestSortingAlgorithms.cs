using NUnit.Framework;
using System;
using System.Linq;

namespace SortingAlgorithms.Test
{
    [TestFixture]
    public class TestSortingAlgorithms
    {
        public int[] arr;

        [SetUp]
        public void Setup()
        {
            // Shared array for all test methods
            arr = new int[] { 12, 11, 13, 5, 6, 7 };
        }

        [Test]
        public void MergeSort_SortsIntArray()
        {
            // Act
            MergeSort.MergeSortAlgorithm(arr);

            // Assert
            Assert.That(arr, Is.EqualTo(new int[] { 5, 6, 7, 11, 12, 13 }));
        }

        [Test]
        public void MergeSort_SortsEmptyArray()
        {
            // Arrange
            arr = new int[0];

            // Act
            MergeSort.MergeSortAlgorithm(arr);

            // Assert
            Assert.That(arr, Is.Empty);
        }

        [Test]
        public void QuickSort_SortsIntArray()
        {
            // Act
            QuickSort.QuickSortAlgorithm(arr);

            // Assert
            Assert.That(arr, Is.EqualTo(new int[] { 5, 6, 7, 11, 12, 13 }));
        }

        [Test]
        public void QuickSort_SortsEmptyArray()
        {
            // Arrange
            arr = new int[0];

            // Act
            QuickSort.QuickSortAlgorithm(arr);

            // Assert
            Assert.That(arr, Is.Empty);
        }

        [Test]
        public void SelectionSort_SortsIntArray()
        {
            // Act
            SelectionSort.SelectionSortAlgorithm(arr);

            // Assert
            Assert.That(arr, Is.EqualTo(new int[] { 5, 6, 7, 11, 12, 13 }));
        }

        [Test]
        public void SelectionSort_SortsEmptyArray()
        {
            // Arrange
            arr = new int[0];

            // Act
            SelectionSort.SelectionSortAlgorithm(arr);

            // Assert
            Assert.That(arr, Is.Empty);
        }

        [Test]
        public void ShellSort_SortsIntArray()
        {
            // Act
            ShellSort.ShellSortAlgorithm(arr);

            // Assert
            Assert.That(arr, Is.EqualTo(new int[] { 5, 6, 7, 11, 12, 13 }));
        }

        [Test]
        public void ShellSort_SortsEmptyArray()
        {
            // Arrange
            arr = new int[0];

            // Act
            ShellSort.ShellSortAlgorithm(arr);

            // Assert
            Assert.That(arr, Is.Empty);
        }

        [Test]
        public void InsertionSort_SortsIntArray()
        {
            // Act
            InsertionSort.InsertionSortAlgorithm(arr);

            // Assert
            Assert.That(arr, Is.EqualTo(new int[] { 5, 6, 7, 11, 12, 13 }));
        }

        [Test]
        public void InsertionSort_SortsEmptyArray()
        {
            // Arrange
            arr = new int[0];

            // Act
            InsertionSort.InsertionSortAlgorithm(arr);

            // Assert
            Assert.That(arr, Is.Empty);
        }




    }
}
