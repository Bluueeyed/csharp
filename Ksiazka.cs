using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    class Ksiazka :Publikacja
    {
        public Ksiazka(string tytul, string opis, int rok, string osoba, string wydawnictwo, string autor)
            : base(tytul, opis, rok, osoba)
        {
            this.wydawnictwo = wydawnictwo;
            this.autor = autor;
        }

        public string Wydawnictwo
        {
            get
            {
                return wydawnictwo;
            }

            set
            {
                wydawnictwo = value;
            }
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
        public override void dodaj()
        {
            throw new NotImplementedException();
        }

        public override void usun()
        {
            throw new NotImplementedException();
        }

        public override void edytuj()
        {
            throw new NotImplementedException();
        }

        private string autor;
        private string wydawnictwo;
    }
}
