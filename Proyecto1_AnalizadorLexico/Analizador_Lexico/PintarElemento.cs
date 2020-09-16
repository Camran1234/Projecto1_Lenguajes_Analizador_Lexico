using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Analizador_Lexico
{
    class PintarElemento
    {
        private RichTextBox richTextBox;

        /// <summary>
        /// Clase que nos sirve para pintar el texto de la instancia de RichTextBox a cierto color 
        /// </summary>
        /// <param name="richTextBox"></param>
        public PintarElemento(RichTextBox richTextBox)
        {
            this.richTextBox = richTextBox;
        }

        public void pintarTexto(string token,int index)
        {
            int sizeToken = token.Length;
            Color color = Color.Black;
            //Asignamos el color dado segun el token dado
            switch (token)
            {
                case "Entero":
                    color = Color.Purple;
                    break;
                case "Decimal":
                    color = Color.Cyan;
                    break;
                case "Cadena":
                    color = Color.Gray;
                    break;
                case "Boolean":
                    color = Color.Orange;
                    break;
                case "Chart":
                    color = Color.Brown;
                    break;
                case "Igual":
                    sizeToken = 1;
                    color = Color.Pink;
                    break;
                case "Colon":
                    sizeToken = 1;
                    color = Color.Pink;
                    break;
                default:
                    if (token.Equals("Si") || token.Equals("Sino") || token.Equals("Sino_Si") || token.Equals("Mientras") || token.Equals("Hacer")
                         || token.Equals("Desde") || token.Equals("Hasta") || token.Equals("Incremento"))
                    {
                        color = Color.Green;
                    }else if (token.Equals("ComentarioUnaLinea") || token.Equals("ComentarioVariasLineas"))
                    {
                        color = Color.Red;
                    }else if (token.Equals("Suma") || token.Equals("Resta") || token.Equals("Multiplicacion") || token.Equals("Division")|| token.Equals("Mayor") || token.Equals("Menor")  || token.Equals("Or") || token.Equals("And") || token.Equals("Negacion")
                        || token.Equals("ParentesisAbrir") || token.Equals("ParentesisCerrar"))
                    {
                        sizeToken = 1;
                        color = Color.Blue;
                    }else if(token.Equals("Incrementar") || token.Equals("Disminuir") || token.Equals("MayorIgual") || token.Equals("MenorIgual")
                        || token.Equals("Comparacion") || token.Equals("Diferente"))
                    {
                        sizeToken = 2;
                        color = Color.Blue;
                    }
                        break;
            }
            //Seleccionamos en el objeto la posicion y tamaño de lo que queremos cambiar de color
            richTextBox.Select(index, sizeToken);
            //La parte seleccionada le agregamos el color
            richTextBox.SelectionColor = color;
            //hacemos de que siga escribiendo en negro el archivo
            /*
             * richTextBox.Select(index+token.Length, 0);
            richTextBox.SelectionColor = Color.Black;
             * */
        }
    }
}
