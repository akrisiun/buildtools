using System;
using System.Diagnostics;

namespace coreApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello world");


            if (Debugger.IsAttached)
                Debugger.Launch();
            Debugger.Break();

            try
            {
                Tests.Test1();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    }

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }

    public static class Tests
    {
        public static void Test1()
        {
            Type t = System.Type.GetType("Microsoft.DotNet.Build.Tasks.VersionTools.UpdateDependencies");
            var task = new Microsoft.DotNet.Build.Tasks.VersionTools.UpdateDependencies();
            task.Execute();
        }
    }

}