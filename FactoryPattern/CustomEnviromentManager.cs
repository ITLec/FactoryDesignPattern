using FactoryPattern.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{

    public class CustomEnviromentManager
    {
        static readonly Lazy<CustomEnviromentManager> instance = new Lazy<CustomEnviromentManager>(() => new CustomEnviromentManager());
        public static CustomEnviromentManager Instance { get { return instance.Value; } }


        readonly CustomEnviroment _customEnviroment;

        private CustomEnviromentManager()
        {
            _customEnviroment = CustomEnviromentFactory.Create();
        }


        public CustomEnviroment GetCustomEnviroment()
        {
            return _customEnviroment;
        }
        public void CustomAction()
        {
            Console.WriteLine(string.Format("Custom {0} Action", _customEnviroment.Title));
        }

        public void SetRAMSize(int ramSize)
        {
            this._customEnviroment.RAMSize = ramSize;
        }

        public void ResetCustomEnviroment()
        {
            _customEnviroment.RAMSize = CustomEnviromentFactory.Create().RAMSize;
        }
        
    }
}
