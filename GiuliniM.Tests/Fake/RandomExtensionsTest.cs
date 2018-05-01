using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GiuliniM.Fake;

namespace GiuliniM.Tests.Fake
{
   [TestClass]
   public class RandomExtensionsTest
   {
      [TestMethod]
      public void It_should_get_random_integers()
      {
         var random = new Random(45);
         int minValue = 50;
         int maxValue = 100;
         int count = 500;
         // Overload 1.
         var items = random.NextMany(count);
         Assert.IsTrue(items.Any(), "There are no elements.");
         // Overload 2.
         items = random.NextMany(maxValue, count);
         Assert.IsTrue(items.Any(), "There are no elements.");
         Assert.IsTrue(items.All(v => v <= maxValue), "There are elements higher than max value.");
         // Overload 3.
         items = random.NextMany(minValue, maxValue, count);
         Assert.IsTrue(items.Any(), "There are no elements.");
         Assert.IsTrue(items.All(v => v <= maxValue), "There are elements higher than max value.");
         Assert.IsTrue(items.All(v => v >= minValue), "There are elements lower than min value.");
      }
   }
}
