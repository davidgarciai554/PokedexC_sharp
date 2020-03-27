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
    public partial class allPokemon : Form
    {
        Conexion miConexion = new Conexion();
        private VentanaPrincipal mainForm = null;
        public allPokemon(Form callingForm)
        {
            mainForm = callingForm as VentanaPrincipal;
            InitializeComponent();
            dataGridView1.DataSource = miConexion.getTodosPokemon();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VentanaPrincipal.idActual = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            this.mainForm.setPokemonInfo(VentanaPrincipal.idActual);
            this.Hide();
        }
    }
}
