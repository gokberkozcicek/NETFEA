using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public abstract class FeElement
    {
        public int Id { get; set; }
        public int[] NodeIds { get; set; }
        public FeElement() { }
        public FeElement(int id, int[] nodeIds)
        {
            Id = id;
            NodeIds = nodeIds;
        }
    }
}
