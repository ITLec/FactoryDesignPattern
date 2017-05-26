using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 0 to instanctiate Development Enviroment, or 1 for Production");

            var str = Console.ReadLine();
            if (str == "1")
            {
                Assembly myassembly = Assembly.LoadFrom("ProductionClassLibrary.dll");
                Type type = myassembly.GetType("ProductionClassLibrary.ProductionEnviroment");
                CustomEnviromentFactory.Create = () => (BOL.CustomEnviroment)Activator.CreateInstance(type);
            }
            else
            {
                CustomEnviromentFactory.Create = () => new DevelopmentEnviroment();
            }

            Console.WriteLine(string.Format("Enviroment Title: {0}, Connection String: {1}, Ram Size: {2}",
                CustomEnviromentManager.Instance.GetCustomEnviroment().Title,
                CustomEnviromentManager.Instance.GetCustomEnviroment().ConnectionString,
                CustomEnviromentManager.Instance.GetCustomEnviroment().RAMSize
                ));


            CustomEnviromentManager.Instance.GetCustomEnviroment().DoSomething();
            CustomEnviromentManager.Instance.CustomAction();


            Console.WriteLine("Enter New Ram size");


            var ramSize = Console.ReadLine();


            CustomEnviromentManager.Instance.SetRAMSize(int.Parse(ramSize));


            Console.WriteLine("The New Ram size= "+ CustomEnviromentManager.Instance.GetCustomEnviroment().RAMSize);
            Console.WriteLine("Enter 1 to reset the whole Enviroment");

            str = Console.ReadLine();

            if (str == "1")
            {
                CustomEnviromentManager.Instance.ResetCustomEnviroment();
            }

            Console.WriteLine(string.Format("Enviroment Title: {0}, Connection String: {1}, Ram Size: {2}",
            CustomEnviromentManager.Instance.GetCustomEnviroment().Title,
            CustomEnviromentManager.Instance.GetCustomEnviroment().ConnectionString,
            CustomEnviromentManager.Instance.GetCustomEnviroment().RAMSize
            ));

            Console.Read();
        }
        
    }
}
