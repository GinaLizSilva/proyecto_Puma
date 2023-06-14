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
    public partial class RegistrarBus : Form
    {
        ArchivoCentral arch;
        public RegistrarBus()
        {
            InitializeComponent();
        }
        public RegistrarBus(ArchivoCentral c)
        {
            InitializeComponent();
            arch = c;
        }

        private void ButtonConductor_Click(object sender, EventArgs e)
        {
            RegistrarConductor RegCond = new RegistrarConductor();
            RegCond.Show();
        }
    }

}
