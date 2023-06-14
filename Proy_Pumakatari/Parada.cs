using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Pumakatari
{
    public class Parada
    {
        private string ubicacion;
        public Parada()
        {
            Ubicacion = "Kellumani";
        }
        public Parada(string u)
        {
            Ubicacion = u;
        }
        public void escrituraParada(BinaryWriter escritor)
        {
            escritor.Write(Ubicacion);
        }
        public void lecturaParada(BinaryReader lector)
        {
            Ubicacion = lector.ReadString();
        }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
    }
}
