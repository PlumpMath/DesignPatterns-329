using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
   public class ClassicSingleton
    {
       // This code is not thread safe

       private static ClassicSingleton Unique;

       private ClassicSingleton()
       {

       }

       public static ClassicSingleton GetInstance()
       {
           if (Unique == null)
           {
               Unique = new ClassicSingleton();
               return Unique;
           }
           else
               return Unique;
       }

       public void Description()
       {
           Console.WriteLine("Hey Buddy I am a Classic Singleton Object");
       }

    }
}
