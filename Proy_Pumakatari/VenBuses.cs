using System;
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
                fila[0] = Central.Bus[i].Fecha;
                fila[1] = tienda.Emp[i].Paterno;
                fila[2] = tienda.Emp[i].Materno;
                fila[3] = tienda.Emp[i].Ci.ToString();
                fila[4] = tienda.Emp[i].Sueldo.ToString();
                fila[5] = tienda.Emp[i].Nrocelular.ToString();
                fila[6] = tienda.Emp[i].Fechanac;
                fila[7] = tienda.Emp[i].FechaContrato;

                dataGridViewEmpleados.Rows.Add(fila);
            }
        }
    }
}
