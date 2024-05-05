using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public class BeamSection : FeElementSection
    {
        public double Area { get; set; }
        public double Ix { get; set; }
        public double Iy { get; set; }
        public double Iz { get; set; }
        public override SectionGroupType SectionGroupType { get; set; } = SectionGroupType.Beam;
        public override SectionType SectionType { get; set; } = SectionType.Generic;

    }
}
