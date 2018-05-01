using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GiuliniM.Core;
using GiuliniM.Core.Diagnostics;
using GiuliniM.Core.Reflection;

namespace GiuliniM.Tests.Reflection
{
   [TestClass]
   public class ExtensionsTest
   {
      [TestMethod]
      public void Measure_get_property_value_by_reflection()
      {
         // object with some plain values.
         var dummyObject = new {
            text = "hello",
            num = 23.34,
            when = DateTime.UtcNow
         };
         object wrapper = dummyObject as object;
         // Act
         var timer = Stopwatch.StartNew();
         var getTimings = new List<TimeSpan>();
         var reflectionTimings = new List<TimeSpan>();
         var iterations = 10000;
         for (int i = 0; i < iterations; i++)
         {
            getTimings.Add(timer.Time(() =>
            {
               var foo = dummyObject.text;
            }));
            reflectionTimings.Add(timer.Time(() =>
            {
               var anonymousType = wrapper.GetType();
               var property = anonymousType.GetProperty("text");
               var textValue = property.GetValue(wrapper);
            }));
         }
         var avgGet = getTimings.Average(t => t.TotalMilliseconds);
         var avgReflection = reflectionTimings.Average(t => t.TotalMilliseconds);
         Assert.IsTrue(avgGet < avgReflection, "Standard get slower than reflection!");
         //Assert.AreEqual(dummyObject.text, textValue, "Text content is different.");

      }

      [TestMethod]
      public void Get_property_value()
      {
         // object with some plain values.
         var dummyObject = new
         {
            text = "hello",
            num = 23.34,
            when = DateTime.UtcNow
         };
         object wrapper = dummyObject as object;
         // Act
         var textValue = wrapper.GetPropertyValue(nameof(dummyObject.text));
         Assert.AreEqual(dummyObject.text, textValue, "Text is different.");
         var numberValue = wrapper.GetPropertyValue(nameof(dummyObject.num));
         Assert.AreEqual(dummyObject.num, numberValue, "Number is different.");
         var dateValue = wrapper.GetPropertyValue(nameof(dummyObject.when));
         Assert.AreEqual(dummyObject.when, dateValue, "Date is different.");
      }
   }
}
