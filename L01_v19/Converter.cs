using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_v19
{
    class Converter
    {
        double usd;
        double eur;

        public Converter(double usd_, double eur_)
        {
            usd = usd_;
            eur = eur_;
        }

        public double Vallet1 => usd;
        public double Vallet2 => eur;
    }
}
