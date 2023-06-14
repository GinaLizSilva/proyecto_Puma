using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Pumakatari
{
    public class ArchivoCentral
    {
        private string nomArch;
        
        public ArchivoCentral(string n)
        {
            nomArch = n;
        }
        public void crear()
        {
            if (File.Exists(nomArch))
            {
                File.Delete(nomArch);
            }
        }
        public string listar()
        {
            Stream arch = File.Open(nomArch, FileMode.Append);
            BinaryReader lector = new BinaryReader(arch);

            Bus b=new Bus();
            string consola = "";
            try
            {
                while (true)
                {
                    b.lecturaBus(lector);
                    consola += ToString();
                }
            }
            catch (Exception) { }
            finally
            {
                arch.Close();
            }
            return consola;
        }

        public void adicionar(Bus b)
        {
            Stream arch = File.Open(nomArch, FileMode.Append);
            BinaryWriter escritor = new BinaryWriter(arch);

            try
            {
                b.escrituraBus(escritor);
            }
            catch (Exception) { }
            finally
            {
                arch.Close();
            }
        }
        public Central dameCentral()
        {
            Stream arch = File.Open(nomArch, FileMode.OpenOrCreate);
            BinaryReader lector = new BinaryReader(arch);

            Central c = new Central();
            try
            {
                c.lecturaBus(lector);
            }
            catch (Exception) { }
            finally
            {
                arch.Close();
            }
            return c;
        }
    }
}
