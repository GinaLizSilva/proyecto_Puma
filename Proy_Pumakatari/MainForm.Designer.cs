/*
 * Creado por SharpDevelop.
 * Usuario: USUARIO
 * Fecha: 13/6/2023
 * Hora: 12:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proy_Pumakatari
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonRuta = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ButtonFecha = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "PUMAKATARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(682, 96);
            this.label2.TabIndex = 2;
            this.label2.Text = "BIENVENIDO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonRuta
            // 
            this.ButtonRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(19)))), ((int)(((byte)(87)))));
            this.ButtonRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRuta.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRuta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRuta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonRuta.IconChar = FontAwesome.Sharp.IconChar.Route;
            this.ButtonRuta.IconColor = System.Drawing.Color.White;
            this.ButtonRuta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonRuta.IconSize = 42;
            this.ButtonRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRuta.Location = new System.Drawing.Point(0, 0);
            this.ButtonRuta.Name = "ButtonRuta";
            this.ButtonRuta.Size = new System.Drawing.Size(189, 66);
            this.ButtonRuta.TabIndex = 4;
            this.ButtonRuta.Text = "VER BUSES";
            this.ButtonRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonRuta.UseVisualStyleBackColor = false;
            this.ButtonRuta.Click += new System.EventHandler(this.ButtonRuta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(421, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 461);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ButtonFecha);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(261, 66);
            this.panel5.TabIndex = 3;
            // 
            // ButtonFecha
            // 
            this.ButtonFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(19)))), ((int)(((byte)(87)))));
            this.ButtonFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFecha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonFecha.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.ButtonFecha.IconColor = System.Drawing.Color.White;
            this.ButtonFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonFecha.IconSize = 42;
            this.ButtonFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonFecha.Location = new System.Drawing.Point(0, 0);
            this.ButtonFecha.Name = "ButtonFecha";
            this.ButtonFecha.Size = new System.Drawing.Size(189, 66);
            this.ButtonFecha.TabIndex = 4;
            this.ButtonFecha.Text = "VER RUTAS";
            this.ButtonFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonFecha.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 10);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ButtonRuta);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 66);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 17);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 159);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 10);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.iconButton1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 169);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(261, 66);
            this.panel7.TabIndex = 5;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(19)))), ((int)(((byte)(87)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Route;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 42;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(189, 66);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "REPORTES";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EL PUMAKATARI DE LA PAZ";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

		}
        private FontAwesome.Sharp.IconButton ButtonRuta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton ButtonFecha;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel6;
    }
}
