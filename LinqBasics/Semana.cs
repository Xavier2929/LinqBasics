using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    internal class Semana
    {
        private List<Dia> dias = new List<Dia>();

        public void agregarDia(Dia dia)
        {
            dias.Add(dia);
        }
        public List<Dia> devolverSemana()
        {
            return this.dias;
        }
    }
}
