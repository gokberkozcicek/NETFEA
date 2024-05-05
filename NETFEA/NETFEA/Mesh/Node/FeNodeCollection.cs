using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public class FeNodeCollection:Dictionary<int,FeNode>
    {
        public new void Add(int key,FeNode value)
        {
            base.Add(key, value);
        }
    }
}
