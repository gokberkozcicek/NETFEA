using MathNet.Numerics.LinearAlgebra;
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
        public double Length { get; set; }
        public override FeElementType ElementType { get; set; } = FeElementType.Beam3EB;
        // Constructors                                                                                                             
        public Beam3EB(int id, int[] nodeIds)
            : base(id, nodeIds)
        {
        }

        public override Matrix<double> Ke()
        {
            double[,] ke = new double[12,12];
            if (Material.MaterialType.Equals(MaterialType.Isotropic))
            {
                ke = IsotropicKe();
            }
            else if (Material.MaterialType.Equals(MaterialType.Orthotropic))
            {
                ke = OrthotropicKe();
            }
            else
            {
                ke = IsotropicKe();
            }
            Matrix<double> stiffnessMatrix = Matrix<double>.Build.DenseOfArray(ke);
            return stiffnessMatrix;
        }
        private double[,] IsotropicKe()
        {
            return new double[12, 12];
        }
        private double[,] OrthotropicKe()
        {
            return new double[12, 12];
        }
    }
}
