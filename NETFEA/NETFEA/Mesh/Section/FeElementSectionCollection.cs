using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public class FeElementSectionCollection:Dictionary<int,FeElementSection>
    {
        public new void Add(int key,FeElementSection value)
        {
            base.Add(key,value);
        }
    }
}
