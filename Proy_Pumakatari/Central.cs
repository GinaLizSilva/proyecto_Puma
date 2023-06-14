using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Pumakatari
{
    public class Central
    {
        private int nroBuses;
        private Bus[] bus= new Bus[20];

        public Central()
        {
            NroBuses = 0;
        }
        public void adiBus(Bus x)
        {
            Bus[NroBuses] = x;
            NroBuses++;
        }
        public void escritura(BinaryWriter escritor)
        {
            escritor.Write(NroBuses);
            for (int i = 0; i < NroBuses; i++)
            {
                Bus[i].escritura(escritor);
            }
        }
        public void lectura(BinaryReader lector)
        {
            NroBuses=lector.ReadInt32();
            for (int i = 0; i < NroBuses; i++)
            {
                Bus[i]=new Bus();
                Bus[i].lectura(lector);
            }

        }
        public int NroBuses { get => nroBuses; set => nroBuses = value; }
        
        public Bus[] Bus { get => bus; set => bus = value; }
    }
}
