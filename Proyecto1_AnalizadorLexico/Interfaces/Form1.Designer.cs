namespace Proyecto1_AnalizadorLexico
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
            this.richTextBoxCuadro = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCompilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxCuadro
            // 
            this.richTextBoxCuadro.Location = new System.Drawing.Point(338, 49);
            this.richTextBoxCuadro.Name = "richTextBoxCuadro";
            this.richTextBoxCuadro.Size = new System.Drawing.Size(1133, 455);
            this.richTextBoxCuadro.TabIndex = 1;
            this.richTextBoxCuadro.Text = "";
            this.richTextBoxCuadro.TextChanged += new System.EventHandler(this.richTextBoxCuadro_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 687);
            this.panel1.TabIndex = 2;
            // 
            // buttonCompilar
            // 
            this.buttonCompilar.Location = new System.Drawing.Point(371, 13);
            this.buttonCompilar.Name = "buttonCompilar";
            this.buttonCompilar.Size = new System.Drawing.Size(78, 30);
            this.buttonCompilar.TabIndex = 3;
            this.buttonCompilar.Text = "Compilar";
            this.buttonCompilar.UseVisualStyleBackColor = true;
            this.buttonCompilar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1483, 712);
            this.Controls.Add(this.buttonCompilar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBoxCuadro);
            this.Name = "Form1";
            this.Text = "IDE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCuadro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCompilar;
    }
}

