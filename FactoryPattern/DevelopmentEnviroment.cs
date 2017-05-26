using FactoryPattern.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{

    public class DevelopmentEnviroment : CustomEnviroment
    {
        public override string Title
        {
            get
            {
                return "Development";
            }
        }

        int ramSize = 16;
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
                return "TXT File";
            }
        }

        public override void DoSomething()
        {
            Console.WriteLine("Do something Development");
        }
    }
}
