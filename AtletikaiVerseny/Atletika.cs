using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtletikaiVerseny
{
    class Atletika
    {
        public string Rajtszam { get; private set; }
        public string VezNev { get; private set; }
        public string KerNev { get; private set; }
        public string Egyesulet { get; private set; }
        public int Ugras { get; private set; }
        public Atletika(string adatok)
        {
            string[] x = adatok.Split(';');

            Rajtszam = Convert.ToString(adatok[0]);
            VezNev = Convert.ToString(adatok[1]);
            KerNev = Convert.ToString(adatok[2]);
            Egyesulet = Convert.ToString(adatok[3]);
            Ugras = adatok[4];

        }
      

    }
}
