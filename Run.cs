using System;

namespace program_namespace{

   interface IRun{ // Это тот же класс, только объявляет поля и методы, а в классах наследниках их реализует, без использования абстрактных методов

      float speed{get; set;} //Не нужны модификаторы доступа

      void Robot_Run();

   }

}