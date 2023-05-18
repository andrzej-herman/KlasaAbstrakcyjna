using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstrakcyjne
{
    public abstract class Figura
    {
        public Figura(List<double> dlugosci)
        {
            Dlugosci = dlugosci;
        }
        public List<double> Dlugosci { get; set; }
        public double Pole { get; set; }
        public abstract void ObliczPole();
      
    }
}
