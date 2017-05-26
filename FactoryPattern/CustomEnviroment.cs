using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class CustomEnviroment
    {
        public abstract string Title { get; }
        public abstract string ConnectionString { get; }

        public abstract int RAMSize { get; set; }

        public abstract  void DoSomething();
    }
}
