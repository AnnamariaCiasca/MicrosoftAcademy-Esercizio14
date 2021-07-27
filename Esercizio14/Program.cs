//Scrivere un programma per rappresentare le forme geometriche:


//Tutte le classi avranno una proprietà Nome(stringa),
//un metodo per il calcolo de perimetro
//un metodo per il calcolo dell’area
//un metodo che disegni la forma -> stampare nella console i dettagli delle proprietà e dell’Area

//Realizzare le classi che rappresentano:
//Un cerchio che avrà anche le coordinate del centro e il raggio
//Un rettangolo che avrà anche larghezza e altezza
//Un triangolo che avrà base e altezza

//Tutte le classi dovranno implementare la propria versione del metodo di calcolo dell’area, il perimetro e di disegno

//Aggiungere un'interfaccia che permetta di salvare e leggere i risultati da un file
//I metodi riceveranno in ingresso il nome del file

//Creare una istanza di ogni classe nel metodo Main e visualizzare il risultato dell’esecuzione dei metodi.

using System;
using System.Collections.Generic;

namespace Esercizio14
{
    class Program
    {
        static void Main(string[] args)

        {

            List<FormaGeometrica> forme = new List<FormaGeometrica>();

            Centro centro = new Centro();
            centro.X = 3;
            centro.Y = 2;


            GetDatiCerchio(out double raggio);

            Cerchio c = new Cerchio("Cerchio", raggio, centro);

            forme.Add(c);

            GetDatiRettangolo(out double altezza, out double _base);

            Rettangolo r = new Rettangolo("Rettangolo", altezza, _base);
            forme.Add(r);

            GetDatiTriangolo(out double _altezza, out double _baseT, out double cateto1, out double cateto2);

            Triangolo t = new Triangolo("Triangolo", _altezza, _baseT, cateto1, cateto2);
            forme.Add(t);

        

            string fileName = @"C:\Users\annamaria.ciasca\Desktop\Forme.txt";

            IFileSerializable[] figure = new IFileSerializable[] {c,r,t,};

            foreach (var item in forme)
            {
                item.SaveToFile(fileName);
                item.LoadFromFile(fileName);
                item.DisegnaForma();
            }

        }

        public static void GetDatiCerchio(out double raggio)
        {
            Console.WriteLine("\nCERCHIO\n ");

            do
            {
                Console.Write($"Inserisci il raggio: ");
            } while (!double.TryParse(Console.ReadLine(), out raggio) );
        }

        public static void GetDatiRettangolo(out double altezza, out double _base)
        {
            Console.WriteLine("\n\nRETTANGOLO\n ");

            do
            {
                Console.Write($"Inserisci l'altezza del rettangolo: ");
            } while (!double.TryParse(Console.ReadLine(), out altezza));

            do
            {
                Console.Write($"Inserisci la base del rettangolo: ");
            } while (!double.TryParse(Console.ReadLine(), out _base));
        }

        public static void GetDatiTriangolo(out double _altezza, out double _baseT, out double cateto1, out double cateto2)
        {
            Console.WriteLine("\n\nTRIANGOLO\n");

            do
            {
                Console.Write($"Inserisci l'altezza del triangolo: ");
            } while (!double.TryParse(Console.ReadLine(), out _altezza));

            do
            {
                Console.Write($"Inserisci la base del triangolo: ");
            } while (!double.TryParse(Console.ReadLine(), out _baseT));

            do
            {
                Console.Write($"Inserisci il primo cateto del triangolo: ");
            } while (!double.TryParse(Console.ReadLine(), out cateto1));

            do
            {
                Console.Write($"Inserisci il secondo cateto del triangolo: ");
            } while (!double.TryParse(Console.ReadLine(), out cateto2));


        }

    }
}