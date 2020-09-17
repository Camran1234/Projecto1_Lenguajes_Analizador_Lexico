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
            this.button3 = new System.Windows.Forms.Button();
            this.buttonEliminarArchivo = new System.Windows.Forms.Button();
            this.panelAnalizador.SuspendLayout();
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
            this.panelAnalizador.Location = new System.Drawing.Point(319, 11);
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
            // 
            // buttonEliminarProyecto
            // 
            this.buttonEliminarProyecto.Location = new System.Drawing.Point(187, 116);
            this.buttonEliminarProyecto.Name = "buttonEliminarProyecto";
            this.buttonEliminarProyecto.Size = new System.Drawing.Size(75, 37);
            this.buttonEliminarProyecto.TabIndex = 10;
            this.buttonEliminarProyecto.Text = "Eliminar Proyecto";
            this.buttonEliminarProyecto.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 12;
            this.button3.Text = "Crear Archivo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarArchivo
            // 
            this.buttonEliminarArchivo.Location = new System.Drawing.Point(187, 290);
            this.buttonEliminarArchivo.Name = "buttonEliminarArchivo";
            this.buttonEliminarArchivo.Size = new System.Drawing.Size(75, 42);
            this.buttonEliminarArchivo.TabIndex = 9;
            this.buttonEliminarArchivo.Text = "Eliminar Archivo";
            this.buttonEliminarArchivo.UseVisualStyleBackColor = true;
            // 
            // FormEntorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1183, 582);
            this.Controls.Add(this.buttonEliminarArchivo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonEliminarProyecto);
            this.Controls.Add(this.buttonCrearProyecto);
            this.Controls.Add(this.buttonSeleccionarProyecto);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panelAnalizador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEntorno";
            this.Text = "IDE";
            this.panelAnalizador.ResumeLayout(false);
            this.panelAnalizador.PerformLayout();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonEliminarArchivo;
        private System.Windows.Forms.Button buttonGuardar;
    }
}

