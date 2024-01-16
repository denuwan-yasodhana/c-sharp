

    namespace ConsoleApplication1
    {
        static class Bicycle
        {
            static int speed = 150;                //Static Fields
            static int gear = 4;                   //Static Fields
            static string name = "Mountant Bike";  //Static Fields
    
            public static void speedUp()           //Static Methods
            {
                speed = speed + 50;
                Console.WriteLine("Speed is " + speed);
            }
    
            public static void speedDown()         //Static Methods
            {
                speed = speed - 70;
                Console.WriteLine("Speed is " + speed);
            }
        }
    
        class Program
        {
            static void Main(string[] args)
            {
                // Bicycle bike = new Bicycle();  Cannot create a instance of a Static Class         
                Bicycle.speedUp();                 // Must use the class name to access the Methods
                Bicycle.speedDown();
                Console.ReadKey();
            }
        }

    }
