using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem
{
    interface DodavanjeParametara
    {
        void Postavi_parametre(List<Tuple<string, string>> parametri);
        void Osvezi_sadrzaj();
    }
}
