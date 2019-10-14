using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.MemoryManagement
{
    class MethodParameterTest
    {
        public void ValueTypeParameter()
        {
            int x = 5;
           
            AddFiveRef(ref x);
            
            Console.WriteLine(x);
        }

        public int AddFive(int pValue)
        {
            pValue += 5;

            return pValue;
        }

        public int AddFiveRef(ref int pValue)
        {
            pValue += 5;
            return pValue;
        }
    }

    struct StrTest
    {
        long q, w, e, r, t, y, u, ı, o, p, ğ, ü, a, s, d, f, g, h, j, k, l, ş, i, z, x, c, v, b, n, m, ö, ç,Q,W,E,R,T,Y,U,I,O,P,Ğ,Ü,A,S,D,F,G,H,J,K,L,Ş,İ,Z,X,C,V,B,N,M,Ö,Ç;
    }
}
