using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    class Audiobook : Publikacja
    {
        public Audiobook(string tytul, string opis, int rok, string osoba, int dlugosc, string autor)
            :base(tytul, opis, rok, osoba)
        {
            this.dlugoscMin = dlugosc;
            this.autor = autor;
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

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public int DlugoscMin
        {
            get
            {
                return dlugoscMin;
            }

            set
            {
                dlugoscMin = value;
            }
        }

        private int dlugoscMin;
        private string autor;
    }
}
