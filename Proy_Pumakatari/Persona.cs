﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Proy_Pumakatari
{
    public class Persona
    {
        protected string nombre;
        protected int ci;
        protected int edad;
        public Persona()
        {
            Nombre = "Leo";
            Edad = 20;
            Ci = 1456;
        }
        public Persona(string n, int e, int c)
        {
            Nombre = n;
            Edad = e;
            Ci = c;
        }
        public void escritura(BinaryWriter escritor)
        {
            escritor.Write(Nombre);
            escritor.Write(Edad);
            escritor.Write(Ci);
        }
        public void lectura(BinaryReader lector)
        {
            Nombre = lector.ReadString();
            Edad = lector.ReadInt16();
            Ci = lector.ReadInt32();
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Ci { get => ci; set => ci = value; }
    }
}
