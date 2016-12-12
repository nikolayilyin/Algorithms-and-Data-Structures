﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsDataStructures.Extensions;

namespace AlgorithmsDataStructures.Sorting {
   public static class MergeSort {
      private static void SortDescendingInternal<T>(T[] array, int start, int end) where T : IComparable {
         if (end - start <= 1)
            return;

         var middle = start + (end - start) / 2;
         SortDescendingInternal(array, start, middle);
         SortDescendingInternal(array, middle, end);

         MergeDescending(array, start, middle, middle, end);
      }

      public static void MergeDescending<T>(T[] array, int start1, int end1, int start2, int end2) where T : IComparable {
         int i1 = start1;
         int i2 = start2;
         int t = 0;

         var tmplength = end1 - start1;
         var tmparr = new T[tmplength];

         Array.Copy(array, start1, tmparr, 0, tmplength);

         while (t < tmplength && i2 < end2) {
            if (tmparr[t].CompareTo(array[i2]) > 0) {
               array[i1] = array[i2];
               i2++;
            }
            else {
               array[i1] = tmparr[t];
               t++;
            }
            i1++;
         }

         if (t < tmplength)
            Array.Copy(tmparr, t, array, i1, tmplength - t);
      }

      public static void SortDescending<T>(T[] array) where T : IComparable {
         SortDescendingInternal(array, 0, array.Length);
      }
   }
}
