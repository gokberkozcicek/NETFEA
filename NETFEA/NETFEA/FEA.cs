using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    public class FEA
    {
        public MeshData MeshData { get; set; }=new MeshData();
        public FeMaterialCollection Materials { get; set; }=new FeMaterialCollection();
        public FeElementSectionCollection Sections { get; set; }=new FeElementSectionCollection();
        public bool Solve()
        {
            return false;
        }
    }
}
