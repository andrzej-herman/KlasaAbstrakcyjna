using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstrakcyjne
{
    internal class Okrag : Figura
    {
        public Okrag(List<double> dlugosci) : base(dlugosci)
        {
        }

        public override void ObliczPole()
        {
            Pole = Math.PI * Dlugosci[0] * Dlugosci[0];
        }
    }
}
