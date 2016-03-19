﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures.Sorting;

namespace UnitTestProject1
{
	[TestClass]
	public class TestInsertionSort
	{
		[TestMethod]
		public void TestEmpty()
		{
			var arr = new int[0];
			Insertion.Sort<int>(arr, (x1, x2) => x1 >= x2);
		}

		[TestMethod]
		public void TestBaseRandomSort1()
		{
			var arr = ArrayGenerator.RandomArray1.GetCopy();
			Insertion.Sort(arr, ArrayGenerator.IsSortedFunc);
			Assert.AreEqual(arr.LongLength, ArrayGenerator.Length);
			Assert.AreEqual(arr.IsSorted(ArrayGenerator.IsSortedFunc), true);
		}

		[TestMethod]
		public void TestBaseRandomSort2()
		{
			var arr = ArrayGenerator.RandomArray2.GetCopy();
			Insertion.Sort(arr, ArrayGenerator.IsSortedFunc);
			Assert.AreEqual(arr.LongLength, ArrayGenerator.Length);
			Assert.AreEqual(arr.IsSorted(ArrayGenerator.IsSortedFunc), true);
		}

		[TestMethod]
		public void TestBaseSortedSort1()
		{
			var arr = ArrayGenerator.SortedArray1.GetCopy();
			Insertion.Sort(arr, ArrayGenerator.IsSortedFunc);
			Assert.AreEqual(arr.LongLength, ArrayGenerator.Length);
			Assert.AreEqual(arr.IsSorted(ArrayGenerator.IsSortedFunc), true);
		}

		[TestMethod]
		public void TestBaseSortedSort2()
		{
			var arr = ArrayGenerator.SortedArray2.GetCopy();
			Insertion.Sort(arr, ArrayGenerator.IsSortedFunc);
			Assert.AreEqual(arr.LongLength, ArrayGenerator.Length);
			Assert.AreEqual(arr.IsSorted(ArrayGenerator.IsSortedFunc), true);
		}
	}
}