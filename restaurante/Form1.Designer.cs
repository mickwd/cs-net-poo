namespace restaurante
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
            this.cmd_sacar_platos = new System.Windows.Forms.Button();
            this.cmd_consultar_costos = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.input_numero_mesa = new System.Windows.Forms.TextBox();
            this.cmd_sacar_plato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 129);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmd_sacar_platos
            // 
            this.cmd_sacar_platos.Location = new System.Drawing.Point(501, 22);
            this.cmd_sacar_platos.Name = "cmd_sacar_platos";
            this.cmd_sacar_platos.Size = new System.Drawing.Size(235, 57);
            this.cmd_sacar_platos.TabIndex = 1;
            this.cmd_sacar_platos.Text = "Sacar platos";
            this.cmd_sacar_platos.UseVisualStyleBackColor = true;
            this.cmd_sacar_platos.Click += new System.EventHandler(this.cmd_sacar_platos_Click);
            // 
            // cmd_consultar_costos
            // 
            this.cmd_consultar_costos.Location = new System.Drawing.Point(501, 85);
            this.cmd_consultar_costos.Name = "cmd_consultar_costos";
            this.cmd_consultar_costos.Size = new System.Drawing.Size(235, 57);
            this.cmd_consultar_costos.TabIndex = 2;
            this.cmd_consultar_costos.Text = "Consultar costos";
            this.cmd_consultar_costos.UseVisualStyleBackColor = true;
            this.cmd_consultar_costos.Click += new System.EventHandler(this.cmd_consultar_costos_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(501, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // input_numero_mesa
            // 
            this.input_numero_mesa.Location = new System.Drawing.Point(501, 231);
            this.input_numero_mesa.Name = "input_numero_mesa";
            this.input_numero_mesa.Size = new System.Drawing.Size(235, 20);
            this.input_numero_mesa.TabIndex = 4;
            // 
            // cmd_sacar_plato
            // 
            this.cmd_sacar_plato.Location = new System.Drawing.Point(501, 258);
            this.cmd_sacar_plato.Name = "cmd_sacar_plato";
            this.cmd_sacar_plato.Size = new System.Drawing.Size(235, 43);
            this.cmd_sacar_plato.TabIndex = 5;
            this.cmd_sacar_plato.Text = "Sacar plato (Individual)";
            this.cmd_sacar_plato.UseVisualStyleBackColor = true;
            this.cmd_sacar_plato.Click += new System.EventHandler(this.cmd_sacar_plato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.cmd_sacar_plato);
            this.Controls.Add(this.input_numero_mesa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmd_consultar_costos);
            this.Controls.Add(this.cmd_sacar_platos);
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
        private System.Windows.Forms.Button cmd_sacar_platos;
        private System.Windows.Forms.Button cmd_consultar_costos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox input_numero_mesa;
        private System.Windows.Forms.Button cmd_sacar_plato;
    }
}

