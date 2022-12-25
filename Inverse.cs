using Matrices;
using matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static matrix.InverseMatrix;

namespace matrix
{
    //InverseMatrix явл наследником только SquareMatrix
    //protected доступен в наследнике наследника
    internal class InverseMatrix : SquareMatrix
    {
        public InverseMatrix(SquareMatrix m) : base(m)
        {
                if (m.Det() != 0)
                {
                    this.N = m.N;
                    this.M = m.M;
                    this.Matrix = m.Matrix;
                }
        }
            public InverseMatrix(Matr m) : base(m)
            {
                if (m.N == m.M)
                {
                SquareMatrix a = new SquareMatrix(m);
                    if (a.Det() != 0)
                    {
                        this.N = m.N;
                        this.M = m.M;
                        this.Matrix = m.Matrix;
                    }
                }
            }

            public static InverseMatrix Cop(InverseMatrix A)
            {
                return A;
            }
            public InverseMatrix Inverce()
            {
            InverseMatrix Copy = new InverseMatrix(new Matr(this.N, this.M, true));
                for (int i = 0; i < this.N; i++)
                {
                    for (int j = 0; j < this.M; j++)
                    {
                        Copy.Matrix[j, i] = this.Minor(i, j).Det() * Math.Pow(-1, i + j);
                    }
                }
                Matr S = Copy / this.Det();
            InverseMatrix SS = new InverseMatrix(S);
                return SS;

            }
        }
    }
}
}
