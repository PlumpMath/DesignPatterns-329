using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace DesignPatterns.Singleton
{
    public class SingletonUsingSyncronization
    {
       private static SingletonUsingSyncronization Unique;

       private SingletonUsingSyncronization()
       {

       }

       [MethodImpl(MethodImplOptions.Synchronized)]
       public static SingletonUsingSyncronization GetInstance()
       {
           if (Unique == null)
           {
               Unique = new SingletonUsingSyncronization();
               return Unique;
           }
           else
               return Unique;
       }

       public void Description()
       {
           Console.WriteLine("Hey Buddy I am a Singleton Object which is syncronized using Syncronization");
       }
    }
}
