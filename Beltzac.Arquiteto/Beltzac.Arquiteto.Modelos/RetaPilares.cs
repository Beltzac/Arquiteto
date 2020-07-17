using System;
using System.Collections.Generic;

namespace Beltzac.Arquiteto.Modelos
{
    public class RetaPilares
    {
        public RetaPilares(double tamanhoMetros)
        {
            TamanhoMetros = tamanhoMetros;
            Pilares = new List<Pilar>();
        }

        public double TamanhoVaoMetros { get; set; }
        public double TamanhoMetros { get; set; }
        public List<Pilar> Pilares { get; set; }
    }
}
