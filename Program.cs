﻿using System;
using System.Collections.Generic; //Here is List

namespace program_namespace{

   class main_class : Bot{

      public static void Main(){

         Bot bot = new Bot("Dave", 100, new byte[] {0, 1, 0});
         bot.Say_Hi();
         bot.Print_values();

         Bot bot2 = new Bot("Alex", 2300);

         bot2.Print_values();
         bot2.Jump();
         bot2.Say_Hi();

         Killer killer_bot = new Killer("Ted", 120, new byte[] {0, 0 , 0}, 200, Type.Enemy);
         killer_bot.Say_Hi();
         System.Console.WriteLine(killer_bot.Name);

         Say_Bye(); // Static void from Bot class

      }

   }
   
}