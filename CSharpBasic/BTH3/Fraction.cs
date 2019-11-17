using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH3
{
    class Fraction
    {
        private int numer;

        public int Numer
        {
            get { return numer; }
            set { numer = value; }
        }
        private int denom;

        public int Denom
        {
            get { return denom; }
            set { denom = value; }
        }

        public Fraction(int numer, int denom)
        {
            this.numer = numer;
            this.denom = denom;
        }

        public Fraction()
        {
        }

        public int comMax(int a, int b)
        {
            if (a == 0) if (b == 0) return 0; else return b;
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a;
        }
        public void simplify()
        {
            int cm = comMax(numer, denom);
            numer /= cm;
            denom /= cm;
        }
        public Fraction plus(Fraction fra)
        {
            Fraction res = new Fraction();
            res.numer = numer * fra.denom + fra.numer * denom;
            res.denom = denom * fra.denom;
            res.simplify();
            return res;
        }
        public Fraction multiply(Fraction fra)
        {
            Fraction res = new Fraction();
            res.numer = numer * fra.numer;
            res.denom = denom * fra.denom;
            res.simplify();
            return res;
        }
        public override string ToString()
        {
            if (numer < 0 && denom < 0)
            {
                numer = Math.Abs(numer);
                denom = Math.Abs(denom);
            }
            if (numer > 0 && denom < 0)
            {
                numer = -numer;
                denom = Math.Abs(denom);
            }
            return String.Format(" [{0}/{1}] ", numer, numer==0?0: denom);
        }
    }
}
