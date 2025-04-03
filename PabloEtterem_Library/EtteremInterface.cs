using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabloEtterem_Library
{
    internal interface EtteremInterface
    {
        void EtlapMegnyitasa();
        void BorlapMegnyitasa();
        bool EtlapElonezetLatszik();
        void KosarhozAd(int termekId);
        bool AsztalfoglalasOldalLatszik();
        void AsztaltFoglalas();
    }
}
