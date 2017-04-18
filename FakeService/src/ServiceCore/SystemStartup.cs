using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ServiceCore
{
    public class SystemStartup
    {
        public SystemStartup()
        {
            
        }
        public static List<ProcesserBaseInteface> _lp = new List<ProcesserBaseInteface>();
        public static void Init()
        {
            var assembly = Assembly.Load(new AssemblyName("FakeService"));
            foreach (var type in assembly.GetTypes())
            {
                if (type.GetInterfaces().Contains(typeof(ProcesserBaseInteface)))
                {
                    var model = Activator.CreateInstance(type) as ProcesserBaseInteface;
                    if (model != null && !_lp.Contains(model))
                    {
                        _lp.Add(model);
                    }
                }
            }
        }
    }
}
