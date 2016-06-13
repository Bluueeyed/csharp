using System;

namespace biblioteka
{
    abstract class Publikacja
    {
        public Publikacja(string tytul, string opis, int rok, string osoba)
        {
            this.tytul = tytul;
            this.opis = opis;
            this.rokWydania = rok;
            this.wypozyczona=false;
            this.osobaWypozyczajca=osoba;
        }
        public abstract void dodaj();
        public abstract void usun();
        public abstract void edytuj();
        public void wypozycz()
        {
            this.wypozyczona = true;
        }
        public void zwroc()
        {
            this.wypozyczona = false;
        }

        public string Tytul
        {
            get
            {
                return tytul;
            }

            set
            {
                tytul = value;
            }
        }
        public bool Wypozyczona
        {
            get
            {
                return wypozyczona;
            }

            set
            {
                wypozyczona = value;
            }
        }
        protected string tytul { get; set; }
        protected string opis { get; set; }
        protected int rokWydania { get; set; }
        protected bool wypozyczona { get; set; }
        protected string osobaWypozyczajca { get; set; }
    }
}