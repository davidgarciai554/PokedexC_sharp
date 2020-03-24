namespace PokedexC_sharp
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boton_izq = new System.Windows.Forms.Button();
            this.boton_der = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PokedexC_sharp.Properties.Resources.Pokedex;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // boton_izq
            // 
            this.boton_izq.Location = new System.Drawing.Point(114, 500);
            this.boton_izq.Name = "boton_izq";
            this.boton_izq.Size = new System.Drawing.Size(61, 28);
            this.boton_izq.TabIndex = 1;
            this.boton_izq.Text = "<";
            this.boton_izq.UseVisualStyleBackColor = true;
            this.boton_izq.Click += new System.EventHandler(this.boton_izq_Click);
            // 
            // boton_der
            // 
            this.boton_der.Location = new System.Drawing.Point(181, 500);
            this.boton_der.Name = "boton_der";
            this.boton_der.Size = new System.Drawing.Size(61, 28);
            this.boton_der.TabIndex = 2;
            this.boton_der.Text = ">";
            this.boton_der.UseVisualStyleBackColor = true;
            this.boton_der.Click += new System.EventHandler(this.boton_der_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.Location = new System.Drawing.Point(504, 183);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(115, 38);
            this.nombrePokemon.TabIndex = 3;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.boton_der);
            this.Controls.Add(this.boton_izq);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boton_izq;
        private System.Windows.Forms.Button boton_der;
        private System.Windows.Forms.Label nombrePokemon;
    }
}

