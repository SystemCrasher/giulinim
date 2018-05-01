using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuliniM.Fake
{
   /// <summary>
   /// Factory for fake items (classes, interfaces, etc...).
   /// </summary>
   public class FakeFactory : IFakeFactory
   {
      /// <summary>
      /// It returns a fake instance of type T.
      /// </summary>
      /// <typeparam name="T">Type or interface.</typeparam>
      /// <returns></returns>
      public T Fake<T>()
      {
         //// Determines whether it is a class, value type or an interface.
         //var type = typeof(T);
         //if (type.IsInterface)
         //{
         //   var classType = this.CreateClassImplementingInterface<T>();
         //}
         return default(T);
      }

      //private I CreateClassImplementingInterface<I>()
      //{

      //}
   }
}
