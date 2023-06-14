using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Proy_Pumakatari
{
    public class Ruta
    {
        private string nombre, inicio, final;
        private double pasaje;
        private int nroPar;
        private Parada[] parada = new Parada[20];
        public Ruta()
        {
            Nombre = "Achumani";
            Pasaje = 2.50;
            Inicio = "Campo verde";
            NroPar = 3;
            for (int i = 0; i <= 19; i++)
            {
                parada[i] = new Parada();
            }
            Final = "Plaza San Pedro";
        }
        public Ruta(string nom, double p,string ini, string u,string f)
        {
            Nombre = nom;
            Pasaje = p;
            Inicio = ini;
            NroPar = 3;
            for (int i = 0; i <= 19; i++)
            {
                parada[i] = new Parada(u);
            }
            Final = f;
           
        }
        public void escritura(BinaryWriter escritor)
        {
            escritor.Write(Nombre);
            escritor.Write(Pasaje);
            escritor.Write(Inicio);
            escritor.Write(NroPar);
            for (int i = 0; i < NroPar; i++)
            {
                parada[i].escritura(escritor);
            }
            escritor.Write(Final);
        }
        public void lectura(BinaryReader lector)
        {
            Nombre = lector.ReadString();
            Pasaje = lector.ReadDouble();
            Inicio = lector.ReadString();
            NroPar = lector.ReadInt32();
            for (int i = 0; i < NroPar; i++)
            {
                parada[i] = new Parada();
                parada[i].lectura(lector);
            }
            Final = lector.ReadString();
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Inicio { get => inicio; set => inicio = value; }
        public string Final { get => final; set => final = value; }
        public double Pasaje { get => pasaje; set => pasaje = value; }
        public int NroPar { get => nroPar; set => nroPar = value; }
    }
}
