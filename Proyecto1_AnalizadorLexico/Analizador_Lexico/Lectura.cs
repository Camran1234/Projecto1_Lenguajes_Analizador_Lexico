using System;
using System.Collections;
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
        //indexGramaticaAnalizada nos indica la posicion de la gramatica para indicar el nombre del token
        private int indexGramaticaAnalizada = -1;
        private Gramatica[] gramatica;
        private string estadoAnalizado = "";
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

        public void Leer(char caracter, int indexActual)
        {
            ArrayList listStates = new ArrayList();
            int resultado;
            for(int indexGramatica=0;indexGramatica<gramatica.Length; indexGramatica++)
            {
                resultado = gramatica[indexGramatica].ComprobarToken(caracter);
                if (resultado == 0)
                {
                       
                }else if (resultado == 1)
                {
                    //Pintamos el nombre de la gramatica
                    pintador.pintarTexto(gramatica[indexGramatica].GetName(),index);
                    estadoAnalizado = "";
                    index = -1;
                    break;
                }else if (resultado == 2)
                {
                    //Indica que se trabajara este estado
                    estadoAnalizado = gramatica[indexGramatica].GetActualState();
                    index = indexActual;
                    break;
                }
                else if (resultado == 3)
                {
                    //Cuando se encuentra un error durante el automata
                    pintador.pintarTexto("",index);
                    estadoAnalizado = "";
                    index = -1;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al analizar el caracter");
                }
                
            }
        }
    }
}
