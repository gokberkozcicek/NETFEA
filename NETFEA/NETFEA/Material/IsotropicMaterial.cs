using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public class IsotropicMaterial:FeMaterial
    {
        public override MaterialType MaterialType { get; set; } = MaterialType.Isotropic;
        public double E { get; set; } = 200000;
        public double v { get; set; } = 0.3;
        public double G { get; set; }
        //Constructors
        public IsotropicMaterial() {
            SetShearModulus();
        }
        public IsotropicMaterial(double E,double v)
        {
            this.E = E;
            this.v = v;
            SetShearModulus();
        }
        private void SetShearModulus()
        {
            G = E / (2 * (1 + v));
        }
    }
}
