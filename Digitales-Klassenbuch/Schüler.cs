using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitales_Klassenbuch
{
    class Schüler
    {
        private string vorname;
        private string nachname;
        private DateTime geburtsdatum;
        private bool attestpflicht;

        public string Vorname
        {
            get { return vorname; }
        }

        public string Nachname
        {
            get { return nachname; }
        }

        public DateTime Geburtsdatum
        {
            get { return geburtsdatum; }
        }



    }
}
