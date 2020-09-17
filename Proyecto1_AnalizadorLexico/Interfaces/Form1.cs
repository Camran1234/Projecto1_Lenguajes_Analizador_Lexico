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
        private string pathProyecto="";
        public FormEntorno()
        {
            InitializeComponent();
            panelAnalizador.Visible=false;
            panelCrearArchivo.Visible = false;
            panelCrearProyecto.Visible = false;
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
            pathProyecto = path;
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
                //Reseteamos los errores
                richTextBoxCuadroError.Text = "";
                //Obtenemos la path de nuestro archivo
                string path = treeView1.SelectedNode.FullPath.ToString();
                this.MostrarArchivo(path);
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

            try
            {
                //Guardamos el archivo
                new ManipuladorArchivo().createFile(textoNuevo, path, false);
                MessageBox.Show("ARCHIVO " + Path.GetFileName(path) + " GUARDADO");
            }
            catch (IOException Exc)
            {
                MessageBox.Show("Error: No se pudo guardar el archivo "+Exc.Message);
            }
                
        }

        private void buttonEliminarArchivo_Click(object sender, EventArgs e)
        {
            if(treeView1.Nodes.Count!=0)
            {
                try
                {
                    //Obtenemos la path del archivo desde el nodo que seleccionamos la ultima vez
                    string path = treeView1.SelectedNode.FullPath.ToString();
                    //Eliminamos el archivo
                    new ManipuladorArchivo().EliminarArchivo(path);
                    MessageBox.Show("ARCHIVO ELIMINADO");
                    panelAnalizador.Visible = false;
                    
                    //Reiniciamos el arbol
                    new ManipuladorTreeView().ChargeTreeView(pathProyecto, this.treeView1);
                }
                catch (IOException Exc)
                {
                    MessageBox.Show("Error: No se pudo Eliminar el archivo " + Exc.Message);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN ARCHIVO DE PRIMERO");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(treeView1.Nodes.Count != 0)
            {
                if (!pathProyecto.Equals(""))
                {
                    AparecerIntroduccionNombresArchivos();
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN PROYECTO DE PRIMERO");
            }
            
        }

        private void buttonCrearArchivo1_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count != 0)
            {
                if (!string.IsNullOrWhiteSpace(textBoxNombreArchivo.Text) || !string.IsNullOrEmpty(textBoxNombreArchivo.Text))
                {
                    //Obtenemos el nombre del archivo nuevo
                    string nombreArchivo = textBoxNombreArchivo.Text + ".gt";
                    //Le agregamos el nombreArchivo al path del proyecto
                    string pathArchivo = Path.Combine(pathProyecto, nombreArchivo);

                    //Creamos el archivo
                    new ManipuladorArchivo().createFile(null, pathArchivo, false);
                    //Volvemos a cargar el proyecto
                    new ManipuladorTreeView().ChargeTreeView(pathProyecto, treeView1);


                    CerrarIntroduccionNombresArchivos();
                    MessageBox.Show("ARCHIVO CREADO");
                }
                else
                {
                    MessageBox.Show("Coloque un nombre porfavor");
                }
            }
            else
            {
                MessageBox.Show("SELECCIONA UN PROYECTO DE PRIMERO");
            }
            
        }

        private void CerrarIntroduccionNombresArchivos()
        {
            textBoxNombreArchivo.Text = "";
            panelCrearArchivo.Visible = false;
        }

        private void AparecerIntroduccionNombresProyectos()
        {
            panelCrearProyecto.Visible = true;
            //Lo mostramos al frente
            panelCrearProyecto.BringToFront();
        }

        private void CerrarIntroduccionNombresProyectos()
        {
            textBoxCrearProyecto1.Text = "";
            panelCrearProyecto.Visible = false;
        }

        private void AparecerIntroduccionNombresArchivos()
        {
            panelCrearArchivo.Visible = true;
            //Lo mostramos al frente
            panelCrearArchivo.BringToFront();
        }

        private void MostrarArchivo(string path)
        {
            string texto = new ManipuladorTreeView().CharSelectedFile(path, treeView1);
            //Verificamos que si halla encontrado el archivo
            //De lo contrario no mostrara nada
            if (texto != null)
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

        private void buttonRetrocederArchivo_Click(object sender, EventArgs e)
        {
            CerrarIntroduccionNombresArchivos();
        }

        private void buttonCrearProyecto1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCrearProyecto1.Text) || !string.IsNullOrEmpty(textBoxCrearProyecto1.Text))
            {
                //Obtenemos el nombre del archivo nuevo
                string nombreProyecto = textBoxCrearProyecto1.Text;


                string nuevaPath = new ManipuladorProyecto().CreateProyecto(nombreProyecto);

                if (nuevaPath != null)
                {
                    pathProyecto = nuevaPath;
                    //Volvemos a cargar el proyecto
                    new ManipuladorTreeView().ChargeTreeView(pathProyecto, treeView1);
                    CerrarIntroduccionNombresProyectos();
                }
            }
            else
            {
                MessageBox.Show("Coloque un nombre porfavor");
            }
        }

        private void buttonRetrocederCrearProyecto_Click(object sender, EventArgs e)
        {
            CerrarIntroduccionNombresProyectos();
        }

        private void buttonCrearProyecto_Click(object sender, EventArgs e)
        {
                AparecerIntroduccionNombresProyectos();
        }

        private void buttonEliminarProyecto_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count != 0)
            {
                new ManipuladorProyecto().EliminarProyecto(pathProyecto);
                pathProyecto = "";
                treeView1.Nodes.Clear();
                richTextBoxCuadroCompilacion.Text = "";
                richTextBoxCuadroError.Text = "";
                panelAnalizador.Visible = false;
            }
            else
            {
                MessageBox.Show("SELECCIONA UN PROYECTO");
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
