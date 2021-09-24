using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Arbeitsauftrag
{
    class AktienListeBuilder
    {
        string _path;
        public AktienListe Builder(string path)
        {

            if (string.IsNullOrEmpty(_path))
            { 
                throw new ArgumentException("Pfad erforderlich");
            }

            _path = path;

                string[] lines = File.ReadAllLines("Aktienkurse.txt");

            int lineNumber = 0;
            var aktienListe = new AktienListe
            {

            };

            foreach (var line in lines)
            {
                lineNumber++;
                if (lineNumber == 1)
                    continue;
                {
                    DateTime datum;
                    object markt;
                    decimal wert;


                    var lineItems = line.Split(";");
                    // id
                    string id = lineItems[0];

                    //Datum
                    if (!DateTime.TryParseExact(lineItems[1], "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum));
                    throw new Exception($"Wert {lineItems[1]} kann nicht in ein Datum konvertiert werden");

                    // Markt
                    if (!Enum.TryParse(typeof(Aktienmaerkte), lineItems[2], out markt))
                    
                        throw new Exception($"Ungültiger Aktienmarkt {lineItems[2]}");
                    


                    // Symbol
                    string symbol = lineItems[3];

                    //Name
                    string name = lineItems[4];

                    // Aktienwert
                    if (!Decimal.TryParse(lineItems[5], out wert))
                        throw new Exception($"Wert {lineItems[5]} kann nicht in ein Decimal konvertiert werden.");

                    var kurs = new Kurs(datum, wert);
                    var myAktie = new Aktie(markt, symbol, symbol);

                    myAktie.AddKurs(kurs);

                    aktienListe.AddAktie(myAktie);
                }
            }
            return aktienListe;
        }

    }
}

