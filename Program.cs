using System;
using dll_add_multiply;
namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            Console.ReadLine();
            Add file = new Add();
            int ans = file.Add_(5, 6);

            Console.WriteLine(ans);
            
            


            

            
        }
    }
}
