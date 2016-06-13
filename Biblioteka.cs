using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    class Biblioteka
    {
        public Biblioteka()
        {
            zbiorBiblioteczny = new List<Publikacja>();
            poczatek();
        }

        public void dodajPublikacje(Publikacja nowa)
        {
            zbiorBiblioteczny.Add(nowa);
        }

        public void usunPublikacje(Publikacja doUsuniecia)
        {
            zbiorBiblioteczny.Remove(doUsuniecia);
        }

        public int liczbaPublikacji()
        {
            return zbiorBiblioteczny.Count;
        }

        public List<Publikacja> getZbior()
        {
            return zbiorBiblioteczny;
        }

        private void poczatek()
        {
            zbiorBiblioteczny.Add(new Audiobook("Zaczarowany Ogród", "Książka dla dzieci", 2000, "Kasia Drozdowska", 200, "Harper Trophy"));
            zbiorBiblioteczny.Add(new Ksiazka("Dziady", "Będą na maturze", 1980, "Paweł Kowalski", "Znak", "Adam Mickiewicz"));
            zbiorBiblioteczny.Add(new Czasopismo("Wysokie Obcasy", "Czasopismo Feministyczne", 2015, "Zosia Kaim", 61));

        }

        private List<Publikacja> zbiorBiblioteczny;
    }
}
