    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp
    {
      class Father
      {
        public string surname = "Perera";                   // Anyone can access
        protected string carmodel = "Toyota";               // Only child can access
        string designation = "Director";                    // Noone can access
      }
  
      class Child:Father
      {
        public string name = "Gayan";
        public string degree = "IT";
    
        public void display()
        {
         Console.WriteLine("Car Model is " + carmodel);        // private variable cannot access
        }
      }
  
      class Program
      {
        static void Main(string[] args)
        {
          Child c = new Child();
          Console.WriteLine("Name is " + c.name);
          Console.WriteLine("Surname is " + c.surname);
      
          Father f = new Father();
          Console.WriteLine("Surname is " + f.surname);
          // Console.WriteLine("Degree is " + f.degree); - Cannot access child variables
          Console.ReadKey();
        }
      }
  
    }
