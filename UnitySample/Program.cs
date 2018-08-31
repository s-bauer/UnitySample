using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.RegistrationByConvention;

namespace UnitySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterTypes(
                AllClasses.FromAssemblies(Assembly.GetExecutingAssembly()),
                WithMappings.FromAllInterfaces,
                WithName.Default,
                WithLifetime.ContainerControlled
            );

            var sample = container.Resolve<ISample>();
            
            Console.WriteLine(sample is Sample);
            Console.ReadLine();
        }
    }

    public  interface ISample
    {

    }

    public class Sample : ISample
    {
    }
}
