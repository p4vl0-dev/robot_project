using System;
using System.Collections.Generic; //Here is List

namespace program_namespace{

   class main_class{

      public static void Main(){

         Bot bot = new Bot("Dave", 100, new byte[] {0, 1, 0});
         bot.Say_Hi();
         bot.Print_values();

         Bot bot2 = new Bot("Alex", 2300);

         bot2.Print_values();
         
         bot2.Jump();

         bot2.Say_Hi();
         
      }

   }
   
}