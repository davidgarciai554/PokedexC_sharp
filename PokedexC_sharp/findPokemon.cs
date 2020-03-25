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
    //David
    public partial class findPokemon : Form
    {   
        Conexion miConexion = new Conexion();
        DataTable pokemonPorNombre = new DataTable();
        VentanaPrincipal VP = new VentanaPrincipal();
        private VentanaPrincipal mainForm = null;
        public findPokemon(Form callingForm)
        {
            mainForm = callingForm as VentanaPrincipal;
            InitializeComponent();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            String nombrePokemon = _nombrePokemon.Text;
            pokemonPorNombre = miConexion.getPokemonPorNombre(nombrePokemon);
            if (pokemonPorNombre.Rows.Count == 0)
            {
                label.Text = "El Pokemon que ha escrito no existe ,intentalo de nuevo";
            }
            else
            {
                VentanaPrincipal.idActual = int.Parse(pokemonPorNombre.Rows[0]["id"].ToString());
                this.mainForm.setPokemonInfo(VentanaPrincipal.idActual);
                this.Hide();
            }
        }

        private void findPokemon_Load(object sender, EventArgs e)
        {

        }
    }
}
