using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#region Punto 1
using BL;
#endregion

namespace thiago
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Flota flota = new Flota();

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Punto 7
            dataGridView1.Columns.Clear();
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("matricula", "Matricula");
            dataGridView1.Columns.Add("altura", "Altura");
            dataGridView1.Columns.Add("velocidad", "Velocidad (km/h)");
            dataGridView1.Columns.Add("volando", "Volando");
            #endregion
        }

        private void Actualizar()
        {
            dataGridView1.Rows.Clear();

            foreach (Avion x in flota)
            {
                dataGridView1.Rows.Add(x.Nombre, x.Matricula, x.AlturaMaxima.ToString(), x.CalcularVelocidadMaxima().ToString(), x.Volando.ToString());
            }
        }

        private void cmd_cargar_Click(object sender, EventArgs e)
        {
            flota.Agregar(new Boeing747("N842KT") { Nombre = "Boeing 747 1", AlturaMaxima = 5000, Volando = false });
            flota.Agregar(new Boeing747("N843KT") { Nombre = "Boeing 747 2", AlturaMaxima = 4500, Volando = false });
            flota.Agregar(new Avioneta("LV-ZQF") { Nombre = "Avioneta 1", AlturaMaxima = 2500, Volando = false });
            flota.Agregar(new Avioneta("LV-ZQF") { Nombre = "Avioneta 0", AlturaMaxima = 2300, Volando = false });
            flota.Agregar(new Planeador("EC-MZT") { Nombre = "Planeador 1", AlturaMaxima = 1200, Volando = false });
            flota.Agregar(new Planeador("EC-MZU") { Nombre = "Planeador 2", AlturaMaxima = 1150, Volando = false });
            flota.Agregar(new F19("XA-RDN") { Nombre = "F19 1", AlturaMaxima = 9200, Volando = false });
            flota.Agregar(new F19("XA-RDM") { Nombre = "F19 2", AlturaMaxima = 11000, Volando = false });

            Actualizar();
        }

        private void cmd_volar_todo_Click(object sender, EventArgs e)
        {
            flota.PonerTodoEnVuelo(true);

            Actualizar();
        }

        private void cmd_altura_promedio_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"La altura promedio de la flota es de {flota.CalcularAlturaPromedio()} metros sobre el nivel del mar.");
        }

        private void cmd_ordenar_Click(object sender, EventArgs e)
        {
            flota.Ordenar();

            Actualizar();
        }
    }
}
