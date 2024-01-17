    namespace ConsoleApplication1
    {
        class Program
        {
            static void Main(string[] args)
            {
                string line;
                using (StreamReader sr = new StreamReader("D:\\test.txt"))   // Read file content
                {
                    while ((line = sr.ReadLine()) != null)
                        Console.Write(line);
                    Console.ReadKey();
                }
            }
        }
    }

