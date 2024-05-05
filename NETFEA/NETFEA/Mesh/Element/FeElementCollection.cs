using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public class FeElementCollection:Dictionary<int, FeElement>
    {
        public new void Add(int key, FeElement value)
        {
            base.Add(key, value);
        }
    }
}
