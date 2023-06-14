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
        private int nroPasajero, nroAsistente;
        private Asistente[] asistente = new Asistente[2];
        private Pasajero[] pasajero = new Pasajero[60];

        public Bus()
        {
            Fecha = new Fecha();
            Placa = "HJU-568";
            Ruta = new Ruta();
            Conductor = new Conductor();
            NroAsistente = 0;
            NroPasajero = 0;
        }
        public Bus(string p)
        {
            Fecha = new Fecha(01, "Febrero", 2023);
            Placa = p;
            Ruta = new Ruta("Quillacollo", 2.50, "Plaza Avaroa", "Obrajes", "Plaza Bolivia");
            Conductor = new Conductor("Pedro", 35, 234589, 4268, 5);
            NroAsistente = 0;
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
        public void escrituraBus(BinaryWriter escritor)
        {
            Fecha.escrituraFecha(escritor);
            escritor.Write(Placa);
            Ruta.escrituraRuta(escritor);
            Conductor.escrituraConductor(escritor);
            escritor.Write(NroAsistente);
            for (int i = 0; i < NroAsistente; i++)
            {
                Asistente[i].escrituraAsistente(escritor);         
            }
            escritor.Write(NroPasajero);
            for (int i = 0; i < NroPasajero; i++)
            {
                Pasajero[i].escrituraPasajero(escritor);
            }
        }
        public void lecturaBus(BinaryReader lector)
        {
            Fecha.lecturaFecha(lector);
            Placa = lector.ReadString();
            Ruta.lecturaRuta(lector);
            Conductor.lecturaConductor(lector);
            NroAsistente = lector.ReadInt32();
            for (int i = 0; i < NroAsistente; i++)
            {
                Asistente[i] = new Asistente();
                Asistente[i].lecturaAsistente(lector);
            }
            NroPasajero = lector.ReadInt32();
            for (int i = 0; i < NroPasajero; i++)
            {
                Pasajero[i] = new Pasajero();
                Pasajero[i].lecturaPasajero(lector);
            }
        }
        public string Placa { get => placa; set => placa = value; }
        public int NroPasajero { get => nroPasajero; set => nroPasajero = value; }
        public int NroAsistente { get => nroAsistente; set => nroAsistente = value; }
        public Fecha Fecha { get => fecha; set => fecha = value; }
        public Ruta Ruta { get => ruta; set => ruta = value; }
        public Conductor Conductor { get => conductor; set => conductor = value; }
        public Asistente[] Asistente { get => asistente; set => asistente = value; }
        public Pasajero[] Pasajero { get => pasajero; set => pasajero = value; }
    }
}
