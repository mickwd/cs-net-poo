using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("plato", "Plato");
            dataGridView1.Columns.Add("costo", "Costo");
        }

        Restaurante _Restaurante = new Restaurante();
        List<Plato> platos = new List<Plato>();

        
        private void ActualizarPlatos()
        {
            foreach (Plato X in platos)
            {
                string ingredientes_txt = "";
                foreach (Ingrediente Y in X.)
                {
                    ingredientes_txt += $"{Y.Nombre}, ";
                }

                dataGridView1.Rows.Add(ingredientes_txt, X.Costo);
            }
        }

        private void cmd_sacar_platos_Click(object sender, EventArgs e)
        {
            platos.Add(_Restaurante.SacarPlato(new Chef()));
            platos.Add(_Restaurante.SacarPlato(new Chef()));
            platos.Add(_Restaurante.SacarPlato(new Repostero()));

            ActualizarPlatos();
        }

        private void cmd_consultar_costos_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Costo totol de todos los platos: {_Restaurante.CostoTotal}");
        }
    }
}
