using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public class OrthotropicMaterial:FeMaterial
    {
        public double Ex { get; set; }
        public double Ey { get; set; }
        public double Ez { get; set; }
        public double Vxy { get; set; }
        public double Vyz { get; set; }
        public double Vxz { get; set; }
        public double Gxy { get; set; }
        public double Gyz { get; set; }
        public double Gxz { get; set; }
        public OrthotropicMaterial(double ex, double ey, double ez, double vxy, double vyz, double vxz, double gxy, double gyz, double gxz)
        {
            Ex = ex;
            Ey = ey;
            Ez = ez;
            Vxy = vxy;
            Vyz = vyz;
            Vxz = vxz;
            Gxy = gxy;
            Gyz = gyz;
            Gxz = gxz;
        }
    }
}
