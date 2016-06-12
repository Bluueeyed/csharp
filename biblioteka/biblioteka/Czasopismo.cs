using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    class Czasopismo : Publikacja
    {
        public Czasopismo(string tytul, string opis, int rok, string osoba, int numer)
            : base(tytul, opis, rok, osoba)
        {
            this.numer = numer;
        }
        public override void dodaj()
        {
            throw new NotImplementedException();
        }

        public override void edytuj()
        {
            throw new NotImplementedException();
        }

        public override void usun()
        {
            throw new NotImplementedException();
        }

        private int numer;
    }
}
