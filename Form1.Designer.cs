namespace app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_codigo = new System.Windows.Forms.TextBox();
            this.input_importe = new System.Windows.Forms.TextBox();
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_modificar = new System.Windows.Forms.Button();
            this.cmd_ordenar_mayor = new System.Windows.Forms.Button();
            this.cmd_ordenar_menor = new System.Windows.Forms.Button();
            this.cmd_cdc = new System.Windows.Forms.Button();
            this.cmd_cargar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmd_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 511);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Importe de Venta";
            // 
            // input_codigo
            // 
            this.input_codigo.Location = new System.Drawing.Point(312, 56);
            this.input_codigo.Name = "input_codigo";
            this.input_codigo.Size = new System.Drawing.Size(242, 20);
            this.input_codigo.TabIndex = 3;
            // 
            // input_importe
            // 
            this.input_importe.Location = new System.Drawing.Point(312, 104);
            this.input_importe.Name = "input_importe";
            this.input_importe.Size = new System.Drawing.Size(242, 20);
            this.input_importe.TabIndex = 4;
            // 
            // cmd_agregar
            // 
            this.cmd_agregar.Location = new System.Drawing.Point(312, 167);
            this.cmd_agregar.Name = "cmd_agregar";
            this.cmd_agregar.Size = new System.Drawing.Size(242, 39);
            this.cmd_agregar.TabIndex = 5;
            this.cmd_agregar.Text = "Agregar";
            this.cmd_agregar.UseVisualStyleBackColor = true;
            this.cmd_agregar.Click += new System.EventHandler(this.cmd_agregar_Click);
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.Location = new System.Drawing.Point(312, 212);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(242, 39);
            this.cmd_eliminar.TabIndex = 6;
            this.cmd_eliminar.Text = "Eliminar";
            this.cmd_eliminar.UseVisualStyleBackColor = true;
            this.cmd_eliminar.Click += new System.EventHandler(this.cmd_eliminar_Click);
            // 
            // cmd_modificar
            // 
            this.cmd_modificar.Location = new System.Drawing.Point(312, 257);
            this.cmd_modificar.Name = "cmd_modificar";
            this.cmd_modificar.Size = new System.Drawing.Size(242, 39);
            this.cmd_modificar.TabIndex = 7;
            this.cmd_modificar.Text = "Modificar";
            this.cmd_modificar.UseVisualStyleBackColor = true;
            this.cmd_modificar.Click += new System.EventHandler(this.cmd_modificar_Click);
            // 
            // cmd_ordenar_mayor
            // 
            this.cmd_ordenar_mayor.Location = new System.Drawing.Point(312, 302);
            this.cmd_ordenar_mayor.Name = "cmd_ordenar_mayor";
            this.cmd_ordenar_mayor.Size = new System.Drawing.Size(242, 39);
            this.cmd_ordenar_mayor.TabIndex = 8;
            this.cmd_ordenar_mayor.Text = "Ordenar ><";
            this.cmd_ordenar_mayor.UseVisualStyleBackColor = true;
            this.cmd_ordenar_mayor.Click += new System.EventHandler(this.cmd_ordenar_mayor_Click);
            // 
            // cmd_ordenar_menor
            // 
            this.cmd_ordenar_menor.Location = new System.Drawing.Point(312, 347);
            this.cmd_ordenar_menor.Name = "cmd_ordenar_menor";
            this.cmd_ordenar_menor.Size = new System.Drawing.Size(242, 39);
            this.cmd_ordenar_menor.TabIndex = 9;
            this.cmd_ordenar_menor.Text = "Ordenar <>";
            this.cmd_ordenar_menor.UseVisualStyleBackColor = true;
            this.cmd_ordenar_menor.Click += new System.EventHandler(this.cmd_ordenar_menor_Click);
            // 
            // cmd_cdc
            // 
            this.cmd_cdc.Location = new System.Drawing.Point(312, 392);
            this.cmd_cdc.Name = "cmd_cdc";
            this.cmd_cdc.Size = new System.Drawing.Size(242, 39);
            this.cmd_cdc.TabIndex = 10;
            this.cmd_cdc.Text = "CDC";
            this.cmd_cdc.UseVisualStyleBackColor = true;
            this.cmd_cdc.Click += new System.EventHandler(this.cmd_cdc_Click);
            // 
            // cmd_cargar
            // 
            this.cmd_cargar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmd_cargar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_cargar.Location = new System.Drawing.Point(312, 437);
            this.cmd_cargar.Name = "cmd_cargar";
            this.cmd_cargar.Size = new System.Drawing.Size(242, 39);
            this.cmd_cargar.TabIndex = 11;
            this.cmd_cargar.Text = "Cargar";
            this.cmd_cargar.UseVisualStyleBackColor = false;
            this.cmd_cargar.Click += new System.EventHandler(this.cmd_cargar_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(568, 13);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(309, 511);
            this.dgv.TabIndex = 12;
            // 
            // cmd_guardar
            // 
            this.cmd_guardar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmd_guardar.Location = new System.Drawing.Point(312, 482);
            this.cmd_guardar.Name = "cmd_guardar";
            this.cmd_guardar.Size = new System.Drawing.Size(242, 39);
            this.cmd_guardar.TabIndex = 13;
            this.cmd_guardar.Text = "Guardar";
            this.cmd_guardar.UseVisualStyleBackColor = false;
            this.cmd_guardar.Click += new System.EventHandler(this.cmd_guardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 533);
            this.Controls.Add(this.cmd_guardar);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cmd_cargar);
            this.Controls.Add(this.cmd_cdc);
            this.Controls.Add(this.cmd_ordenar_menor);
            this.Controls.Add(this.cmd_ordenar_mayor);
            this.Controls.Add(this.cmd_modificar);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_agregar);
            this.Controls.Add(this.input_importe);
            this.Controls.Add(this.input_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_codigo;
        private System.Windows.Forms.TextBox input_importe;
        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_modificar;
        private System.Windows.Forms.Button cmd_ordenar_mayor;
        private System.Windows.Forms.Button cmd_ordenar_menor;
        private System.Windows.Forms.Button cmd_cdc;
        private System.Windows.Forms.Button cmd_cargar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button cmd_guardar;
    }
}

