namespace Proyecto1_AnalizadorLexico
{
    partial class FormEntorno
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
            this.richTextBoxCuadroCompilacion = new System.Windows.Forms.RichTextBox();
            this.buttonCompilar = new System.Windows.Forms.Button();
            this.richTextBoxCuadroError = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAnalizador = new System.Windows.Forms.Panel();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelFila = new System.Windows.Forms.Label();
            this.labelColumna = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonSeleccionarProyecto = new System.Windows.Forms.Button();
            this.buttonCrearProyecto = new System.Windows.Forms.Button();
            this.buttonEliminarProyecto = new System.Windows.Forms.Button();
            this.buttonCrearArchivo = new System.Windows.Forms.Button();
            this.buttonEliminarArchivo = new System.Windows.Forms.Button();
            this.panelCrearArchivo = new System.Windows.Forms.Panel();
            this.textBoxNombreArchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCrearArchivo1 = new System.Windows.Forms.Button();
            this.buttonRetrocederArchivo = new System.Windows.Forms.Button();
            this.panelCrearProyecto = new System.Windows.Forms.Panel();
            this.buttonRetrocederCrearProyecto = new System.Windows.Forms.Button();
            this.buttonCrearProyecto1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCrearProyecto1 = new System.Windows.Forms.TextBox();
            this.panelAnalizador.SuspendLayout();
            this.panelCrearArchivo.SuspendLayout();
            this.panelCrearProyecto.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxCuadroCompilacion
            // 
            this.richTextBoxCuadroCompilacion.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBoxCuadroCompilacion.Location = new System.Drawing.Point(20, 30);
            this.richTextBoxCuadroCompilacion.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxCuadroCompilacion.Name = "richTextBoxCuadroCompilacion";
            this.richTextBoxCuadroCompilacion.Size = new System.Drawing.Size(813, 312);
            this.richTextBoxCuadroCompilacion.TabIndex = 1;
            this.richTextBoxCuadroCompilacion.Text = "";
            this.richTextBoxCuadroCompilacion.SelectionChanged += new System.EventHandler(this.richTextBoxCuadroCompilacion_SelectionChanged);
            this.richTextBoxCuadroCompilacion.CursorChanged += new System.EventHandler(this.richTextBoxCuadroCompilacion_CursorChanged);
            this.richTextBoxCuadroCompilacion.LocationChanged += new System.EventHandler(this.richTextBoxCuadroCompilacion_LocationChanged);
            this.richTextBoxCuadroCompilacion.TextChanged += new System.EventHandler(this.richTextBoxCuadro_TextChanged);
            // 
            // buttonCompilar
            // 
            this.buttonCompilar.Location = new System.Drawing.Point(20, 2);
            this.buttonCompilar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCompilar.Name = "buttonCompilar";
            this.buttonCompilar.Size = new System.Drawing.Size(95, 24);
            this.buttonCompilar.TabIndex = 3;
            this.buttonCompilar.Text = "Compilar";
            this.buttonCompilar.UseVisualStyleBackColor = true;
            this.buttonCompilar.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxCuadroError
            // 
            this.richTextBoxCuadroError.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCuadroError.Location = new System.Drawing.Point(20, 399);
            this.richTextBoxCuadroError.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxCuadroError.Name = "richTextBoxCuadroError";
            this.richTextBoxCuadroError.Size = new System.Drawing.Size(813, 145);
            this.richTextBoxCuadroError.TabIndex = 4;
            this.richTextBoxCuadroError.Text = "";
            this.richTextBoxCuadroError.TextChanged += new System.EventHandler(this.richTextBoxCuadroError_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelAnalizador
            // 
            this.panelAnalizador.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAnalizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAnalizador.Controls.Add(this.buttonGuardar);
            this.panelAnalizador.Controls.Add(this.labelFila);
            this.panelAnalizador.Controls.Add(this.labelColumna);
            this.panelAnalizador.Controls.Add(this.richTextBoxCuadroCompilacion);
            this.panelAnalizador.Controls.Add(this.richTextBoxCuadroError);
            this.panelAnalizador.Controls.Add(this.button1);
            this.panelAnalizador.Controls.Add(this.buttonCompilar);
            this.panelAnalizador.Location = new System.Drawing.Point(422, 11);
            this.panelAnalizador.Margin = new System.Windows.Forms.Padding(2);
            this.panelAnalizador.Name = "panelAnalizador";
            this.panelAnalizador.Size = new System.Drawing.Size(853, 560);
            this.panelAnalizador.TabIndex = 6;
            this.panelAnalizador.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAnalizador_Paint);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(119, 2);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(95, 24);
            this.buttonGuardar.TabIndex = 13;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelFila
            // 
            this.labelFila.AutoSize = true;
            this.labelFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelFila.Location = new System.Drawing.Point(184, 371);
            this.labelFila.Name = "labelFila";
            this.labelFila.Size = new System.Drawing.Size(50, 16);
            this.labelFila.TabIndex = 7;
            this.labelFila.Text = "Fila: 1";
            // 
            // labelColumna
            // 
            this.labelColumna.AutoSize = true;
            this.labelColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumna.Location = new System.Drawing.Point(184, 355);
            this.labelColumna.Name = "labelColumna";
            this.labelColumna.Size = new System.Drawing.Size(84, 16);
            this.labelColumna.TabIndex = 6;
            this.labelColumna.Text = "Columna: 1";
            this.labelColumna.Click += new System.EventHandler(this.labelColumna_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(169, 531);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // buttonSeleccionarProyecto
            // 
            this.buttonSeleccionarProyecto.Location = new System.Drawing.Point(187, 25);
            this.buttonSeleccionarProyecto.Name = "buttonSeleccionarProyecto";
            this.buttonSeleccionarProyecto.Size = new System.Drawing.Size(75, 42);
            this.buttonSeleccionarProyecto.TabIndex = 8;
            this.buttonSeleccionarProyecto.Text = "Seleccionar Proyecto";
            this.buttonSeleccionarProyecto.UseVisualStyleBackColor = true;
            this.buttonSeleccionarProyecto.Click += new System.EventHandler(this.buttonSeleccionarProyecto_Click);
            // 
            // buttonCrearProyecto
            // 
            this.buttonCrearProyecto.Location = new System.Drawing.Point(187, 73);
            this.buttonCrearProyecto.Name = "buttonCrearProyecto";
            this.buttonCrearProyecto.Size = new System.Drawing.Size(75, 37);
            this.buttonCrearProyecto.TabIndex = 9;
            this.buttonCrearProyecto.Text = "Crear Proyecto";
            this.buttonCrearProyecto.UseVisualStyleBackColor = true;
            this.buttonCrearProyecto.Click += new System.EventHandler(this.buttonCrearProyecto_Click);
            // 
            // buttonEliminarProyecto
            // 
            this.buttonEliminarProyecto.Location = new System.Drawing.Point(187, 116);
            this.buttonEliminarProyecto.Name = "buttonEliminarProyecto";
            this.buttonEliminarProyecto.Size = new System.Drawing.Size(75, 37);
            this.buttonEliminarProyecto.TabIndex = 10;
            this.buttonEliminarProyecto.Text = "Eliminar Proyecto";
            this.buttonEliminarProyecto.UseVisualStyleBackColor = true;
            this.buttonEliminarProyecto.Click += new System.EventHandler(this.buttonEliminarProyecto_Click);
            // 
            // buttonCrearArchivo
            // 
            this.buttonCrearArchivo.Location = new System.Drawing.Point(184, 210);
            this.buttonCrearArchivo.Name = "buttonCrearArchivo";
            this.buttonCrearArchivo.Size = new System.Drawing.Size(75, 42);
            this.buttonCrearArchivo.TabIndex = 12;
            this.buttonCrearArchivo.Text = "Crear Archivo";
            this.buttonCrearArchivo.UseVisualStyleBackColor = true;
            this.buttonCrearArchivo.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonEliminarArchivo
            // 
            this.buttonEliminarArchivo.Location = new System.Drawing.Point(184, 258);
            this.buttonEliminarArchivo.Name = "buttonEliminarArchivo";
            this.buttonEliminarArchivo.Size = new System.Drawing.Size(75, 42);
            this.buttonEliminarArchivo.TabIndex = 9;
            this.buttonEliminarArchivo.Text = "Eliminar Archivo";
            this.buttonEliminarArchivo.UseVisualStyleBackColor = true;
            this.buttonEliminarArchivo.Click += new System.EventHandler(this.buttonEliminarArchivo_Click);
            // 
            // panelCrearArchivo
            // 
            this.panelCrearArchivo.BackColor = System.Drawing.SystemColors.Info;
            this.panelCrearArchivo.Controls.Add(this.buttonRetrocederArchivo);
            this.panelCrearArchivo.Controls.Add(this.buttonCrearArchivo1);
            this.panelCrearArchivo.Controls.Add(this.label1);
            this.panelCrearArchivo.Controls.Add(this.textBoxNombreArchivo);
            this.panelCrearArchivo.Location = new System.Drawing.Point(184, 306);
            this.panelCrearArchivo.Name = "panelCrearArchivo";
            this.panelCrearArchivo.Size = new System.Drawing.Size(214, 131);
            this.panelCrearArchivo.TabIndex = 13;
            // 
            // textBoxNombreArchivo
            // 
            this.textBoxNombreArchivo.Location = new System.Drawing.Point(3, 45);
            this.textBoxNombreArchivo.MaximumSize = new System.Drawing.Size(208, 20);
            this.textBoxNombreArchivo.MinimumSize = new System.Drawing.Size(208, 20);
            this.textBoxNombreArchivo.Name = "textBoxNombreArchivo";
            this.textBoxNombreArchivo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxNombreArchivo.Size = new System.Drawing.Size(208, 20);
            this.textBoxNombreArchivo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre Archivo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCrearArchivo1
            // 
            this.buttonCrearArchivo1.Location = new System.Drawing.Point(0, 80);
            this.buttonCrearArchivo1.Name = "buttonCrearArchivo1";
            this.buttonCrearArchivo1.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearArchivo1.TabIndex = 14;
            this.buttonCrearArchivo1.Text = "Crear";
            this.buttonCrearArchivo1.UseVisualStyleBackColor = true;
            this.buttonCrearArchivo1.Click += new System.EventHandler(this.buttonCrearArchivo1_Click);
            // 
            // buttonRetrocederArchivo
            // 
            this.buttonRetrocederArchivo.Location = new System.Drawing.Point(177, 80);
            this.buttonRetrocederArchivo.Name = "buttonRetrocederArchivo";
            this.buttonRetrocederArchivo.Size = new System.Drawing.Size(34, 23);
            this.buttonRetrocederArchivo.TabIndex = 15;
            this.buttonRetrocederArchivo.Text = "<-";
            this.buttonRetrocederArchivo.UseVisualStyleBackColor = true;
            this.buttonRetrocederArchivo.Click += new System.EventHandler(this.buttonRetrocederArchivo_Click);
            // 
            // panelCrearProyecto
            // 
            this.panelCrearProyecto.BackColor = System.Drawing.SystemColors.Info;
            this.panelCrearProyecto.Controls.Add(this.buttonRetrocederCrearProyecto);
            this.panelCrearProyecto.Controls.Add(this.buttonCrearProyecto1);
            this.panelCrearProyecto.Controls.Add(this.label2);
            this.panelCrearProyecto.Controls.Add(this.textBoxCrearProyecto1);
            this.panelCrearProyecto.Location = new System.Drawing.Point(184, 443);
            this.panelCrearProyecto.Name = "panelCrearProyecto";
            this.panelCrearProyecto.Size = new System.Drawing.Size(214, 131);
            this.panelCrearProyecto.TabIndex = 14;
            // 
            // buttonRetrocederCrearProyecto
            // 
            this.buttonRetrocederCrearProyecto.Location = new System.Drawing.Point(177, 80);
            this.buttonRetrocederCrearProyecto.Name = "buttonRetrocederCrearProyecto";
            this.buttonRetrocederCrearProyecto.Size = new System.Drawing.Size(34, 23);
            this.buttonRetrocederCrearProyecto.TabIndex = 15;
            this.buttonRetrocederCrearProyecto.Text = "<-";
            this.buttonRetrocederCrearProyecto.UseVisualStyleBackColor = true;
            this.buttonRetrocederCrearProyecto.Click += new System.EventHandler(this.buttonRetrocederCrearProyecto_Click);
            // 
            // buttonCrearProyecto1
            // 
            this.buttonCrearProyecto1.Location = new System.Drawing.Point(0, 80);
            this.buttonCrearProyecto1.Name = "buttonCrearProyecto1";
            this.buttonCrearProyecto1.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearProyecto1.TabIndex = 14;
            this.buttonCrearProyecto1.Text = "Crear";
            this.buttonCrearProyecto1.UseVisualStyleBackColor = true;
            this.buttonCrearProyecto1.Click += new System.EventHandler(this.buttonCrearProyecto1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre Proyecto";
            // 
            // textBoxCrearProyecto1
            // 
            this.textBoxCrearProyecto1.Location = new System.Drawing.Point(3, 45);
            this.textBoxCrearProyecto1.MaximumSize = new System.Drawing.Size(208, 20);
            this.textBoxCrearProyecto1.MinimumSize = new System.Drawing.Size(208, 20);
            this.textBoxCrearProyecto1.Name = "textBoxCrearProyecto1";
            this.textBoxCrearProyecto1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxCrearProyecto1.Size = new System.Drawing.Size(208, 20);
            this.textBoxCrearProyecto1.TabIndex = 0;
            // 
            // FormEntorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1286, 582);
            this.Controls.Add(this.panelCrearProyecto);
            this.Controls.Add(this.panelCrearArchivo);
            this.Controls.Add(this.buttonEliminarArchivo);
            this.Controls.Add(this.buttonCrearArchivo);
            this.Controls.Add(this.buttonEliminarProyecto);
            this.Controls.Add(this.buttonCrearProyecto);
            this.Controls.Add(this.buttonSeleccionarProyecto);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panelAnalizador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1306, 625);
            this.MinimumSize = new System.Drawing.Size(1306, 625);
            this.Name = "FormEntorno";
            this.Text = "IDE";
            this.panelAnalizador.ResumeLayout(false);
            this.panelAnalizador.PerformLayout();
            this.panelCrearArchivo.ResumeLayout(false);
            this.panelCrearArchivo.PerformLayout();
            this.panelCrearProyecto.ResumeLayout(false);
            this.panelCrearProyecto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCuadroCompilacion;
        private System.Windows.Forms.Button buttonCompilar;
        private System.Windows.Forms.RichTextBox richTextBoxCuadroError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelAnalizador;
        private System.Windows.Forms.Label labelFila;
        private System.Windows.Forms.Label labelColumna;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonSeleccionarProyecto;
        private System.Windows.Forms.Button buttonCrearProyecto;
        private System.Windows.Forms.Button buttonEliminarProyecto;
        private System.Windows.Forms.Button buttonCrearArchivo;
        private System.Windows.Forms.Button buttonEliminarArchivo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Panel panelCrearArchivo;
        private System.Windows.Forms.Button buttonRetrocederArchivo;
        private System.Windows.Forms.Button buttonCrearArchivo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreArchivo;
        private System.Windows.Forms.Panel panelCrearProyecto;
        private System.Windows.Forms.Button buttonRetrocederCrearProyecto;
        private System.Windows.Forms.Button buttonCrearProyecto1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCrearProyecto1;
    }
}

