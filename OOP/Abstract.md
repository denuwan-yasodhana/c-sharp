    // Can't create an object
    // No function body
    // Must be overridden in any non-abstract derived class
    // Static members can't be abstract


    namespace ConsoleApp
    {
      abstract class Vehicle
      {
        public abstract void speedUp();
        public abstract void gearUp();
      }
  
      class Car : Vehicle
      {
        public override void speedUp()
        {
         Console.WriteLine("This is how Car accelearating");
        }
        public override void gearUp()
        {
          Console.WriteLine("This is how Car change the Gears");
        }
      }
  
      class Bicycle : Vehicle
      {
        public override void speedUp()
        {
          Console.WriteLine("This is how Bicycle accelearating");
        }
        public override void gearUp()
        {
          Console.WriteLine("This is how Bicycle change the Gears");
        }
      }
  
      class Program
      {
        static void Main(string[] args)
        {
          // Vehicle A = new Vehicle(); - can not create objects
          Car c = new Car();
          c.speedUp();
          c.gearUp();
      
          Bicycle b = new Bicycle();
          b.speedUp();
          b.gearUp();
      
          Console.ReadKey();
        }
      }
    }
