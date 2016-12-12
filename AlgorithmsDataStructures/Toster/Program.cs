﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsDataStructures;
using AlgorithmsDataStructures.Extensions;
using AlgorithmsDataStructures.Sorting;
using AlgorithmsDataStructures.DataStructures;

namespace Toster {
   public static class Program {
      static void Main(string[] args) {
         var length = 10L;

         "Started for arrey length {0}:\n".wl(length);

         var rnd = new Random();
         var arr = new[] { 1, 5, 6, 7, 8, 0, 0, 2, 3, 4 };
         arr.wl();

         MergeSort.MergeDescending(arr, 0, 4, 5, 9);
         arr.wl();

         Console.ReadKey();
      }

      private static void TimeCalc() {
         var length = 8000L;
         "Started for arrey length {0}\n".wl(length);

         var rnd = new Random();
         var etalon = length.MakeArray<int>().Fill(() => rnd.Next(-1000, 1000));
         var array = length.MakeArray<int>();
         Func<int, int, bool> isSorted = (x1, x2) => { return x1 <= x2; };

         etalon.CopyTo(array, 0L);
         if (!array.IsSorted(isSorted)) {
            "start bubble sort.".wlStart();
            BubbleSort.CocktailSort(array, isSorted);
            if (!array.IsSorted(isSorted))
               "NOT SORTED".wlStop();
            else
               "sorted.".wlStop();
         }

         etalon.CopyTo(array, 0L);
         if (!array.IsSorted(isSorted)) {
            "start simple insertion sort.".wlStart();
            Insertion.Sort(array, isSorted);
            if (!array.IsSorted(isSorted))
               "NOT SORTED".wlStop();
            else
               "sorted.".wlStop();
         }

         etalon.CopyTo(array, 0L);
         if (!array.IsSorted(isSorted)) {
            "start simple selection sort.".wlStart();
            Selection.Sort(array, isSorted);
            if (!array.IsSorted(isSorted))
               "NOT SORTED".wlStop();
            else
               "sorted.".wlStop();
         }

         "\npress any key".wl();
         Console.ReadKey();
      }
   }
}
