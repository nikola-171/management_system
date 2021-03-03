using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem
{
    /*interfejs sa rad sa sesijama, prikaz određenih formi samo ako je korisnik ulogovan*/
    interface ISesija
    {
        void Registruj_korisnika(String admin_ime);
        bool Provera_validnosti();
        void Logout_korisnika();
    }
}
