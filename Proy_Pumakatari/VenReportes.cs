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
    public partial class VenReportes : Form
    {
        public VenReportes()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cajaferroviaria_Click(object sender, EventArgs e)
        {
            openform(new VenVerpFechas());
        }
        private void openform(Form form)
        {
            form.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openform(new VenRutaMU());
        }
    }
}
