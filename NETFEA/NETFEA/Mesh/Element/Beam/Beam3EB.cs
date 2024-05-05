using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFEA
{
    /// <summary>
    /// 3D Euler-Bernouilli Beam Element
    /// </summary>
    public class Beam3EB:FeElement
    {
        public override FeElementType ElementType { get; set; } = FeElementType.Beam3EB;
        // Constructors                                                                                                             
        public Beam3EB(int id, int[] nodeIds)
            : base(id, nodeIds)
        {
        }
       

    }
}
