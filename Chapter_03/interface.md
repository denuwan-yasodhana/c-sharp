    namespace ConsoleApp3
    {
        interface IFinger
        {
            void setFinger(byte a);
            void matchFinger(byte a, byte b);
        }
    
        class Attendance : IFinger
        {
            public void setFinger (byte a)
            {
                Console.WriteLine("Finger Registered");
            }
            public void matchFinger(byte a, byte b)
            {
                Console.WriteLine("Finger Recognized");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                //  IFinger A = new IFinger(); // Cannot create an object of Interface
                Attendance att = new Attendance();
                att.setFinger(15);
                att.matchFinger(15, 15);
                Console.ReadKey();
            }
        }
    }



