    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp
    {
      class Bicycle
      {
        int speed = 0;
        int gear = 1;
        string name = "Discovery";
    
        public void speedUp(int a)
        {
          speed = speed + 50;
          Console.WriteLine("Speed is "+ speed);
        }
    
        public void speedDown()
        {
          speed = speed - 70;
          Console.WriteLine("Speed is "+ speed);
        }
      }
  
      class Program
      {
        static void Main(string[] args)
        {
          Bicycle bike = new Bicycle();
          bike.speedUp(40);
          bike.speedDown();
          Console.ReadKey();
        }
      }
    }
