using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuliniM.Core.Reflection
{
   /// <summary>
   /// Extension methods for reflection.
   /// </summary>
   public static class Extensions
   {
      /// <summary>
      /// It returns the value of the property with the provided name.
      /// </summary>
      /// <param name="obj">Object.</param>
      /// <param name="propertyName">Property name.</param>
      /// <returns></returns>
      public static object GetPropertyValue(this object obj, string propertyName)
      {
         return obj.GetPropertyValue(propertyName, null);
      }

      /// <summary>
      /// It returns the value of the property with the provided name.
      /// </summary>
      /// <param name="obj">Object.</param>
      /// <param name="propertyName">Property name.</param>
      /// <param name="indexes">Indexes.</param>
      /// <returns></returns>
      public static object GetPropertyValue(this object obj, string propertyName, object[] indexes)
      {
         var objectType = obj.GetType();
         var property = objectType.GetProperty(propertyName);
         return property.GetValue(obj, indexes);
      }
   }
}
