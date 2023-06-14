using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Proy_Pumakatari
{
    public class Asistente:Persona
    {
        private int aniosdeExp;
        public Asistente() : base()
        {
            AniosdeExp = 6;
        }
        public Asistente(string n, int e, int c, int aE) : base(n, e, c)
        {
            AniosdeExp = aE;
        }
        public void escrituraAsistente(BinaryWriter escritor)
        {
            base.escrituraPersona(escritor);
            escritor.Write(AniosdeExp);
        }
        public void lecturaAsistente(BinaryReader lector)
        {
            base.lecturaPersona(lector);
            AniosdeExp = lector.ReadInt16();
        }
        public int AniosdeExp { get => aniosdeExp; set => aniosdeExp = value; }
    }
}
