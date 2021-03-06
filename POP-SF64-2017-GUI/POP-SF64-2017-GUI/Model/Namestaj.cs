﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_31.Model
{
    [Serializable]

    public class Namestaj
    {
        
        public int Id { get; set; }

        public string Naziv { get; set; }

        public string Sifra { get; set; }

        public double JedinicnaCena { get; set; }

        public int KolicinaUmagacinu { get; set; }

        public TipNamestaja TipNamestaja{ get; set; }

        public Akcija Akcija { get; set; }

         public bool Obrisan { get; set; }


    }

    public override string ToString()
    {
        return $"{ Naziv }, { Cena }";
    }
}
