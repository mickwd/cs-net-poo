using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musimundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RedElectrica _redelectrica = new RedElectrica();
       

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("electrodomestico", "Electrodomestico");
            dataGridView1.Columns.Add("consumo", "Consumo");
            dataGridView1.Columns.Add("marca", "Marca");
            dataGridView1.Columns.Add("estado", "Estado");

            _redelectrica.EventoEPA += _redelectrica_EventoEPA;
        }

        private void _redelectrica_EventoEPA(object sender, EPAEventArgs e)
        {
            listBox1.Items.Add(e.CodigoCertificacion);
        }

        private void Actualizar()
        {
            dataGridView1.Rows.Clear();

            foreach (Electrodomestico X in _redelectrica._lista_electrodomesticos)
            {
                dataGridView1.Rows.Add(X.Nombre, X.Consumo.ToString(), X.Marca, X.Encendido);
            }
        }

        private void cmd_cargar_Click(object sender, EventArgs e)
        {
            _redelectrica.Agregar(new Heladera() { Nombre = "Heladera 1", CapacidadLitros = 400, CodigoCertificacion = "01" });
            _redelectrica.Agregar(new Heladera() { Nombre = "Heladera 2", CapacidadLitros = 600, CodigoCertificacion = "02" });
            _redelectrica.Agregar(new Televisor() { Nombre = "Televisor 1", Pulgadas = 32, CodigoCertificacion = "03" });
            _redelectrica.Agregar(new Televisor() { Nombre = "Televisor 2", Pulgadas = 55, CodigoCertificacion = "04" });
            _redelectrica.Agregar(new AireAcondicionado() { Nombre = "AC", Frigorias = 600, Tipo = AireAcondicionado._tipoAire.Comun });
            _redelectrica.Agregar(new AireAcondicionado() { Nombre = "AC", Frigorias = 1200, Tipo = AireAcondicionado._tipoAire.Inverter });

            Actualizar();
        }

        private void cmd_apagartodo_Click(object sender, EventArgs e)
        {
            _redelectrica.CortarCorriente();

            Actualizar();
        }

        private void cmd_agregar_int_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            Heladera heladera = new Heladera();
            heladera = (Heladera)_redelectrica._lista_electrodomesticos[index];
            heladera.CapacidadLitros += int.Parse(input_entero.Text);

            _redelectrica.Agregar(heladera);
            Actualizar();
        }
    }
}
