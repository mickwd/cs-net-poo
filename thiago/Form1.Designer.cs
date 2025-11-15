namespace thiago
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
            this.cmd_volar_todo = new System.Windows.Forms.Button();
            this.cmd_altura_promedio = new System.Windows.Forms.Button();
            this.cmd_ordenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmd_cargar
            // 
            this.cmd_cargar.Location = new System.Drawing.Point(13, 392);
            this.cmd_cargar.Name = "cmd_cargar";
            this.cmd_cargar.Size = new System.Drawing.Size(143, 46);
            this.cmd_cargar.TabIndex = 1;
            this.cmd_cargar.Text = "Cargar";
            this.cmd_cargar.UseVisualStyleBackColor = true;
            this.cmd_cargar.Click += new System.EventHandler(this.cmd_cargar_Click);
            // 
            // cmd_volar_todo
            // 
            this.cmd_volar_todo.Location = new System.Drawing.Point(162, 392);
            this.cmd_volar_todo.Name = "cmd_volar_todo";
            this.cmd_volar_todo.Size = new System.Drawing.Size(143, 46);
            this.cmd_volar_todo.TabIndex = 2;
            this.cmd_volar_todo.Text = "Poner todo en vuelo";
            this.cmd_volar_todo.UseVisualStyleBackColor = true;
            this.cmd_volar_todo.Click += new System.EventHandler(this.cmd_volar_todo_Click);
            // 
            // cmd_altura_promedio
            // 
            this.cmd_altura_promedio.Location = new System.Drawing.Point(311, 392);
            this.cmd_altura_promedio.Name = "cmd_altura_promedio";
            this.cmd_altura_promedio.Size = new System.Drawing.Size(143, 46);
            this.cmd_altura_promedio.TabIndex = 3;
            this.cmd_altura_promedio.Text = "Calcular altura promedio";
            this.cmd_altura_promedio.UseVisualStyleBackColor = true;
            this.cmd_altura_promedio.Click += new System.EventHandler(this.cmd_altura_promedio_Click);
            // 
            // cmd_ordenar
            // 
            this.cmd_ordenar.Location = new System.Drawing.Point(460, 392);
            this.cmd_ordenar.Name = "cmd_ordenar";
            this.cmd_ordenar.Size = new System.Drawing.Size(143, 46);
            this.cmd_ordenar.TabIndex = 4;
            this.cmd_ordenar.Text = "Ordenar";
            this.cmd_ordenar.UseVisualStyleBackColor = true;
            this.cmd_ordenar.Click += new System.EventHandler(this.cmd_ordenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.cmd_ordenar);
            this.Controls.Add(this.cmd_altura_promedio);
            this.Controls.Add(this.cmd_volar_todo);
            this.Controls.Add(this.cmd_cargar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmd_cargar;
        private System.Windows.Forms.Button cmd_volar_todo;
        private System.Windows.Forms.Button cmd_altura_promedio;
        private System.Windows.Forms.Button cmd_ordenar;
    }
}

