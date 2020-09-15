using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Analizador_Lexico
{
    class Lectura
    {
        private string cadena = "";
        private Lenguaje lenguaje = new Lenguaje();
        private int index;
        private Gramatica[] gramatica;
        private string estado = "";
        private PintarElemento pintador;

        /// <summary>
        /// Objeto para la lectura de caracteres y decide si pintara algun token
        /// </summary>
        public Lectura(RichTextBox richTextBox)
        {
            gramatica = new Gramatica[lenguaje.GetGramaticas().Length];
            pintador = new PintarElemento(richTextBox);
            for(int indexLenguaje=0; indexLenguaje < lenguaje.GetGramaticas().Length; indexLenguaje++)
            {
                gramatica[indexLenguaje] = new Gramatica(lenguaje.GetGramaticas()[indexLenguaje]);
            }
        }

        public void Leer(char caracter, int index)
        {

            for(int indexGramatica=0;indexGramatica<gramatica.Length; indexGramatica++)
            {
                gramatica[indexGramatica].ComprobarToken(caracter);
            }
        }
    }
}
