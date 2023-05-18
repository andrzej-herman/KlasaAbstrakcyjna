using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstrakcyjne
{
    internal class Prostokat : Figura
    {
        public Prostokat(List<double> dlugosci) : base(dlugosci)
        {
        }

        public override void ObliczPole()
        {
            Pole = Dlugosci[0] * Dlugosci[1];
        }
    }
}
