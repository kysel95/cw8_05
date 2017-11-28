using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        
    }
    class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public Pozycja()
        {

        }
        public Pozycja(string tytul,int id,string wydawnictwo,int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine("Tytuł: {0}, Id: {1}, Wydawnictwo: {2}, rokWydania: {3}",tytul,id,wydawnictwo,rokWydania);
        }
        public string PobierzTytul()
        {
            return tytul;
        }
        public int PobierzId()
        {
            return id;
        }
    }
    class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo()
        {

        }
        public Czasopismo(string tytul,int id,string wydawnictwo, int rokWydania, int numer)
            :base(tytul,id,wydawnictwo,rokWydania)
        {
            this.numer = numer;
        }
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Numer: {0}", numer);
        }
    }
    class Ksiazka : Pozycja
    {
        private int liczbaStron();
        private 

        public Ksiazka()
        {

        }
        public Ksiazka(string tytul,int id,string wydawnictwo,int rokWydania,string imie,string nazwisko,string narodowosc)
            :base(tytul,id,wydawnictwo,rokWydania,imie,nazwisko,narodowosc)
        {
            
        }
        public override void WypiszInfo()
        {
 	        base.WypiszInfo();
        }
    }
}
