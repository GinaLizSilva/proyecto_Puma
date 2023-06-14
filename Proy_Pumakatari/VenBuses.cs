﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy_Pumakatari
{
    public partial class VenBuses : Form
    {
        ArchivoCentral arch;
        public VenBuses()
        {
            InitializeComponent();
        }
        public VenBuses(ArchivoCentral b)
        {
            InitializeComponent();
            arch = b;
            mostrarDatos();
        }
        public void mostrarDatos()
        {
            Central c = arch.dameCentral();

            string[] fila = new string[8];

            for (int i = 0; i <c.NroBuses; i++)
            {
                fila[0] = c.Bus[i].Fecha.ToString();
                fila[1] = c.Bus[i].Conductor.Nombre;
                fila[2] = c.Bus[i].Placa;
                fila[3] = c.Bus[i].Asistente[i].Nombre;
                fila[4] = c.Bus[i].Asistente[i].Nombre;
                fila[5] = tienda.Emp[i].Nrocelular.ToString();
                fila[6] = tienda.Emp[i].Fechanac;
                fila[7] = tienda.Emp[i].FechaContrato;

                dataGridViewEmpleados.Rows.Add(fila);
            }
        }
    }
}
