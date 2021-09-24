using System;
using System.Collections.Generic;
using System.Linq;

namespace Arbeitsauftrag
{
   public class Aktie
    {
        private List<Kurs> kurse = new List<Kurs>();
        public Aktie(Aktienmaerkte aktienmarkt,string id, string beschreibung)
        {
            Aktienmarkt = aktienmarkt;
            Id = id;
            Beschreibung = beschreibung;
        }
        public Aktienmaerkte Aktienmarkt { get; private set; }
        public string Id { get; private set; }
        public string Beschreibung { get; private set; }

        public void AddKurs(Kurs kurs)
        {
            kurse.Add(kurs);
        }
        //für Test 
        public decimal GetAktienwertFuerDatum(DateTime stichtag)
        {
            var gueltigerKurs = kurse
                .Where(k => k.Datum <= stichtag)
                .OrderBy(k => k.Datum)
                .LastOrDefault();

            if (gueltigerKurs == null)
                throw new Exception($"kein Gültiger Kurs für Datum {stichtag} vorhanden");

            return gueltigerKurs.Aktienkurs;
       
        }


   }

}

