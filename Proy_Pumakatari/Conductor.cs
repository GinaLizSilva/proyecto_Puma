using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Pumakatari
{
    public class Conductor : Persona
    {
        private int aniosExp, licencia;

        public Conductor() : base()
        {
            AniosExp = 2;
            Licencia = 7564;
        }
        public Conductor(string n, int e, int c, int aE, int l) : base(n, e, c)
        {
            AniosExp = aE;
            Licencia = l;
        }
        public void escritura(BinaryWriter escritor)
        {
            base.escritura(escritor);
            escritor.Write(AniosExp);
            escritor.Write(Licencia);
        }
        public void lectura(BinaryReader lector)
        {
            base.lectura(lector);
            AniosExp = lector.ReadInt32();
            Licencia = lector.ReadInt32();
        }
        public int AniosExp { get => aniosExp; set => aniosExp = value; }
        public int Licencia { get => licencia; set => licencia = value; }
    }
}
