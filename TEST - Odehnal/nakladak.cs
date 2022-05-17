using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST___Odehnal
{
    internal class nakladak
    {
        public int Jmeno { get; set; }
        public int MaximalniNosnost { get; set; }
        public int VelikostNadrze { get; }
        public int SpotrebaPaliva { get; }

        public int StavPaliva { get; set; }
        public int StavTachometr { get; set; }
        public int Naklad { get; }
        public nakladak()

        {
            Jmeno = 
            MaxNosnost = 400;
            VelikostNadrze = 150;
            SpotrebaPaliva = 40;
            Naklad = 0;
        }
        public void vylozit()
        {
            Naklad -= 400;
            if (Naklad < 0)
            {
                Naklad = 0;
            }

        }
        public void Nalozit()
        {
            Naklad += 400;
            if (Naklad < 0)
            {
                Naklad = 0;
            }

        }

    }
    
}
