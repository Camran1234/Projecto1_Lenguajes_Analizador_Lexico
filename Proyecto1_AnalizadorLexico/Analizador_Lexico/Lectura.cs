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
            ArrayList posicionesAutomatasParaAvanzar = new ArrayList();
            ArrayList posicionAutomatasErroneos = new ArrayList();
            bool automataHallado = false;
            bool permisoParaPintarUltimo = false;
            bool permisoAgregarCadena = false;
            int noAutomatasAnalizados = 0;
            for (int indexGramatica=0;indexGramatica<gramatica.Length; indexGramatica++)
            {
                resultado = gramatica[indexGramatica].ComprobarToken(caracter);
                //

                if (resultado == 1)
                {                    
                    //Indicamos que esta gramatica indicada llego estado final
                    if (index == -1)
                    {
                        index = indexActual;
                    }

                    if (permisoParaPintarUltimo == false)
                    {
                        //Pintamos el texto                    
                        pintador.pintarTexto(gramatica[indexGramatica].GetName(), index);
                        permisoParaPintarUltimo = true;
                    }
                    posicionesAutomatasParaAvanzar.Add(indexGramatica);

                }
                else if (resultado == 2)
                {
                    posicionesAutomatasParaAvanzar.Add(indexGramatica);
                    automataHallado = true;
                    noAutomatasAnalizados++;
                    
                    //Indica que se trabajara este estado
                    if (index == -1)
                    {
                        index = indexActual;
                    }
                    if (permisoAgregarCadena == false)
                    {
                        cadena += caracter;
                        permisoAgregarCadena = true;
                    }
                }
                    
                else if (resultado == 3)
                {
                    noAutomatasAnalizados++;
                    posicionAutomatasErroneos.Add(indexGramatica);
                    gramatica[indexGramatica].resetState();
                }
                
            }

            if (posicionAutomatasErroneos.Count > 0)
            {
                for(int indexGramatica = 0; indexGramatica < posicionAutomatasErroneos.Count; indexGramatica++)
                {
                    if (automataHallado == true && noAutomatasAnalizados == 1)
                    {
                        pintador.pintarTexto(gramatica[Convert.ToInt32(posicionAutomatasErroneos.ToArray()[indexGramatica])].GetName(), index);
                        index = -1;
                        cadena = "";
                    }
                    else if (automataHallado == true && noAutomatasAnalizados > 1)
                    {
                        pintador.pintarTexto(cadena, index);
                        posicionesAutomatasParaAvanzar.Remove(Convert.ToInt32(posicionAutomatasErroneos.ToArray()[indexGramatica]));
                    }
                    else
                    {
                        
                        index = -1;
                        cadena = "";
                    }
                }   
            }

                //Metodo que cambia de estado a los automatas que se analizaron
            if (automataHallado == true)
            {
                for(int indexGramatica=0; indexGramatica < posicionesAutomatasParaAvanzar.Count; indexGramatica++)
                {   
                    gramatica[Convert.ToInt32(posicionesAutomatasParaAvanzar.ToArray()[indexGramatica])].upState();
                }
            }
            else
            {
                index = -1;
                cadena = "";
            }


        }
    }
}
