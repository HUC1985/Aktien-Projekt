using System;
using System.Globalization;
using System.IO;

namespace Arbeitsauftrag
{
    class Program
    {
        static void Main(string[] args)
        {


            var aktienListeBuilder = new AktienListeBuilder("Aktienkurse.txt");
            var aktienListe = AktienListe Build();


            aktienListe.PrintAktienListe(new DateTime(2020, 05, 06));

            
            while (true)
            {

                Console.WriteLine("Bitte Aktion auswählen");
                Console.WriteLine("A: Aktie einlesen");
                Console.WriteLine("B: Aktieliste ausgeben");

                Console.WriteLine("E: ENDE");



                    var auswahl = Console.ReadLine().ToUpper();
                    Console.Clear();

                    switch (auswahl)
                    {

                    //Auswahlmöglichkeiten
                        case "A":
                            Console.WriteLine("A ausgewählt");
                            break;

                        case "B":
                            Console.WriteLine("Für welches Datum soll die Liste ausgegeben werden?");
                        CalendarWeekRule datumEingabe = Console.ReadLine();
                        if (!DateTime.TryParseExact(datumEingabe, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime strichtag))
                        {

                        }
                        else
                        {
                            Console.WriteLine("Ungültiges Datum");
                        }
                            break;

                        //Schlaufe verlassen mit Return
                        case "E":
                            Console.WriteLine("ENDE");
                            return;

                        // keine Übereinstimmung der Auswahl
                        default:
                            Console.WriteLine("Ungültige Auswahl");
                            break;
                    }
                Console.WriteLine("Weiter mit Tastendruck");
                Console.ReadKey();
            
            }
        
        }

    }

}
