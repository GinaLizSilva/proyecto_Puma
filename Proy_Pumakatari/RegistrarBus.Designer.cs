namespace Proy_Pumakatari
{
    partial class RegistrarBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarBus));
            this.labelBuses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBuses
            // 
            this.labelBuses.BackColor = System.Drawing.Color.Transparent;
            this.labelBuses.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBuses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuses.Location = new System.Drawing.Point(0, 0);
            this.labelBuses.Name = "labelBuses";
            this.labelBuses.Size = new System.Drawing.Size(682, 111);
            this.labelBuses.TabIndex = 2;
            this.labelBuses.Text = "REGISTRAR BUS";
            this.labelBuses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrarBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.labelBuses);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "RegistrarBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR BUS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBuses;
    }
}