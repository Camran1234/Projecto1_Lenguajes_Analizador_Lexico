using Proyecto1_AnalizadorLexico.Analizador_Lexico;
using Proyecto1_AnalizadorLexico.Archivo;
using Proyecto1_AnalizadorLexico.Interfaces;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico
{
    public partial class FormEntorno : Form
    {
        private Lectura lectura;
        public FormEntorno()
        {
            InitializeComponent();
            panelAnalizador.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxCuadroError.ResetText();
                lectura = new Lectura(this.richTextBoxCuadroCompilacion);
                string texto = richTextBoxCuadroCompilacion.Text;
                //Leemos caracter por caracter y lo mandamos a nuestro objeto Lectura para que lo lea y establezca
                //token, pinte caracteres, detectar errores entre otras medidas
                for(int i=0; i < texto.Length; i++)
                {
                    
                    lectura.Leer(texto[i],i);
                }
                //Lanzamos el mensaje de error
                this.throwErrorMessageFromLexicAnalyzer(lectura);
            }catch (Exception es)
            {
                MessageBox.Show("Error: " + es.StackTrace + "\n Otro error: "+es.Message) ;
            }
        }

        /// <summary>
        /// Lanza los errores encontrados en el programa
        /// </summary>
        /// <param name="erroresLectura"></param>
        private void throwErrorMessageFromLexicAnalyzer(Lectura erroresLectura)
        {
            string errorFraseInicial = "Errores: (" + erroresLectura.GetNoMistakes() + ") \n";
            //Anexamos la cantidad de errores encontrados
            richTextBoxCuadroError.AppendText(errorFraseInicial);
            //Colocamos los errores y sus respectivas posiciones
            richTextBoxCuadroError.AppendText(erroresLectura.GetErroresAsString());
        }

        private void richTextBoxCuadro_TextChanged(object sender, EventArgs e)
        {
            //Sintaxis para que cuando se mueva por cualquier parte lo que se escriba siempre sera negro
            int actualIndex = richTextBoxCuadroCompilacion.SelectionStart;
            richTextBoxCuadroCompilacion.Select(actualIndex, 0);
            richTextBoxCuadroCompilacion.SelectionColor = Color.Black;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Obtenemos el texto del cuadro de errores
            string textoErrores = richTextBoxCuadroError.Text;
            //Creamos un buscador de carpetas
            FolderBrowserDialog carpeta = new FolderBrowserDialog();
            //Obtenemos el resultado de la carpeta 
            DialogResult resultado = carpeta.ShowDialog();
            //Obtenemos la path de la carpeta
            string path = carpeta.SelectedPath;

            //Verificamos que el usuario le halla dado en ok y que la path no sea nula o tenga espacios en blanco
            if(resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(path))
            {
                new ManipuladorArchivo().createFile(textoErrores, path,true);
            }
            
            
        }

        private void richTextBoxCuadroError_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBoxCuadroCompilacion_LocationChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBoxCuadroCompilacion_CursorChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Este evento nos marcara siempre en que linea y posicion estamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBoxCuadroCompilacion_SelectionChanged(object sender, EventArgs e)
        {
            MostradorPosicion mostrador = new MostradorPosicion();
            labelFila.Text = (mostrador.GetRow(this.richTextBoxCuadroCompilacion));
            labelColumna.Text = (mostrador.GetCols(this.richTextBoxCuadroCompilacion));

        }

        private void panelAnalizador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelColumna_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSeleccionarProyecto_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscador = new FolderBrowserDialog();
            DialogResult resultado = buscador.ShowDialog();
            string path = buscador.SelectedPath;
            if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(path))
            {
                new ManipuladorTreeView().ChargeTreeView(path,this.treeView1);
            }
        }

        /// <summary>
        /// Evento para mostrar archivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                //Obtenemos la path de nuestro archivo
                string path = treeView1.SelectedNode.FullPath.ToString();
                
                string texto = new ManipuladorTreeView().CharSelectedFile(path, treeView1);
                //Verificamos que si halla encontrado el archivo
                //De lo contrario no mostrara nada
                if (!texto.Equals(null)) 
                {
                    //Obtenemos el texto del arbol seleccionado 
                    richTextBoxCuadroCompilacion.Text = texto;
                    //Mostramos el panel donde esta el analizador
                    panelAnalizador.Visible = true;
                }
                else
                {
                    panelAnalizador.Visible = false;
                    richTextBoxCuadroCompilacion.Text = "";
                }
                
            }
            catch (IOException excep)
            {
                MessageBox.Show("Error: " + excep.Message);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //Obtenemos el texto del cuadro de errores
            string textoNuevo = richTextBoxCuadroCompilacion.Text;
            //Obtenemos la path del archivo desde el nodo que seleccionamos la ultima vez
            string path = treeView1.SelectedNode.FullPath.ToString();

            //Verificamos que el usuario le halla dado en ok y que la path no sea nula o tenga espacios en blanco
            try
            {
                //Guardamos el archivo
                new ManipuladorArchivo().createFile(textoNuevo, path, false);
                MessageBox.Show("ARCHIVO " + Path.GetFileName(path) + " guardado");
            }
            catch (IOException Exc)
            {
                MessageBox.Show("Error: No se pudo guardar el archivo "+Exc.Message);
            }
                
        }
    }
}
