using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();

        int idActual = 1;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void boton_izq_Click(object sender, EventArgs e)
        {
            idActual --;
            if (idActual <= 0) idActual = 151;

            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
        }

        private void boton_der_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151) idActual = 1;

            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
        }
    }
}
