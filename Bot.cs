using System;
using System.Collections.Generic;

namespace program_namespace{
   
   class Bot : Robot, ISayHi{ //Наследование всего от класса Робот

      // var a  - Нельзя объявлять поля неявного типа вне методов или скриптов

      public Type type;
      
      public Colors color;

      public Bot(){}

      public Bot(Type type){
         this.type = type;
      }

      public Bot(string name, int weight) : base(name, weight){
         base.Set_values(name, weight);
      }

      public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates){
         base.Set_values(name, weight, coordinates);
      }

      public void Say_Hi(){
         System.Console.WriteLine("Hello: " + this.Name + "!");
      }

      public override void Print_values(){ // Overrided void from abstract void Print_values from class Robot

         System.Console.WriteLine("His name: " + base.Name + ", his weight: " + base.Weight);

         if(this.Coordinates != null){

            System.Console.Write("Coordinates: ");

            foreach(byte element in this.Coordinates){
               System.Console.Write(element);
               System.Console.Write(" ");
            }

            System.Console.WriteLine();
            System.Console.WriteLine();

         } else System.Console.WriteLine("No coordinates");
         
      }

      public void Get_Color(Bot bot){
         if(bot.type == Type.Enemy){
            this.color = Colors.Red;
         } else this.color = Colors.Yellow;
         System.Console.WriteLine("Bot color: " + bot.color);
      }

      public static void Say_Bye(){
         System.Console.WriteLine("Goodbye!");
      }

   }

}