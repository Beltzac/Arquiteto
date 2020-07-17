using System;
using System.Collections.Generic;
using System.Text;

namespace Beltzac.Arquiteto.Modelos
{
    public class Pilar
    {
        public Pilar(int codPilar, double distanciaOrigem)
        {
            CodPilar = codPilar;
            DistanciaOrigem = distanciaOrigem;
        }
        public int CodPilar { get; set; }
        public double DistanciaOrigem { get; set; }
        public bool BaseReforcada { get; set; }
    }
}
