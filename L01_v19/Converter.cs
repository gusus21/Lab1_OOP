using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_v19
{
    class Converter
    {
        float usd;
        float eur;

        public Converter(float usd_, float eur_)
        {
            usd = usd_;
            eur = eur_;
        }

        public float Vallet1 => usd;
        public float Vallet2 => eur;
    }
}
