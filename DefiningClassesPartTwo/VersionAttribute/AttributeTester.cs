using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{

    [VersionAttribute(11, 2)]

    class AttributeTester
    {
        static void Main()
        {
            Type type = typeof(AttributeTester);
            var allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in allAttributes)
            {
                Console.WriteLine("Version {0}", item.Version);
            }
        }
    }
}
