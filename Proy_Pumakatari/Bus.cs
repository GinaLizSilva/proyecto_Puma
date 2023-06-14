using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Pumakatari
{
    public class Bus
    {
        private Fecha fecha;
        private string placa;
        private Ruta ruta;
        private Conductor conductor;
        private Asistente asistente;
        private int nroPasajero;
        private Pasajero[] pasajero = new Pasajero[60];

        public Bus()
        {
            Fecha = new Fecha();
            Placa = "HJU-568";
            Ruta = new Ruta();
            Conductor = new Conductor();
            Asistente = new Asistente();
            NroPasajero = 0;
        }
        public Bus(string p)
        {
            Fecha = new Fecha(01, "Febrero", 2023);
            Placa = p;
            Ruta = new Ruta("Quillacollo", 2.50, "Plaza Avaroa", "Obrajes", "Plaza Bolivia");
            Conductor = new Conductor("Pedro", 35, 234589, 4268, 5);
            Asistente = new Asistente("Maria",26);
            NroPasajero = 0;
        }
        public void adiAsis(Asistente x)
        {
            Asistente[NroAsistente] = x;
            NroAsistente++;

        }
        public void adiPasajero(Pasajero x)
        {
            Pasajero[NroPasajero] = x;
            NroPasajero++;

        }
        public void escritura(BinaryWriter escritor)
        {
            Fecha.escritura(escritor);
            escritor.Write(Placa);
            Ruta.escritura(escritor);
            Conductor.escritura(escritor);
            escritor.Write(NroAsistente);
            for (int i = 0; i < NroAsistente; i++)
            {
                Asistente[i].escritura(escritor);         
            }
            escritor.Write(NroPasajero);
            for (int i = 0; i < NroPasajero; i++)
            {
                Pasajero[i].escritura(escritor);
            }
        }
        public void lectura(BinaryReader lector)
        {
            Fecha.lectura(lector);
            Placa = lector.ReadString();
            Ruta.lectura(lector);
            Conductor.lectura(lector);
            NroAsistente = lector.ReadInt32();
            for (int i = 0; i < NroAsistente; i++)
            {
                Asistente[i] = new Asistente();
                Asistente[i].lectura(lector);
            }
            NroPasajero = lector.ReadInt32();
            for (int i = 0; i < NroPasajero; i++)
            {
                Pasajero[i] = new Pasajero();
                Pasajero[i].lectura(lector);
            }
        }
        public string Placa { get => placa; set => placa = value; }
        public int NroPasajero { get => nroPasajero; set => nroPasajero = value; }
        public int NroAsistente { get => nroAsistente; set => nroAsistente = value; }
        public Fecha Fecha { get => fecha; set => fecha = value; }
        public Ruta Ruta { get => ruta; set => ruta = value; }
        public Conductor Conductor { get => conductor; set => conductor = value; }
        public Pasajero[] Pasajero { get => pasajero; set => pasajero = value; }
        public Asistente Asistente { get => asistente; set => asistente = value; }
    }
}
