using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ventas Centinela = null;

        private void CargarData(Ventas X)
        {
            if (X != null)
            {
                listBox1.Items.Add($"{X.Codigo} ~ {X.Importe}");
                CargarData(X.Siguiente);
            }
        }

        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            Ventas X = new Ventas(input_codigo.Text, int.Parse(input_importe.Text));

            if (Centinela == null)
            {
                Centinela = X;
            }
            else
            {
                Ventas aux = Centinela;
                Centinela = X;
                Centinela.Siguiente = aux;
            }

            listBox1.Items.Clear();
            CargarData(Centinela);
            ActualizarDgv();
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index == 0)
            {
                Centinela = Centinela.Siguiente;
            }
            else
            {
                EliminarRecursivo(Centinela, index, 1);
            }
            
            listBox1.Items.Clear();
            CargarData(Centinela);
            ActualizarDgv();
        }

        private void EliminarRecursivo(Ventas X, int index, int actual)
        {
            if (index == actual)
            {
                X.Siguiente = X.Siguiente?.Siguiente;
            }
            else
            {
                EliminarRecursivo(X.Siguiente, index, actual + 1);
            }
        }

        private void cmd_modificar_Click(object sender, EventArgs e)
        {
            Ventas Y = new Ventas(input_codigo.Text, int.Parse(input_importe.Text));
            int index = listBox1.SelectedIndex;

            if (index == 0)
            {
                Ventas aux = Centinela.Siguiente;
                Centinela = Y;
                Y.Siguiente = aux;
            }
            else
            {
                ModificarRecursivo(Centinela, Y, index, 1);
            }

            listBox1.Items.Clear();
            CargarData(Centinela);
            ActualizarDgv();
        }

        private void ModificarRecursivo(Ventas X, Ventas Y, int index, int actual)
        {
            if (index == actual)
            {
                X.Siguiente.Codigo = Y.Codigo;
                X.Siguiente.Importe = Y.Importe;
            }
            else
            {
                ModificarRecursivo(X.Siguiente, Y, index, actual + 1);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                string[] parts = listBox1.SelectedItem.ToString().Split('~');
                input_codigo.Text = parts[0].Trim();
                input_importe.Text = parts[1].Trim();
            }
        }

        private List<Ventas> Ordenar(Ventas X, List<Ventas> lista)
        {
            if (X == null)
            {
                return lista;
            }
            else
            {
                lista.Add(X);
                return Ordenar(X.Siguiente, lista);
            }
        }

        private void cmd_ordenar_mayor_Click(object sender, EventArgs e)
        {
            List<Ventas> lista = new List<Ventas>();
            lista = Ordenar(Centinela, lista);

            lista = lista.OrderByDescending(x => x.Codigo).ToList();

            listBox1.Items.Clear();
            
            foreach (Ventas X in lista)
            {
                listBox1.Items.Add($"{X.Codigo} ~ {X.Importe}");
            }
        }

        private void cmd_ordenar_menor_Click(object sender, EventArgs e)
        {
            List<Ventas> lista = new List<Ventas>();
            lista = Ordenar(Centinela, lista);

            lista = lista.OrderBy(x => x.Codigo).ToList();

            listBox1.Items.Clear();

            foreach (Ventas X in lista)
            {
                listBox1.Items.Add($"{X.Codigo} ~ {X.Importe}");
            }
        }

        private void cmd_cdc_Click(object sender, EventArgs e)
        {
            List<Ventas> lista = new List<Ventas>();
            lista = Ordenar(Centinela, lista);

            lista = lista.OrderBy(x => x.Codigo).ToList();

            listBox1.Items.Clear();

            lista = CDC(lista);

            listBox1.Items.Clear();
            foreach (Ventas X in lista)
            {
                listBox1.Items.Add($"{X.Codigo} ~ {X.Importe}");
            }
        }

        private List<Ventas> CDC(List<Ventas> lista)
        {
            List<Ventas> lista_cdc = new List<Ventas>();
            string temp_code = lista[0].Codigo;

            int importe_total = 0;
            int importe_parcial = 0;

            foreach (Ventas X in lista)
            {
                if (X.Codigo == temp_code)
                {
                    lista_cdc.Add(X);
                    importe_parcial += X.Importe;
                }
                else
                {
                    Ventas Y = new Ventas("Subtotal", importe_parcial);
                    lista_cdc.Add(Y);
                    importe_total += importe_parcial;
                    
                    importe_parcial = X.Importe;
                    lista_cdc.Add(X);
                    temp_code = X.Codigo;
                }
            }

            Ventas Z = new Ventas("Subtotal", importe_parcial);
            lista_cdc.Add(Z);
            Ventas Z1 = new Ventas("Total", importe_total + importe_parcial);
            lista_cdc.Add(Z1);

            return lista_cdc;
        }

        private string file = AppDomain.CurrentDomain.BaseDirectory + "db.txt";

        private void cmd_cargar_Click(object sender, EventArgs e)
        {
            Centinela = null;
            
            using (StreamReader reader = new StreamReader(file))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('~');
                    if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int importe))
                    {
                        Ventas X = new Ventas(parts[0].Trim(), importe);
                        
                        if (Centinela == null)
                        {
                            Centinela = X;
                        }
                        else
                        {
                            Ventas aux = Centinela;
                            Centinela = X;
                            Centinela.Siguiente = aux;
                        }
                    }
                }
            }

            listBox1.Items.Clear();
            CargarData(Centinela);
        }

        private void cmd_guardar_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                Ventas current = Centinela;
                while (current != null)
                {
                    writer.WriteLine($"{current.Codigo} ~ {current.Importe}");
                    current = current.Siguiente;
                }
            }
        }

        private void ActualizarDgv()
        {
            dgv.Columns.Add("Codigo", "Codigo");
            dgv.Columns.Add("Importe", "Importe");
            dgv.Rows.Clear();
            
            ActualizarDGV_Recursivo(Centinela);
        }

        private void ActualizarDGV_Recursivo(Ventas X)
        {
            if (X == null)
            {
                return;
            }
            else
            {
                dgv.Rows.Add($"{X.Codigo}", $"{X.Importe}");
                ActualizarDGV_Recursivo(X.Siguiente);
            }
        }
    }
}
