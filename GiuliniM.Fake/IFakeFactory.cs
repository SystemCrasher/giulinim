using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuliniM.Fake
{
   /// <summary>
   /// Abstract factory for fake items (classes, interfaces, etc...).
   /// </summary>
   interface IFakeFactory
   {
      /// <summary>
      /// It returns a fake instance of type T.
      /// </summary>
      /// <typeparam name="T">Type.</typeparam>
      /// <returns></returns>
      T Fake<T>();
   }
}
