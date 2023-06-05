    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp
    {
      class Sample
      {
        public void add(int a, int b)
        {
          int ans = a+b;
          Console.WriteLine("Answer is " + ans);
        }
    
        public void add(int a, int b, int c)
        {
          int ans = a+b+c;
          Console.WriteLine("Answer is " + ans);
        }
      }
  
      class Program
      {
        static void Main(string[] args)
        {
          Sample s1 = new Sample();
          s1.add(10, 20);
          s1.add(10, 20, 30);
          Console.ReadKey();
        }
      }
    }
