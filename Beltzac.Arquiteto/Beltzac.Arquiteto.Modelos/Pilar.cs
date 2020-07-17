using System;
using System.Collections.Generic;
using System.Text;

namespace Beltzac.Arquiteto.Modelos
{
    public class Pilar
    {
        public Pilar(double distanciaOrigem)
        {
            DistanciaOrigem = distanciaOrigem;
        }

        public double DistanciaOrigem { get; set; }
        public bool BaseReforcada { get; set; }
    }
}
