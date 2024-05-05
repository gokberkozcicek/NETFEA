using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public class CircularSolidSection : BeamSection
    {
        public override SectionGroupType SectionGroupType { get; set; } = SectionGroupType.Beam;
        public override SectionType SectionType { get; set; } = SectionType.CircularSolid;
        public double Diameter { get; set; }
        public CircularSolidSection(double diameter)
        {
            Diameter = diameter;
            SetCircularSolidSection();
        }
        
        private void SetCircularSolidSection()
        {
            Area = Math.PI * Math.Pow(Diameter, 4);
            double inertia = Math.PI*Math.Pow(Diameter, 4) / 64;
            Ix = inertia;
            Iy = inertia;
            Iz = inertia;
        }

    }
}
