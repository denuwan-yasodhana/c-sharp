    namespace ConsoleApplication1
    {
        class Student
        {
            string name = "Silva";
            int age = 25;
    
            public Student()                   // Default Constructor 
            {
                name = "Perera";
                age = 45;
                Console.WriteLine("Name is " + name);
                Console.WriteLine("Age is " + age);
            }
            
            public Student(string x, int y)     // Parametriazed Constructor 
            {
                name = x;
                age = y;
                Console.WriteLine("Name is " + name);
                Console.WriteLine("Age is " + age);
            }

            public Student(Student S)           // Copy Constructor 
            {
                name = S.name;
                age = S.age;
                Console.WriteLine("Name is " + name);
                Console.WriteLine("Age is " + age);
            }

            private Student(string a)           // Private Constructor 
            {
                name = a;           
                Console.WriteLine("Name is " + name);    
            }
          }

          class Program
          {
              static void Main(string[] args)
              {
                  Student S1 = new Student();          // Invoking Default Constructor
                  Student S2 = new Student("Wickarama", 66); // Invoking Parametrized Constructor
                  Student S3 = new Student(S1);        // Invoking Copy Constructor
                  Console.ReadKey();
              }
          }
    }


