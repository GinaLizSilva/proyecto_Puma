/*
 * Creado por SharpDevelop.
 * Usuario: USUARIO
 * Fecha: 13/6/2023
 * Hora: 12:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proy_Pumakatari
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		private void ButtonRuta_Click(object sender, EventArgs e)
		{
			VenBuses Buses = new VenBuses();
            Buses.Show();
            
        } 
	}
}
