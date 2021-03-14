using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem.pdf_kreator
{
    interface IKreator
    {
         void Kreiraj(Tuple<List<float>, DataTable> tabela_podataka, String lokacija, string naslov);
    }
}
