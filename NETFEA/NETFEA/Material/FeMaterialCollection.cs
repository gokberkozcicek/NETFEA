using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public class FeMaterialCollection:Dictionary<int,FeMaterial>
    {
        public new void Add(int key,FeMaterial value) {  base.Add(key, value); }
    }
}
