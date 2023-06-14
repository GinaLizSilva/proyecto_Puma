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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenBuses));
            this.labelBuses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBuses
            // 
            this.labelBuses.BackColor = System.Drawing.Color.Transparent;
            this.labelBuses.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBuses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuses.Location = new System.Drawing.Point(0, 0);
            this.labelBuses.Name = "labelBuses";
            this.labelBuses.Size = new System.Drawing.Size(682, 96);
            this.labelBuses.TabIndex = 1;
            this.labelBuses.Text = "BUSES";
            this.labelBuses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VenBuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.labelBuses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "VenBuses";
            this.Text = "BUSES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBuses;
    }
}