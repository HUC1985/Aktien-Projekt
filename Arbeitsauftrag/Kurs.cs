using System;
using System.Collections.Generic;

namespace Arbeitsauftrag
{
    public class Kurs
    {
        public Kurs(DateTime datum, decimal aktienkurs)
        {
            Datum = datum;
            Aktienkurs = aktienkurs;

        }
        public DateTime Datum { get; private set; }
        public Decimal Aktienkurs { get; private set; }

    }
}
