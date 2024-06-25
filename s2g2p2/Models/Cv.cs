using System.Collections.Generic;

namespace s2g2p2.Models
{
    public class CV
    {
        public InformazioniPersonali InformazioniPersonali { get; set; }
        public List<Studi> StudiEffettuati { get; set; }
        public List<Impieghi> Impieghi { get; set; }
    }
}

