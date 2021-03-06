﻿using POP_SF64_2017_GUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_31.Model
{
    [Serializable]

    public  class TipNamestaja
    {

        public int Id { get; set; }

        public string Naziv { get; set; }

        public TipNamestaja(int Id,string Naziv,bool Obrisan)
        {
            this.Id = Id;
            this.Naziv = Naziv;
            this.Obrisan = Obrisan;
        }

        public static TipNamestaja GetById(int id)
        {
            foreach (var tipNamestaja in Projekat.Instance.TipoviNamestaja)
            {
                if(tipNamestaja.Id == id)
                {
                    return tipNamestaja;
                }
            } return null;
        }

        public bool Obrisan { get; set; }
    }
}
