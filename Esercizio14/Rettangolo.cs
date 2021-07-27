using System;
using System.IO;

namespace Esercizio14
{
    class Rettangolo : FormaGeometrica
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public Rettangolo(string name, double altezza, double _base)
            : base(name)
        {
            this.Altezza = altezza;
            this.Base = _base;

        }
        public override double CalcolaPerimetro()
        {
            double perimetro = (Base + Altezza) * 2;
            return perimetro;
        }

        public override double CalcolaArea()
        {
            double area = Base * Altezza;
            return area;
        }

        public override void DisegnaForma()
        {
            base.DisegnaForma();
            Console.WriteLine($"L'altezza misura {Altezza} metri, la base misura {Base} metri, il perimetro è pari a {CalcolaPerimetro()} metri e l'area è pari a {CalcolaArea()} mq");
        }

        public override void SaveToFile(string fileName)
        {

            StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine($"\n{Name}");
            writer.WriteLine($" La base misura {Base} m");
            writer.WriteLine($" L'altezza misura {Altezza} m");
            writer.Flush();
            writer.Close();


        }




        public override void LoadFromFile(string fileName)
{
//    StreamReader reader = File.OpenText(fileName);
//    Name = reader.ReadLine();
//    double.TryParse(reader.ReadLine(), out double _base);
//    Base = _base;
//    double.TryParse(reader.ReadLine(), out double altezza);
//    Altezza = altezza;
//    reader.Close();
    }


}
    }

 