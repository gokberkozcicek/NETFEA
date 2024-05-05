using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public abstract class FeMaterial
    {
        public int Id {  get; set; }
        public FeMaterial() { }
        public virtual MaterialType MaterialType { get; set; }
    }
    public enum MaterialType
    {
        Isotropic,
        Orthotropic
    }
}
