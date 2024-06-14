namespace Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbresultados = new System.Windows.Forms.ListBox();
            this.tbbuscar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbIngresar = new System.Windows.Forms.TextBox();
            this.lbpromedio = new System.Windows.Forms.Label();
            this.rbsecuencial = new System.Windows.Forms.RadioButton();
            this.rbbinario = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIngresar);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Número";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbbinario);
            this.groupBox2.Controls.Add(this.rbsecuencial);
            this.groupBox2.Location = new System.Drawing.Point(41, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 69);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metodo de busqueda";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbresultados);
            this.groupBox3.Location = new System.Drawing.Point(380, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 348);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista ordenada";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbpromedio);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(12, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 83);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar promedio";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.tbbuscar);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(12, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(362, 175);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Busqueda de número";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbresultados
            // 
            this.lbresultados.FormattingEnabled = true;
            this.lbresultados.Location = new System.Drawing.Point(6, 16);
            this.lbresultados.Name = "lbresultados";
            this.lbresultados.Size = new System.Drawing.Size(157, 329);
            this.lbresultados.TabIndex = 0;
            // 
            // tbbuscar
            // 
            this.tbbuscar.Location = new System.Drawing.Point(41, 40);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(100, 20);
            this.tbbuscar.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Búsqueda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(201, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "Agregar Numero";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbIngresar
            // 
            this.tbIngresar.Location = new System.Drawing.Point(41, 26);
            this.tbIngresar.Name = "tbIngresar";
            this.tbIngresar.Size = new System.Drawing.Size(120, 20);
            this.tbIngresar.TabIndex = 5;
            // 
            // lbpromedio
            // 
            this.lbpromedio.AutoSize = true;
            this.lbpromedio.Location = new System.Drawing.Point(79, 41);
            this.lbpromedio.Name = "lbpromedio";
            this.lbpromedio.Size = new System.Drawing.Size(51, 13);
            this.lbpromedio.TabIndex = 6;
            this.lbpromedio.Text = "Promedio";
            // 
            // rbsecuencial
            // 
            this.rbsecuencial.AutoSize = true;
            this.rbsecuencial.Location = new System.Drawing.Point(6, 16);
            this.rbsecuencial.Name = "rbsecuencial";
            this.rbsecuencial.Size = new System.Drawing.Size(78, 17);
            this.rbsecuencial.TabIndex = 0;
            this.rbsecuencial.TabStop = true;
            this.rbsecuencial.Text = "Secuencial";
            this.rbsecuencial.UseVisualStyleBackColor = true;
            // 
            // rbbinario
            // 
            this.rbbinario.AutoSize = true;
            this.rbbinario.Location = new System.Drawing.Point(6, 39);
            this.rbbinario.Name = "rbbinario";
            this.rbbinario.Size = new System.Drawing.Size(57, 17);
            this.rbbinario.TabIndex = 1;
            this.rbbinario.TabStop = true;
            this.rbbinario.Text = "Binario";
            this.rbbinario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIngresar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbresultados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbbinario;
        private System.Windows.Forms.RadioButton rbsecuencial;
        private System.Windows.Forms.Label lbpromedio;
    }
}

