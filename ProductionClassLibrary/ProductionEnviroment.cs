using FactoryPattern.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionClassLibrary
{

    public class ProductionEnviroment : CustomEnviroment
    {
        public override string Title
        {
            get
            {
                return "Production";
            }
        }
        int ramSize = 64;
        public override int RAMSize
        {
            get
            {
                return ramSize;
            }
            set
            {
                ramSize = value;
            }
        }

        public override string ConnectionString
        {
            get
            {
                return "SQL Connection DLL";
            }
        }

        public override void DoSomething()
        {
           // Console.WriteLine("Do something production");
        }
    }
}
