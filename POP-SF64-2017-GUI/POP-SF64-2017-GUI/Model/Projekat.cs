using POP_31.Model;
using POP_SF64_2017_GUI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF64_2017_GUI.Model
{
    class Projekat
    {
        public Projekat Instance { get; private set; } = new Projekat();

        private List<Namestaj> namestaj = new List<Namestaj>();
        public List<Namestaj> Namestaj
        {
            get
            {
                this.namestaj = GenericSerializer.Deserialize<Namestaj>("namestaj.cml");
                return this.namestaj;
            }
            set
            {
                this.namestaj = value;
                GenericSerializer.Serialize<Namestaj>("namestaj.xml", value);
            }
        }
        //public List<TipNamestaja> TipoviNamestaja { get; set; }
        //public List<Namestaj> Namestaj { get; set; }
        //public List<TipNamestaja> TipoviNamestaja { get; set; }

        public Projekat()
        {
            Instance = new Projekat();
        }
    }
}
