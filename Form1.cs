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

// Programado por https://github.com/mickwd
// Es posible que el puente del DGV no funcione en todos los casos. Se hizo simplemente con el fin de mostrar los
// datos cuando se agregan, modifican o eliminan. Lo unico que faltaria hacer seria aumentar los casos en los que
// se actualiza el DGV & hacer las validaciones solicitadas para el "input_codigo" y que "input_importe" solo sea
// int.
// Se valora una ⭐ en el repo (https://github.com/mickwd/csharp-data) !

namespace app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Ventas Centinela = null; // Al cargar el programa, se inicia en Centinela null. Para poder operar sobre el mismo.

        private void CargarData(Ventas X) // Metodo recursivo para poder cargar el listbox con los nodos.
        {
            if (X != null)
            {
                listBox1.Items.Add($"{X.Codigo} ~ {X.Importe}"); // Agrega el nodo actual al listbox separado con un '~'.
                CargarData(X.Siguiente); // Llamada recursiva para el siguiente nodo.
            }
        }

        // ===============================================
        //             Agregar ventas
        // ===============================================
        // Para agregar ventas no necesitamos usar ningun metodo recursivo por que se agrega arriba de todo, no hace falta recorrer la lista para encontrar un final.
        // *** en caso de que se agregue al final, se tiene que hacer un metodo recursivo para saber cual es el final (hay metodos recursivos mas adelante, en eliminar y modificar).

        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            Ventas X = new Ventas(input_codigo.Text, int.Parse(input_importe.Text)); // Se crea un nodo con los datos ingresados en los input.

            if (Centinela == null) // Si no existe ningun nodo (centinela == null)
            {
                Centinela = X; // Se asigna el nodo creado como centinela (primer nodo).
            }
            else // Si ya existe algun nodo
            {
                Ventas aux = Centinela; // Se guarda el primer nodo (centinela) en una variable auxiliar.
                Centinela = X; // Se establece que el primer nodo pasa a ser el nodo creado.
                Centinela.Siguiente = aux; // Se establece que el siguiente nodo del primer nodo (el nodo que acaba de pasar a ser centinela), es el centinela anterior, el aux que guardamos.
            }

            listBox1.Items.Clear(); // Limpiamos la lista.
            CargarData(Centinela); // Cargamos los datos a partir del primer nodo (centinela).
            ActualizarDgv(); // Actualizamos el DataGridView con los datos actuales ya que estamos.
        }

        // ===============================================
        //               Eliminar (Recursivo)
        // ===============================================
        // Ahora si necesitamos un metodo recursivo para eliminar un nodo, ya que tenemos que recorrer la lista para encontrar la posicion del nodo a eliminar.

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; // Ubicacion del nodo a eliminar.

            if (index == 0) // Si es el primer nodo, simplemente reemplazamos Centinela por su siguiente (Por = se borra).
            {
                Centinela = Centinela.Siguiente; // Reemplazamos el centinela por su siguiente nodo.
            }
            else
            {
                EliminarRecursivo(Centinela, index, 1); // Si no, seguimos con el metodo recursivo para eliminar el nodo en la posicion indicada.
            }
            
            listBox1.Items.Clear(); // Una vez eliminado el nodo, limpiamos la lista.
            CargarData(Centinela); // Cargamos los datos a partir del primer nodo (centinela).
            ActualizarDgv(); // Actualizamos el DataGridView con los datos actuales.
        }

        private void EliminarRecursivo(Ventas X, int index, int actual)
        {
            if (index == actual) // Si el index es igual a la cantidad de nodos recorridos (actual), significa que ya estmaos en el nodo a eliminar.
            {
                X.Siguiente = X.Siguiente?.Siguiente; // Reemplazamos el .Siguiente del nodo actual por su .Siguiente, eliminando el nodo. ('?' es para evitar "NullReferenceException" si X.Siguiente es null).
            }
            else
            {
                EliminarRecursivo(X.Siguiente, index, actual + 1); // Si no, seguimos recorriendo la lista, llamando al siguiente nodo y aumentando a "actual".
            }
        }

        // ===============================================
        //               Modificar (Recursivo)
        // ===============================================
        // Misma logica que eliminar, solo que en lugar de reemplazar, modificamos los valores del nodo.

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // Esto es para que se muestren los valores seleccionados en los inputs.
        {
            if (listBox1.SelectedItems.Count == 1) // Si solo se selecciona 1 item en el listbox.
            {
                string[] parts = listBox1.SelectedItem.ToString().Split('~'); // Separamos el texto seleccionado por el caracter '~'.
                input_codigo.Text = parts[0].Trim(); // Asignamos el primer elemento (codigo) al input_codigo, eliminando espacios en blanco al inicio y al final.
                input_importe.Text = parts[1].Trim(); // Asignamos el segundo elemento (importe) al input_importe, eliminando espacios en blanco al inicio y al final.
            }
        }

        private void cmd_modificar_Click(object sender, EventArgs e)
        {
            Ventas Y = new Ventas(input_codigo.Text, int.Parse(input_importe.Text)); // Creamos un nuevo nodo con los datos ingresados en los inputs.
            int index = listBox1.SelectedIndex; // Obtenemos el index del nodo seleccionado en el listbox.

            if (index == 0) // Si el nodo seleccionado es el primer nodo (centinela).
            {
                Ventas aux = Centinela.Siguiente; // Guardamos el siguiente nodo del centinela en una variable auxiliar.
                Centinela = Y; // Reemplazamos el centinela por el nodo creado con los nuevos datos.
                Y.Siguiente = aux; // Establecemos que el .Siguiente del nodo nuevo es el nodo auxiliar (el siguiente del centinela anterior).
            }
            else
            {
                ModificarRecursivo(Centinela, Y, index, 1); // Llamamos al metodo recursivo para modificar el nodo en la posicion indicada.
            }

            listBox1.Items.Clear(); // Limpiamos la lista.
            CargarData(Centinela); // Cargamos los datos a partir del primer nodo (centinela).
            ActualizarDgv(); // Actualizamos el DataGridView con los datos actuales.
        }

        private void ModificarRecursivo(Ventas X, Ventas Y, int index, int actual)
        {
            if (index == actual) // Si el index es igual a la cantidad de nodos recorridos (actual), significa que ya estamos en el nodo a modificar.
            {
                X.Siguiente.Codigo = Y.Codigo; // Modificamos el codigo del nodo actual con el codigo del nodo nuevo.
                X.Siguiente.Importe = Y.Importe; // Modificamos el importe del nodo actual con el importe del nodo nuevo.
            }
            else
            {
                ModificarRecursivo(X.Siguiente, Y, index, actual + 1); // Si no, seguimos recorriendo la lista, llamando al siguiente nodo y aumentando a "actual".
            }
        }

        // ===============================================
        //               Ordenar
        // ===============================================

        private List<Ventas> Ordenar(Ventas X, List<Ventas> lista)
        {
            if (X == null) // Si el nodo es null, significa que ya no hay mas nodos que recorrer.
            {
                return lista; // Devolvemos la lista acumulada.
            }
            else
            {
                lista.Add(X); // Agregamos el nodo actual a la lista.
                return Ordenar(X.Siguiente, lista); // Llamamos al metodo recursivo para el siguiente nodo, acumulando los nodos en la lista.
            }
        }

        private void cmd_ordenar_mayor_Click(object sender, EventArgs e) // Esto esta al reves, es menor a mayor.
        {
            List<Ventas> lista = new List<Ventas>(); // Creamos una lista para almacenar los nodos ordenados.
            lista = Ordenar(Centinela, lista); // Llamamos a "Ordenar" para llenar la lista con los nodos.

            lista = lista.OrderByDescending(x => x.Codigo).ToList(); // Ordenamos la lista por codigo de menor a mayor.

            listBox1.Items.Clear(); // Limpiamos el listbox antes de mostrar los datos ordenados.

            foreach (Ventas X in lista) // Recorremos la lista ordenada y agregamos los nodos al listbox.
            {
                listBox1.Items.Add($"{X.Codigo} ~ {X.Importe}"); // Agregamos cada nodo al listbox en el formato "Codigo ~ Importe".
            }
        }

        private void cmd_ordenar_menor_Click(object sender, EventArgs e) // Esto esta al reves, es mayor a menor.
        {
            List<Ventas> lista = new List<Ventas>(); // Creamos una lista para almacenar los nodos ordenados.
            lista = Ordenar(Centinela, lista); // Llamamos a "Ordenar" para llenar la lista con los nodos.

            lista = lista.OrderBy(x => x.Codigo).ToList(); // Ordenamos la lista por codigo de mayor a menor.

            listBox1.Items.Clear(); // Limpiamos el listbox antes de mostrar los datos ordenados.

            foreach (Ventas X in lista) // Recorremos la lista ordenada y agregamos los nodos al listbox.
            {
                listBox1.Items.Add($"{X.Codigo} ~ {X.Importe}"); // Agregamos cada nodo al listbox en el formato "Codigo ~ Importe".
            }
        }

        // ===============================================
        //               CDC (Corte de Control)
        // ===============================================

        private void cmd_cdc_Click(object sender, EventArgs e)
        {
            List<Ventas> lista = new List<Ventas>(); // Creamos una lista para almacenar los nodos ordenados.
            lista = Ordenar(Centinela, lista); // Llamamos a "Ordenar" para llenar la lista con los nodos.

            lista = lista.OrderBy(x => x.Codigo).ToList(); // Ordenamos la lista por codigo de menor a mayor.

            listBox1.Items.Clear(); // Limpiamos el listbox antes de mostrar los datos ordenados.

            lista = CDC(lista); // Llamamos al metodo CDC para agregar subtotales y total a la lista.

            listBox1.Items.Clear(); // Limpiamos el listbox antes de mostrar los datos con subtotales y total.
            foreach (Ventas X in lista) // Recorremos la lista con subtotales y total y agregamos los nodos al listbox.
            {
                listBox1.Items.Add($"{X.Codigo} ~ {X.Importe}"); // Agregamos cada nodo al listbox en el formato "Codigo ~ Importe".
            }
        }

        private List<Ventas> CDC(List<Ventas> lista)
        {
            List<Ventas> lista_cdc = new List<Ventas>(); // Creamos una nueva lista para almacenar los nodos con subtotales y total.
            string temp_code = lista[0].Codigo; // Guardamos el codigo del primer nodo para comparar con los siguientes.

            int importe_total = 0; // Variable para acumular el importe total de todas las ventas.
            int importe_parcial = 0; // Variable para acumular el importe parcial de las ventas con el mismo codigo.

            foreach (Ventas X in lista) // Recorremos la lista de ventas ordenadas.
            {
                if (X.Codigo == temp_code) // Si el codigo del nodo actual es igual al codigo temporal (del primer nodo o del ultimo agregado).
                {
                    lista_cdc.Add(X); // Agregamos el nodo actual a la lista de corte de control.
                    importe_parcial += X.Importe; // Acumulamos el importe del nodo actual al importe parcial.
                }
                else
                {
                    Ventas Y = new Ventas("Subtotal", importe_parcial); // Creamos un nuevo nodo con el codigo "Subtotal" y el importe parcial acumulado.
                    lista_cdc.Add(Y); // Agregamos el nodo de subtotal a la lista de corte de control.
                    importe_total += importe_parcial; // Acumulamos el importe parcial al importe total.

                    importe_parcial = X.Importe; // Reiniciamos el importe parcial con el importe del nodo actual.
                    lista_cdc.Add(X); // Agregamos el nodo actual a la lista de corte de control.
                    temp_code = X.Codigo; // Actualizamos el codigo temporal con el codigo del nodo actual.
                }
            }

            Ventas Z = new Ventas("Subtotal", importe_parcial); // Creamos un nuevo nodo con el codigo "Subtotal" y el importe parcial acumulado del ultimo grupo de ventas.
            lista_cdc.Add(Z); // Agregamos el nodo de subtotal a la lista de corte de control.
            Ventas Z1 = new Ventas("Total", importe_total + importe_parcial); // Creamos un nuevo nodo con el codigo "Total" y el importe total acumulado de todas las ventas.
            lista_cdc.Add(Z1); // Agregamos el nodo de total a la lista de corte de control.

            return lista_cdc; // Devolvemos la lista de corte de control con los nodos originales, subtotales y total.
        }


        // ===============================================
        //          Cargar y Guardar (Archivo .txt)
        // ===============================================

        // (!) Importante usar este metodo.
        private string file = AppDomain.CurrentDomain.BaseDirectory + "db.txt"; // Ruta del archivo donde se guardaran los datos.
        private void cmd_cargar_Click(object sender, EventArgs e)
        {
            Centinela = null; // Reiniciamos el centinela a null para empezar de nuevo al cargar los datos desde el archivo.

            using (StreamReader reader = new StreamReader(file)) // Abrimos el archivo en modo lectura.
            {
                string line; // variable para almacenar cada linea leida del archivo.
                while ((line = reader.ReadLine()) != null) // Leemos el archivo linea por linea hasta que no haya mas lineas.
                {
                    string[] parts = line.Split('~'); // Separamos cada linea por el caracter '~' para obtener el codigo y el importe.
                    if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int importe)) // Verificamos que la linea tenga dos partes y que el importe sea un numero valido.
                    {
                        Ventas X = new Ventas(parts[0].Trim(), importe); // Creamos un nuevo nodo con el codigo y el importe leidos del archivo.

                        if (Centinela == null) // Si el centinela es null, significa que es el primer nodo que se agrega al inicio de la lista.
                        {
                            Centinela = X; // Asignamos el nodo creado como centinela (primer nodo).
                        }
                        else
                        {
                            Ventas aux = Centinela; // Guardamos el centinela actual en una variable auxiliar.
                            Centinela = X; // Asignamos el nodo creado como nuevo centinela (primer nodo).
                            Centinela.Siguiente = aux; // Establecemos que el siguiente nodo del nuevo centinela es el centinela anterior (el aux que guardamos).
                        }
                    }
                }
            }

            listBox1.Items.Clear(); // Limpiamos el listbox antes de cargar los datos.
            CargarData(Centinela); // Cargamos los datos a partir del primer nodo (centinela) al listbox.
        }

        private void cmd_guardar_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(file)) // Abrimos el archivo en modo escritura (esto sobreescribira el archivo si ya existe).
            {
                Ventas current = Centinela; // Comenzamos desde el centinela (primer nodo).
                while (current != null) // Mientras haya nodos en la lista.
                {
                    writer.WriteLine($"{current.Codigo} ~ {current.Importe}"); // Escribimos cada nodo en el archivo en el formato "Codigo ~ Importe".
                    current = current.Siguiente; // Avanzamos al siguiente nodo.
                }
            }
        }

        // ===============================================
        //               Puente con DataGridView
        // ===============================================

        private void ActualizarDgv()
        {
            dgv.Columns.Add("Codigo", "Codigo"); // Agregamos una columna para el codigo.
            dgv.Columns.Add("Importe", "Importe"); // Agregamos una columna para el importe.
            dgv.Rows.Clear(); // Limpiamos las filas del DataGridView antes de agregar los nuevos datos.

            ActualizarDGV_Recursivo(Centinela); // Llamamos al metodo recursivo para llenar el DataGridView con los datos de la lista de ventas.
        }

        private void ActualizarDGV_Recursivo(Ventas X)
        {
            if (X == null) // Si el nodo es null, significa que ya no hay mas nodos que recorrer.
            {
                return; // Terminamos la recursion.
            }
            else
            {
                dgv.Rows.Add($"{X.Codigo}", $"{X.Importe}"); // Agregamos una nueva fila al DataGridView con el codigo y el importe del nodo actual.
                ActualizarDGV_Recursivo(X.Siguiente); // Llamamos al metodo recursivo para el siguiente nodo.
            }
        }
    }
}
