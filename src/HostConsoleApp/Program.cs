using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace HostConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();

            System.Console.ReadLine();
        }

        public static void Run()
        {
            try
            {
                InterfaceAssembly.ITestReference testReference = CreateTestReference();

                InterfaceAssembly.TestRequest request = new InterfaceAssembly.TestRequest() { Information = string.Format("I am about to send in the request from class: [{0}]", typeof(Program).FullName) };
                System.Console.WriteLine(testReference.DoSomething(request).Information);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        public static InterfaceAssembly.ITestReference CreateTestReference()
        {
            System.Console.WriteLine("Getting Configuration");
            var config = GetConfiguration();

            System.Console.WriteLine("Creating implementation via assembly");
            var testReference = CreateITestReferenceInstance(config.GetValue<string>("impl:assembly"), config.GetValue<string>("impl:class"));
            return testReference;
        }

        public static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()                          
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            return builder.Build();

        }

        public static InterfaceAssembly.ITestReference CreateITestReferenceInstance(string assemblyPath, string className)
        {
            InterfaceAssembly.ITestReference testReferenceImpl = null;
            string assemblyLocation = System.IO.Path.GetFullPath(assemblyPath);
            try
            {

                Assembly assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(
                    Regex.Replace(assemblyLocation, "^file:(/+)?", ""));
                Type type = assembly.GetType(className);
                var testRefereceCreated = Activator.CreateInstance(type);
                testReferenceImpl = testRefereceCreated as InterfaceAssembly.ITestReference;
            }
            catch (Exception e)
            {
                var msg = string.Format(
                    "Unable to load assembly or type. A: {0}, T: {1}. Error: {2}"
                    , assemblyLocation
                    , className, e.Message);

                throw new Exception(msg, e);
            }

            return testReferenceImpl;
        }
    }
    
}
