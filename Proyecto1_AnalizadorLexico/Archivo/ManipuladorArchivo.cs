using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proyecto1_AnalizadorLexico.Archivo
{
    class ManipuladorArchivo
    {
        
        /// <summary>
        /// Crea o manipula un archivo
        /// Si opcion es true entonces se creara un nombre para el archivo usado cuando
        /// se selecciono solo el directorio de carpetas
        /// Pero si es falso entonces creara un archivo con el path ya establecido
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="path"></param>
        public void createFile(string texto,string path,Boolean opcion)
        {
            try
            {
                string originalPath = path;
                if (opcion)
                {
                    //Creamos el nombre del archivo con la fecha del momento
                    string tiempo = DateTime.Now.ToString(new CultureInfo("en-US"));
                    //Quitamos las diagonales
                    tiempo = tiempo.Replace("/", "-");
                    tiempo = tiempo.Replace(":", "_");
                    string fileName = "Reporte Errores " + tiempo + ".gtE";
                    //Combinamos el nombre del path obtenido y le agregamos el nombre nuevo
                    path = System.IO.Path.Combine(path, fileName);
                }

                try
                {
                    //Creamos el archivo y abrimos el flujo    
                    FileStream archivoNuevo = File.Create(path);
                    
                    //transformamos el archivo en bytes, escogemos UTF8 porque es un formato de codificacion muy usado
                    byte[] contenido = new UTF8Encoding().GetBytes(texto);
                    
                    //Agregamos el texto
                    archivoNuevo.Write(contenido, 0, contenido.Length);
                    archivoNuevo.Close();
                    MessageBox.Show("Se creo el archivo en " + originalPath);
                }
                catch (IOException error)
                {
                    MessageBox.Show("Error: " + error.Message + "\nNo se pudo crear el archivo");
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show("Error Fatal: " + ex.Message + "\nNo se pudo crear el archivo");
            }
             
        }
    }
}
