using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica4F
{
    class Program
    {
        class Treni
        {
            //attributi 
            public int codtreno; //iniziallizo le variabili
            public string tipo; //iniziallizo le variabili
            public string nome; //iniziallizo le variabili
            public float costo; //iniziallizo le variabili
            //costruttore
            public Treni(int codtreno, string tipo, string nome)    //dichiaro le variabili
            {
                this.codtreno = 0;
                this.tipo = tipo;
                this.nome = nome;
                this.costo = 100000;
            }
            //metodi
            public virtual float costoMezzo() //creo il metodo CostoMezzo
            {
                float costo = 100000;//imposto il valore del costo a 100000
                return costo;   //restituisce il valore del costo
            }
            public virtual float costoUtilizzo(float km) //creo il metodo CostoUtilizzo
            {
                return km;  //restituisce i km 
            }
        }
        class Passeggeri : Treni //creo la classe Passeggeri
        {
            public int numvagoni;
            public string alimentazione;
            public Passeggeri(int codtreno, string tipo, string nome, int numvagoni, string alimentazine) : base(codtreno, tipo, nome) //richiamo gli attributi del padre
            {
                this.codtreno = 0;
                this.tipo = tipo;
                this.nome = nome;
                this.costo = 0;
                this.numvagoni = 0;
                this.alimentazione = alimentazione;
            }
            public override float costoMezzo()
            {
                float costo = (100000 * 125)/100; //restituisce il costo del Mezzo + 25%
                return costo;
            }
            public override float costoUtilizzo(float km)
            {
                return km * 150;    //restituisce il costo dei km * 150
            }
        }
        class Merci : Treni //creo la classe Merci
        {
            public int numvagoni;
            public string alimentazione;
            public Merci(int codtreno, string tipo, string nome, int numvagoni, string alimentazine) : base(codtreno, tipo, nome)//richiamo gli attributi del padre
            {
                this.codtreno = 0;
                this.tipo = tipo;
                this.nome = nome;
                this.costo = 0;
                this.numvagoni = 0;
                this.alimentazione = alimentazione;
            }
            public override float costoMezzo()
            {
                float costo = (100000 * 135) / 100; //restituisce il costo del Mezzo + 35%
                return costo;
            }
            public override float costoUtilizzo(float km)
            {
                return km * 100; //restituisce il costo dei km * 100
            }
        }
        static void Main(string[] args)
        {
            Passeggeri p = new Passeggeri(131, "regionele", "Pazzo", 12, "vapore");
            float costoPasseggeri = p.costoMezzo();
            Console.WriteLine("Il costo del treno Passeggeri è di: " + costoPasseggeri + "euro"); //restituisce il costo del treno Passeggeri
            float costoUtilizzoPasseggeri = p.costoUtilizzo(203);//valore dei km scelto casualmente
            Console.WriteLine("Il costo del treno Passeggeri per i km è di: " + costoUtilizzoPasseggeri + "euro");//restituisce il costo di utilizzo del treno Passeggeri

            Merci m = new Merci(7561, "Internazionale", "Assurdo", 4, "carbone");
            float costoMerci = m.costoMezzo();
            Console.WriteLine("\nIl costo del treno Merci è di: " + costoMerci + "euro");   //restituisce il costo del treno Merci
            float costoUtilizzoMerci = m.costoUtilizzo(103);//valore dei km scelto casualmente
            Console.WriteLine("Il costo del treno Merci per i km è di: " + costoUtilizzoMerci + "euro");//restituisce il costo di utilizzo del treno Merci

            float costoTotale = costoPasseggeri + costoMerci + costoUtilizzoMerci + costoUtilizzoPasseggeri; //somma tutti i valori di CostoPasseggeri, costoMerci e i loro costi di utilizzo
            Console.WriteLine("\nIl costo totale dei treni compreso sia utilizzo che costo effettivo del treno è di: " + costoTotale); //restituisce il valore della somma totale

            Console.ReadKey();
        }
    }
}
