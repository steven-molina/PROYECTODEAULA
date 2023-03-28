using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Instrumento
    {

        public String Tipo { get; set; }
        public String Referencia { get; set; }
        public String NroDeSerie { get; set; }
        public Instrumento()
        {

        }
        public Instrumento(String tipo, String referencia, String nroDeSerie)
        {

            this.Tipo = tipo;
            this.Referencia = referencia;
            this.NroDeSerie = nroDeSerie; 

        }


    }
}
