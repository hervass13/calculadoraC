using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora
{
    public class ClCalculadora
    {
        public int Sumar(int v1, int v2)
        {
            return (v1 + v2);
        }

        public long Multiplicar(long v1, long v2)
        {
            long result = 0;
            for (int i=0; i < v2;i++)
            {
                result += v1;
            }
            return result;
        }
    }
}
