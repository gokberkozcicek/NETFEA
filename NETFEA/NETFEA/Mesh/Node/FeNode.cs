using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public class FeNode
    {
        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public FeNode() { }
        public FeNode(int id, double x, double y, double z)
        {
            Id = id;
            X = x;
            Y = y;
            Z = z;
        }
    }
}
