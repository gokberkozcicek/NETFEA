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
        public virtual FeElementType ElementType { get; set; }
        public FeMaterial Material { get; set; }
        public FeElementSection Section { get; set; }
        //Constructors
        public FeElement() { }
        public FeElement(int id, int[] nodeIds)
        {
            Id = id;
            NodeIds = nodeIds;
        }
    }
    public enum FeElementType
    {
        Beam3EB
    }
}
