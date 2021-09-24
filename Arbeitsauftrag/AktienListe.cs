using System;
using System.Collections.Generic;

namespace Arbeitsauftrag
{
    public class AktienListe
    {
        public AktienListe()
        {
        }

        private List<Aktie> aktien = new List<Aktie>();

        public void AddAktie(Aktie aktie)
        {
            aktien.Add(aktie);
        }

        public void PrindAktienListe()
        {
            PrintAktienListe(DateTime.Today);
        }

        public void PrintAktienListe(DateTime stichtag)
        { 
            foreach (var aktie in aktien)
            {
                Console.WriteLine($"{aktie.Aktienmarkt} {aktie.Id} {aktie.Beschreibung} {aktie.GetAktienwertFuerDatum(stichtag)}{aktie.GetAktienwertFuerDatum(stichtag)}");
            }
        }

    }
}
