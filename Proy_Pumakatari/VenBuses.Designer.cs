namespace Proy_Pumakatari
{
    partial class VenBuses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenBuses));
            this.labelBuses = new System.Windows.Forms.Label();
            this.dataGridViewBuses = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAgregarBus = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBuses
            // 
            this.labelBuses.BackColor = System.Drawing.Color.Transparent;
            this.labelBuses.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBuses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuses.Location = new System.Drawing.Point(0, 0);
            this.labelBuses.Name = "labelBuses";
            this.labelBuses.Size = new System.Drawing.Size(682, 111);
            this.labelBuses.TabIndex = 1;
            this.labelBuses.Text = "BUSES";
            this.labelBuses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewBuses
            // 
            this.dataGridViewBuses.AllowUserToAddRows = false;
            this.dataGridViewBuses.AllowUserToDeleteRows = false;
            this.dataGridViewBuses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(188)))));
            this.dataGridViewBuses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(40)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Conductor,
            this.Placa,
            this.Asistente,
            this.NroPasajeros});
            this.dataGridViewBuses.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(193)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBuses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBuses.Location = new System.Drawing.Point(95, 114);
            this.dataGridViewBuses.Name = "dataGridViewBuses";
            this.dataGridViewBuses.ReadOnly = true;
            this.dataGridViewBuses.RowHeadersVisible = false;
            this.dataGridViewBuses.RowHeadersWidth = 51;
            this.dataGridViewBuses.RowTemplate.Height = 24;
            this.dataGridViewBuses.Size = new System.Drawing.Size(468, 364);
            this.dataGridViewBuses.TabIndex = 2;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 90;
            // 
            // Conductor
            // 
            this.Conductor.HeaderText = "Conductor";
            this.Conductor.MinimumWidth = 6;
            this.Conductor.Name = "Conductor";
            this.Conductor.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.MinimumWidth = 6;
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 75;
            // 
            // Asistente
            // 
            this.Asistente.HeaderText = "Asistente";
            this.Asistente.MinimumWidth = 6;
            this.Asistente.Name = "Asistente";
            this.Asistente.ReadOnly = true;
            this.Asistente.Width = 95;
            // 
            // NroPasajeros
            // 
            this.NroPasajeros.HeaderText = "NroPasajeros";
            this.NroPasajeros.MinimumWidth = 6;
            this.NroPasajeros.Name = "NroPasajeros";
            this.NroPasajeros.ReadOnly = true;
            this.NroPasajeros.Width = 110;
            // 
            // ButtonAgregarBus
            // 
            this.ButtonAgregarBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(19)))), ((int)(((byte)(87)))));
            this.ButtonAgregarBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAgregarBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAgregarBus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAgregarBus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAgregarBus.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ButtonAgregarBus.IconColor = System.Drawing.Color.White;
            this.ButtonAgregarBus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAgregarBus.IconSize = 42;
            this.ButtonAgregarBus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonAgregarBus.Location = new System.Drawing.Point(583, 129);
            this.ButtonAgregarBus.Name = "ButtonAgregarBus";
            this.ButtonAgregarBus.Size = new System.Drawing.Size(87, 74);
            this.ButtonAgregarBus.TabIndex = 5;
            this.ButtonAgregarBus.Text = "BUS";
            this.ButtonAgregarBus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonAgregarBus.UseVisualStyleBackColor = false;
            this.ButtonAgregarBus.Click += new System.EventHandler(this.ButtonAgregarBus_Click);
            // 
            // VenBuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.ButtonAgregarBus);
            this.Controls.Add(this.dataGridViewBuses);
            this.Controls.Add(this.labelBuses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "VenBuses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSES";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBuses;
        private System.Windows.Forms.DataGridView dataGridViewBuses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPasajeros;
        private FontAwesome.Sharp.IconButton ButtonAgregarBus;
    }
}