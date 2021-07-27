using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio14
{
    class Cerchio : FormaGeometrica
    {
        public Centro Coordinate { get; set; }
        public double Raggio { get; set; }

        public Cerchio(string name, double raggio, Centro coordinate)
            : base(name)
        {
            this.Coordinate = coordinate;
            this.Raggio = raggio;
        }

        public override double CalcolaPerimetro()
        {
            double perimetro = Math.PI * Raggio * 2;
            return perimetro;
        }
        public override double CalcolaArea()
        {
            double area = Math.PI * Raggio * Raggio;
            return area;
        }

        public override void DisegnaForma()
        {
            base.DisegnaForma();
            Console.WriteLine($"Le coordinate del centro sono [{Coordinate.X},{Coordinate.Y}], il raggio misura {Raggio} metri, il perimetro è pari a {CalcolaPerimetro()} metri e l'area è pari a {CalcolaArea()} mq");
        }

        public override void SaveToFile(string fileName)
        {

            StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine($"\n{Name}");
            writer.WriteLine($" Coordinata X: {Coordinate.X}");
            writer.WriteLine($" Coordinata Y: {Coordinate.Y}");
            writer.WriteLine($" Il raggio misura {Raggio} m");
            writer.Flush();
            writer.Close();

        }
        public override void LoadFromFile(string fileName)
        {
            //    StreamReader reader = File.OpenText(fileName);
            //    Name = reader.ReadLine();
            //    int.TryParse(reader.ReadLine(), out int X);

            //    int.TryParse(reader.ReadLine(), out int Y);

            //    double.TryParse(reader.ReadLine(), out double raggio);
            //    Raggio = raggio;
            //    reader.Close();
            //}

        }
    }

        internal struct Centro
        {
            public int X;
            public int Y;

            public Centro(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }

