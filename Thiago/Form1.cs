using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Thiago
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            box_sexo.Items.Add(BL.Gallina._enum_sexo.Macho);
            box_sexo.Items.Add(BL.Gallina._enum_sexo.Hembra);
        }

        Gallinero _Gallinero = new Gallinero();

        private void Actualizar()
        {
            data.DataSource = null;
            data.DataSource = _Gallinero.ListarGallinas();
        }

        GallinaException GallinaException = new GallinaException();
        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Gallina X = new Gallina(input_color.Text, int.Parse(input_edad.Text), (Gallina._enum_sexo)box_sexo.SelectedItem);
                _Gallinero.AgregarGallina(X);
                Actualizar();
            }
            catch (GallinaException ex)
            {
                MessageBox.Show($"La edad de la gallina ({input_edad.Text}) no puede ser mayor a 15.");
            }
        }

        private void cmd_alimentar_Click(object sender, EventArgs e)
        {
            _Gallinero.Alimentar(1);
            Actualizar();
        }
    }
}
