using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Pumakatari
{
    public class Fecha
    {
        private int dia, anio;
        private string mes;
        public Fecha()
        {
            Dia = 06;
            Mes = "Febrero";
            Anio = 2023;
        }
        public Fecha(int d, string m, int a)
        {
            Dia = d;
            Mes = m;
            Anio = a;
        }
        public void escritura(BinaryWriter escritor)
        {
            escritor.Write(Dia);
            escritor.Write(Mes);
            escritor.Write(Anio);
        }
        public void lectura(BinaryReader lector)
        {
            Dia = lector.ReadInt16();
            Mes = lector.ReadString();
            Anio = lector.ReadInt16();
        }
        public int Dia { get => dia; set => dia = value; }
        public int Anio { get => anio; set => anio = value; }
        public string Mes { get => mes; set => mes = value; }
    }
}
