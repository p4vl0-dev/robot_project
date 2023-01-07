   using System;

namespace program_namespace{

   enum Type { Enemy, Hero, Traitor } // Объявлено в неймспейсе - значит доступно во всем неймспесе

   enum Colors {Red, Yellow, Blue}

   abstract class Robot : IRun, IJump  { // Abstract class - нельзя создать объекты этого класса

      protected string? surname; // Protected - доступно в родительском и дочернем классе, но к нему через объект класса нельзя обратиться
      
      public static int Count; //Static - доступно в классе main
      
      private string? name; //? знак cтавится, когда поле не допускает значение null (тоесть - если нулл, то пизда проге)
      
      private int weight; // Private - доступно только внутри самого класса
      
      private byte[] coordinates;
      
      public int variable_get_set{get; set;} // Get - получаем данные, Set - устанавливаем
      // Public variable, which i can use in child class (1)
      
      public float speed {get; set;}

      public float y {get; set;}

      public string? Name{
         get{
            return name;
         }    
         private set{}
      }

      //(2)
      public int Weight{
         get{
            return weight;
         }      
         private set{}
      }

      //(3)
      public byte[] Coordinates{    
         get{
            return coordinates;
         }
         private set{}
      }
      
      public Robot(){ //Это конструктор - срабатывает при создании объекта на основе данного класса
         Count++;
      }

      // Constructor of Robot class
      public Robot(string name, int weight, byte[] coordinates){
         this.Set_values(name, weight, coordinates); //This - в рамках класса помечается.
         System.Console.WriteLine(this.name + " object has been created");
         System.Console.WriteLine();
      }

      public Robot(string name, int weight){
         this.Set_values(name, weight); //This - в рамках класса помечается.
         System.Console.WriteLine(this.name + " object has been created");
         System.Console.WriteLine();
      }

      public Robot(string name){ //Тоже конструктор
         System.Console.WriteLine("Object is created");
         this.name = name;
         Count++;
      }

      //Method Set_values
      public void Set_values(string name, int weight, byte[] coordinates){
         this.name = name;
         this.weight = weight;
         this.coordinates = coordinates;
      }

      public void Set_values(string name, int weight){ //Перегрузка методов - когда один и тот же метод меняется, и при вызове имеет разные входные данные
         this.name = name;
         this.weight = weight;
      }

      public void Set_values(string name){ //Перегрузка методов - когда один и тот же метод меняется, и при вызове имеет разные входные данные
         this.name = name;
      }

      // Absract - нужен для полного переписывания метода с таким же именем, не реализовываем в классе родителе, но сто проц в дочерних
      // virtual - возможность использования и изменения под себя данного метода для объектов иного класса 
      public abstract void Print_values();

      public static void Print_count(){
         System.Console.WriteLine("Count is: " + Count); // this нельзя применять с статическим идентификатором
      }

      public void Robot_Run(){
         System.Console.WriteLine("Robot is now running");
      }

      public void Jump(){
         System.Console.WriteLine("Jumping");
      }
   }

}