using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio14
{
   public class FormaGeometrica : IFileSerializable
    {
            public string Name { get; set; }

            public FormaGeometrica(string name)
            {
                this.Name = name;
            }
        
        public virtual double CalcolaPerimetro()
        {
            return 0;
        }
        public virtual double CalcolaArea()
            {
                return 0;
            }

            public virtual void DisegnaForma()
            {
                Console.WriteLine($"\nLa forma geometrica è un {Name}");
            }

            public virtual void SaveToFile(string fileName)
            {
          

        }

            public virtual void LoadFromFile(string fileName)
            {

            }

        
        }
    }