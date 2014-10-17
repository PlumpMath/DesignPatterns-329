using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns.Singleton
{
    public class StaticSingleton
    {
        //Using Thread safety 
        //Disadvantage : Singleton instance may be created even when not required
      private static StaticSingleton Unique = new StaticSingleton();

      private StaticSingleton()
       {

       }
      
      public static StaticSingleton GetInstance()
       {
           return Unique;
       }
      public void Description()
      {
          Console.WriteLine("Hey Buddy I am a static Singleton Object");
      }
    }
}
