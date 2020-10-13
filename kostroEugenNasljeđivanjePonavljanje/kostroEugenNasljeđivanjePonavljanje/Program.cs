using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenNasljeđivanjePonavljanje
{
    interface IControl
    {
        void Metoda();

       int Brojac { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComboBox x = new ComboBox();
            ListBox y = new ListBox();
            x.Metoda();
            y.Metoda();
            Console.ReadKey();
        }
    }

    class ListBox : IControl
    {
        public int Brojac
        {
            get { return Brojac; }
            set { Brojac = value; }
        }

        

        public void Metoda()
        {
            Console.WriteLine("Metoda List");
            
        }
    }

    class ComboBox : IControl
    {
        public int Brojac
        {
            get { return Brojac; }
            set { Brojac = value; }
        }



        public void Metoda()
        {
            Console.WriteLine("Metoda Combo");
        }
    }

}
