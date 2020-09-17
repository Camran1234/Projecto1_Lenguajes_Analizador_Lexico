using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto1_AnalizadorLexico.Archivo
{
    class ManipuladorTreeView
    {
        /// <summary>
        /// Limpia y establece los nuevos nodos del proyecto
        /// </summary>
        /// <param name="path"></param>
        /// <param name="treeView1"></param>
        internal void ChargeTreeView(string path, TreeView treeView1)
        {
            //Limpiamos todos los nodos del arbol
            treeView1.Nodes.Clear();

            //Codigo para obtener todos los archivos dentro de la carpeta gracias a la clase Directory que obtiene 
            //fullpaths y DirectInfo que nos sirve mas para obtener datos mas especificos, tambien como crear, escribir entre otras cosas
            string[] direccion;
            direccion = Directory.GetFiles(path);

            treeView1.Nodes.Add(path);

            foreach (string direccion1 in direccion)
            {
                treeView1.Nodes[0].Nodes.Add(Path.GetFileName(direccion1));
            }
        }

        //Cargamos el archivo indicado del Objeto TreeView
        internal string CharSelectedFile(string path, TreeView treeView1)
        {
            //Corroboramos que no seleccione un directorio y exista
            if (!Directory.Exists(path))
            {
                string texto = File.ReadAllText(path);
                return texto;
            }
            return null;
        }
    }
}
