using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuliniM.Core.Diagnostics
{
   /// <summary>
   /// Extension methods for Stopwatch.
   /// </summary>
   public static class StopwatchExtensions
   {
      /// <summary>
      /// Time an action.
      /// </summary>
      /// <param name="stopwatch">Stopwatch instance.</param>
      /// <param name="toTime">Action.</param>
      /// <returns></returns>
      public static TimeSpan Time(this Stopwatch stopwatch, Action toTime)
      {
         stopwatch.Reset();
         stopwatch.Start();
         toTime();
         stopwatch.Stop();
         return stopwatch.Elapsed;
      }
   }
}
