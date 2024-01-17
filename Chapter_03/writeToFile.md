    namespace ConsoleApplication1
    {  
        class Program
        {
            static void Main(string[] args)
            {
                string[] file = new string[] { "Hi this is how you write to the File" };   // Write this content
                using (StreamWriter sw = new StreamWriter("D:\\test.txt"))
                {
                    foreach (string s in file)
                    {
                        sw.WriteLine(s);
                    }
                }
                Console.ReadKey();
            }
        }
    }

