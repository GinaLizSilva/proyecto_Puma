using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Pumakatari
{
    public class Pasajero:Persona
    {
        private string discapacidad;
        public Pasajero() : base()
        {
            Discapacidad = "No";
        }
        public Pasajero(string n, int e, int c,string d) : base(n, e, c)
        {
            Discapacidad = d;
        }
        public void escrituraPasajero(BinaryWriter escritor)
        {
            base.escrituraPersona(escritor);
            escritor.Write(Discapacidad);
        }
        public void lecturaPasajero(BinaryReader lector)
        {
            base.lecturaPersona(lector);
            Discapacidad = lector.ReadString();
        }
        public string Discapacidad { get => discapacidad; set => discapacidad = value; }
    }
}
