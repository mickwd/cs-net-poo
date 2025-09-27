namespace Thiago
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
            this.data = new System.Windows.Forms.DataGridView();
            this.label_edad = new System.Windows.Forms.Label();
            this.input_edad = new System.Windows.Forms.TextBox();
            this.input_color = new System.Windows.Forms.TextBox();
            this.label_color = new System.Windows.Forms.Label();
            this.label_sexo = new System.Windows.Forms.Label();
            this.box_sexo = new System.Windows.Forms.ComboBox();
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.cmd_alimentar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(13, 13);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(433, 425);
            this.data.TabIndex = 0;
            // 
            // label_edad
            // 
            this.label_edad.AutoSize = true;
            this.label_edad.Location = new System.Drawing.Point(465, 91);
            this.label_edad.Name = "label_edad";
            this.label_edad.Size = new System.Drawing.Size(32, 13);
            this.label_edad.TabIndex = 1;
            this.label_edad.Text = "Edad";
            // 
            // input_edad
            // 
            this.input_edad.Location = new System.Drawing.Point(468, 107);
            this.input_edad.Name = "input_edad";
            this.input_edad.Size = new System.Drawing.Size(261, 20);
            this.input_edad.TabIndex = 2;
            // 
            // input_color
            // 
            this.input_color.Location = new System.Drawing.Point(468, 146);
            this.input_color.Name = "input_color";
            this.input_color.Size = new System.Drawing.Size(261, 20);
            this.input_color.TabIndex = 4;
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Location = new System.Drawing.Point(465, 130);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(31, 13);
            this.label_color.TabIndex = 3;
            this.label_color.Text = "Color";
            // 
            // label_sexo
            // 
            this.label_sexo.AutoSize = true;
            this.label_sexo.Location = new System.Drawing.Point(465, 169);
            this.label_sexo.Name = "label_sexo";
            this.label_sexo.Size = new System.Drawing.Size(31, 13);
            this.label_sexo.TabIndex = 5;
            this.label_sexo.Text = "Sexo";
            // 
            // box_sexo
            // 
            this.box_sexo.FormattingEnabled = true;
            this.box_sexo.Location = new System.Drawing.Point(469, 185);
            this.box_sexo.Name = "box_sexo";
            this.box_sexo.Size = new System.Drawing.Size(260, 21);
            this.box_sexo.TabIndex = 6;
            // 
            // cmd_agregar
            // 
            this.cmd_agregar.Location = new System.Drawing.Point(468, 296);
            this.cmd_agregar.Name = "cmd_agregar";
            this.cmd_agregar.Size = new System.Drawing.Size(261, 38);
            this.cmd_agregar.TabIndex = 7;
            this.cmd_agregar.Text = "Agregar gallina";
            this.cmd_agregar.UseVisualStyleBackColor = true;
            this.cmd_agregar.Click += new System.EventHandler(this.cmd_agregar_Click);
            // 
            // cmd_alimentar
            // 
            this.cmd_alimentar.Location = new System.Drawing.Point(468, 340);
            this.cmd_alimentar.Name = "cmd_alimentar";
            this.cmd_alimentar.Size = new System.Drawing.Size(261, 38);
            this.cmd_alimentar.TabIndex = 8;
            this.cmd_alimentar.Text = "Alimentar (1)";
            this.cmd_alimentar.UseVisualStyleBackColor = true;
            this.cmd_alimentar.Click += new System.EventHandler(this.cmd_alimentar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.cmd_alimentar);
            this.Controls.Add(this.cmd_agregar);
            this.Controls.Add(this.box_sexo);
            this.Controls.Add(this.label_sexo);
            this.Controls.Add(this.input_color);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.input_edad);
            this.Controls.Add(this.label_edad);
            this.Controls.Add(this.data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label_edad;
        private System.Windows.Forms.TextBox input_edad;
        private System.Windows.Forms.TextBox input_color;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.Label label_sexo;
        private System.Windows.Forms.ComboBox box_sexo;
        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.Button cmd_alimentar;
    }
}

