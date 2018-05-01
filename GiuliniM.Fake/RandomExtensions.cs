using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuliniM.Fake
{
   /// <summary>
   /// Extension methods for standard Random class.
   /// </summary>
   public static class RandomExtensions
   {
      /// <summary>
      /// It returns several random integers, not negative.
      /// </summary>
      /// <param name="random">Random instance.</param>
      /// <param name="count">Number of values.</param>
      /// <returns></returns>
      public static IEnumerable<int> NextMany(this Random random, int count)
      {
         for (int i = 0; i < count; i++)
         {
            yield return random.Next();
         }
      }

      /// <summary>
      /// It returns several random integers, not negative.
      /// </summary>
      /// <param name="random">Random instance.</param>
      /// <param name="maxValue">Maximum value.</param>
      /// <param name="count">Number of values.</param>
      /// <returns></returns>
      public static IEnumerable<int> NextMany(this Random random, int maxValue, int count)
      {
         for (int i = 0; i < count; i++)
         {
            yield return random.Next(maxValue);
         }
      }

      /// <summary>
      /// It returns several random integers, not negative.
      /// </summary>
      /// <param name="random">Random instance.</param>
      /// <param name="minValue">Minimum value.</param>
      /// <param name="maxValue">Maximum value.</param>
      /// <param name="count">Number of values.</param>
      /// <returns></returns>
      public static IEnumerable<int> NextMany(this Random random, int minValue, int maxValue, int count)
      {
         for (int i = 0; i < count; i++)
         {
            yield return random.Next(minValue, maxValue);
         }
      }
   }
}
