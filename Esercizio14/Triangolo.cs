using System;
using System.IO;

namespace Esercizio14
{
    class Triangolo : FormaGeometrica
    {

        public double Altezza { get; set; }
        public double BaseT { get; set; }
        public double Cateto1 { get; set; }
        public double Cateto2 { get; set; }



        public Triangolo(string name, double altezza, double _baseT, double cateto1, double cateto2)
            : base(name)
        {
            this.Altezza = altezza;
            this.BaseT = _baseT;
            this.Cateto1 = cateto1;
            this.Cateto2 = cateto2;
        }

        public override double CalcolaPerimetro()
        {
            double perimetro = (BaseT + Cateto1 + Cateto2);
            return perimetro;
        }

        public override double CalcolaArea()
        {
            double area = (BaseT * Altezza) / 2;
            return area;

        }

        public override void DisegnaForma()
        {
            base.DisegnaForma();
            Console.WriteLine($"L'altezza misura {Altezza} metri, la base misura {BaseT} metri, i cateti misurano {Cateto1} e {Cateto2} metri, il perimetro è pari a {CalcolaPerimetro()} metri e l'area è pari a {CalcolaArea()} mq");
        }

        public override void SaveToFile(string fileName)
        {

            StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine($"\n{Name}");
            writer.WriteLine($" La base misura {BaseT} m");
            writer.WriteLine($" L'altezza misura {Altezza} m");
            writer.WriteLine($" Il primo cateto misura {Cateto1} m");
            writer.WriteLine($" Il secondo cateto misura {Cateto2} m");
            writer.Flush();
            writer.Close();

        }


        public override void LoadFromFile(string fileName)
        {
            //StreamReader reader = File.OpenText(fileName);
            //Name = reader.ReadLine();
            //double.TryParse(reader.ReadLine(), out double altezza);
            //Altezza = altezza;
            //double.TryParse(reader.ReadLine(), out double _baseT);
            //BaseT = _baseT;
            //reader.Close();

        }



    }
}
