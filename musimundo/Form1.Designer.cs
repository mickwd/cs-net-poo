namespace musimundo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmd_cargar = new System.Windows.Forms.Button();
            this.cmd_apagartodo = new System.Windows.Forms.Button();
            this.input_entero = new System.Windows.Forms.TextBox();
            this.cmd_agregar_int = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(488, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmd_cargar
            // 
            this.cmd_cargar.Location = new System.Drawing.Point(464, 393);
            this.cmd_cargar.Name = "cmd_cargar";
            this.cmd_cargar.Size = new System.Drawing.Size(224, 41);
            this.cmd_cargar.TabIndex = 1;
            this.cmd_cargar.Text = "Cargar";
            this.cmd_cargar.UseVisualStyleBackColor = true;
            this.cmd_cargar.Click += new System.EventHandler(this.cmd_cargar_Click);
            // 
            // cmd_apagartodo
            // 
            this.cmd_apagartodo.Location = new System.Drawing.Point(234, 393);
            this.cmd_apagartodo.Name = "cmd_apagartodo";
            this.cmd_apagartodo.Size = new System.Drawing.Size(224, 41);
            this.cmd_apagartodo.TabIndex = 2;
            this.cmd_apagartodo.Text = "Apagar todo";
            this.cmd_apagartodo.UseVisualStyleBackColor = true;
            this.cmd_apagartodo.Click += new System.EventHandler(this.cmd_apagartodo_Click);
            // 
            // input_entero
            // 
            this.input_entero.Location = new System.Drawing.Point(13, 405);
            this.input_entero.Name = "input_entero";
            this.input_entero.Size = new System.Drawing.Size(100, 20);
            this.input_entero.TabIndex = 3;
            // 
            // cmd_agregar_int
            // 
            this.cmd_agregar_int.Location = new System.Drawing.Point(119, 405);
            this.cmd_agregar_int.Name = "cmd_agregar_int";
            this.cmd_agregar_int.Size = new System.Drawing.Size(93, 23);
            this.cmd_agregar_int.TabIndex = 4;
            this.cmd_agregar_int.Text = "Agregar entero";
            this.cmd_agregar_int.UseVisualStyleBackColor = true;
            this.cmd_agregar_int.Click += new System.EventHandler(this.cmd_agregar_int_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(507, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 368);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 446);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmd_agregar_int);
            this.Controls.Add(this.input_entero);
            this.Controls.Add(this.cmd_apagartodo);
            this.Controls.Add(this.cmd_cargar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmd_cargar;
        private System.Windows.Forms.Button cmd_apagartodo;
        private System.Windows.Forms.TextBox input_entero;
        private System.Windows.Forms.Button cmd_agregar_int;
        private System.Windows.Forms.ListBox listBox1;
    }
}

