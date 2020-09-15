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
        private Gramatica[] gramatica;
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
            int resultado;
            ArrayList gramaticaSinEstadoDeError = new ArrayList();
            ArrayList nombresTokens = new ArrayList();
            for (int indexGramatica=0;indexGramatica<gramatica.Length; indexGramatica++)
            {

                resultado = gramatica[indexGramatica].ComprobarToken(caracter);

                if (resultado == 0)
                {
                    //Sin acciones
                }
                else if (resultado == 1)
                {
                    //Indicamos que esta gramatica indicada llego estado final
                    if (index == -1)
                    {
                        index = indexActual;
                    }

                    pintador.pintarTexto(gramatica[indexGramatica].GetName(),index);
                    index = -1;
                    cadena = "";
                }
                else if (resultado == 2)
                {
                    //Indica que se trabajara este estado
                    if (index == -1)
                    {
                        index = indexActual;
                    }
                    cadena += caracter;
                    break;
                }
                else if (resultado == 3)
                {
                    gramatica[indexGramatica].resetState();
                    pintador.pintarTexto(cadena, index);
                    index = -1;
                    cadena = "";
                    break;
                }
                else
                {
                    cadena = "";
                    MessageBox.Show("Ocurrio un error al analizar el caracter");
                }
                
            }
        }
    }
}
