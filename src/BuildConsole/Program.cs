using Microsoft.DotNet.Build.Tasks.VersionTools;
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


            Type t = System.Type.GetType("Microsoft.DotNet.Build.Tasks.VersionTools.UpdateDependencies");
            var task = new UpdateDependencies();
            task.Execute();

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}