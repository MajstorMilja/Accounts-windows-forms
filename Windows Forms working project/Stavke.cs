using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemam_Pojma_vise
{
    public class Stavke
    {
        public int StavkeId { get; set; }

        public int ProizvodId { get; set; }

        public int RacunId { get; set; }

        public string Naziv { get; set; }

        public int CenaStavke { get; set; }

        public int Kolicina { get; set; }
    }
}
