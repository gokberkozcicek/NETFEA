using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public abstract class FeElementSection
    {
        public int Id { get; set; }
        public abstract SectionGroupType SectionGroupType { get; set; }
        public abstract SectionType SectionType { get; set; }
    }
    public enum SectionGroupType
    {
        Beam,
        Surface,
        Solid,
        Spring
    }
    public enum SectionType
    {
        Generic,
        CircularSolid,
        CircularHollow
    }
}
