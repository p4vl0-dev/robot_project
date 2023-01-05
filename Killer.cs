using System;
using System.Collections.Generic;

namespace program_namespace{

   class Killer : Robot, ISayHi{ //Наследование всего от класса Робот

      public int? Health{get; set;}

      public Killer(){}

      public Type type;

      public int integers;

      public Killer(string name, int weight, byte[] coordinates, int health, Type type) : base(name, weight, coordinates){ 
         this.Health = health; 
         this.type = type;
      }
      
      public override void Print_values(){ //Переписал метод Print_values для класса Killer, где Name, Weight и Coordinates - доступные переменные класса Robot
         System.Console.WriteLine("His name: " + base.Name + ", his weight: " + this.Weight);
         System.Console.WriteLine("Health: " + this.Health); // For virtual void

         if(this.type == Type.Enemy){
            System.Console.WriteLine("This is: " + type);
         }
         
      }
      
      public void Lazer(){
         System.Console.WriteLine("pew-pew"); 
         base.surname = "easy";
      }

      public void Say_Hi(){
         System.Console.WriteLine("Hello: " + this.Name + "!");
      }

      public static void Hello(){
         System.Console.WriteLine("Hello");
      }
      
   }
}