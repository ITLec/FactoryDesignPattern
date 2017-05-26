using FactoryPattern.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class CustomEnviromentFactory
    {
        public static Func<CustomEnviroment> Create { get; set; }
    }
}
