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
            this.fotoPokemon = new System.Windows.Forms.PictureBox();
            this.pesoPokemon = new System.Windows.Forms.Label();
            this.alturaPokemon = new System.Windows.Forms.Label();
            this.especiePokemon = new System.Windows.Forms.Label();
            this.habitatPokemon = new System.Windows.Forms.Label();
            this.tipoPokemon = new System.Windows.Forms.Label();
            this.habilidadPokemon = new System.Windows.Forms.Label();
            this.movimientoPokemon = new System.Windows.Forms.Label();
            this.numPokedex = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(217)))), ((int)(((byte)(223)))));
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
            this.nombrePokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(251)))), ((int)(((byte)(5)))));
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.Location = new System.Drawing.Point(475, 173);
            this.nombrePokemon.Margin = new System.Windows.Forms.Padding(3);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(280, 32);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nombrePokemon.Click += new System.EventHandler(this.nombrePokemon_Click);
            // 
            // fotoPokemon
            // 
            this.fotoPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPokemon.Location = new System.Drawing.Point(27, 148);
            this.fotoPokemon.Name = "fotoPokemon";
            this.fotoPokemon.Size = new System.Drawing.Size(336, 346);
            this.fotoPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPokemon.TabIndex = 4;
            this.fotoPokemon.TabStop = false;
            // 
            // pesoPokemon
            // 
            this.pesoPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(251)))), ((int)(((byte)(5)))));
            this.pesoPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoPokemon.Location = new System.Drawing.Point(475, 249);
            this.pesoPokemon.Margin = new System.Windows.Forms.Padding(3);
            this.pesoPokemon.Name = "pesoPokemon";
            this.pesoPokemon.Size = new System.Drawing.Size(280, 32);
            this.pesoPokemon.TabIndex = 5;
            this.pesoPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesoPokemon.Click += new System.EventHandler(this.pesoPokemon_Click);
            // 
            // alturaPokemon
            // 
            this.alturaPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(251)))), ((int)(((byte)(5)))));
            this.alturaPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaPokemon.Location = new System.Drawing.Point(475, 211);
            this.alturaPokemon.Margin = new System.Windows.Forms.Padding(3);
            this.alturaPokemon.Name = "alturaPokemon";
            this.alturaPokemon.Size = new System.Drawing.Size(280, 32);
            this.alturaPokemon.TabIndex = 6;
            this.alturaPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // especiePokemon
            // 
            this.especiePokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(251)))), ((int)(((byte)(5)))));
            this.especiePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especiePokemon.Location = new System.Drawing.Point(475, 287);
            this.especiePokemon.Margin = new System.Windows.Forms.Padding(3);
            this.especiePokemon.Name = "especiePokemon";
            this.especiePokemon.Size = new System.Drawing.Size(280, 32);
            this.especiePokemon.TabIndex = 7;
            this.especiePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.especiePokemon.Click += new System.EventHandler(this.especiePokemon_Click);
            // 
            // habitatPokemon
            // 
            this.habitatPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(251)))), ((int)(((byte)(5)))));
            this.habitatPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitatPokemon.Location = new System.Drawing.Point(475, 325);
            this.habitatPokemon.Margin = new System.Windows.Forms.Padding(3);
            this.habitatPokemon.Name = "habitatPokemon";
            this.habitatPokemon.Size = new System.Drawing.Size(280, 32);
            this.habitatPokemon.TabIndex = 8;
            this.habitatPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tipoPokemon
            // 
            this.tipoPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(251)))), ((int)(((byte)(5)))));
            this.tipoPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPokemon.Location = new System.Drawing.Point(475, 363);
            this.tipoPokemon.Margin = new System.Windows.Forms.Padding(3);
            this.tipoPokemon.Name = "tipoPokemon";
            this.tipoPokemon.Size = new System.Drawing.Size(280, 32);
            this.tipoPokemon.TabIndex = 9;
            this.tipoPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // habilidadPokemon
            // 
            this.habilidadPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(251)))), ((int)(((byte)(5)))));
            this.habilidadPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilidadPokemon.Location = new System.Drawing.Point(475, 401);
            this.habilidadPokemon.Margin = new System.Windows.Forms.Padding(3);
            this.habilidadPokemon.Name = "habilidadPokemon";
            this.habilidadPokemon.Size = new System.Drawing.Size(280, 32);
            this.habilidadPokemon.TabIndex = 10;
            this.habilidadPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // movimientoPokemon
            // 
            this.movimientoPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(251)))), ((int)(((byte)(5)))));
            this.movimientoPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientoPokemon.Location = new System.Drawing.Point(479, 455);
            this.movimientoPokemon.Margin = new System.Windows.Forms.Padding(3);
            this.movimientoPokemon.Name = "movimientoPokemon";
            this.movimientoPokemon.Size = new System.Drawing.Size(276, 73);
            this.movimientoPokemon.TabIndex = 11;
            this.movimientoPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numPokedex
            // 
            this.numPokedex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(217)))), ((int)(((byte)(223)))));
            this.numPokedex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numPokedex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPokedex.Location = new System.Drawing.Point(248, 74);
            this.numPokedex.Margin = new System.Windows.Forms.Padding(3);
            this.numPokedex.Name = "numPokedex";
            this.numPokedex.Size = new System.Drawing.Size(105, 44);
            this.numPokedex.TabIndex = 13;
            this.numPokedex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PokedexC_sharp.Properties.Resources.lupa;
            this.pictureBox2.Location = new System.Drawing.Point(63, 499);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.numPokedex);
            this.Controls.Add(this.movimientoPokemon);
            this.Controls.Add(this.habilidadPokemon);
            this.Controls.Add(this.tipoPokemon);
            this.Controls.Add(this.habitatPokemon);
            this.Controls.Add(this.especiePokemon);
            this.Controls.Add(this.alturaPokemon);
            this.Controls.Add(this.pesoPokemon);
            this.Controls.Add(this.fotoPokemon);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.boton_der);
            this.Controls.Add(this.boton_izq);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boton_izq;
        private System.Windows.Forms.Button boton_der;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.PictureBox fotoPokemon;
        private System.Windows.Forms.Label pesoPokemon;
        private System.Windows.Forms.Label alturaPokemon;
        private System.Windows.Forms.Label especiePokemon;
        private System.Windows.Forms.Label habitatPokemon;
        private System.Windows.Forms.Label tipoPokemon;
        private System.Windows.Forms.Label habilidadPokemon;
        private System.Windows.Forms.Label movimientoPokemon;
        private System.Windows.Forms.Label numPokedex;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

