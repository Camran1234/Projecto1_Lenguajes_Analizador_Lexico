﻿using Proyecto1_AnalizadorLexico.Archivo;
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
        private List<Error> errores = new List<Error>();
        private string cadena = "";
        private Lenguaje lenguaje = new Lenguaje();
        private int index = -1;
        //indexGramaticaAnalizada nos indica la posicion de la gramatica para indicar el nombre del token
        private Gramatica[] gramatica;
        private PintarElemento pintador;
        private bool permisoParaPintar = true;
        private bool analizandoAutomatasEnAccion = false; 
        ArrayList posicionesAutomatasParaAvanzar = new ArrayList();
        private RichTextBox richTextBox;

        /// <summary>
        /// Objeto para la lectura de caracteres y decide si pintara algun token
        /// </summary>
        public Lectura(RichTextBox richTextBox)
        {
            gramatica = new Gramatica[lenguaje.GetGramaticas().Length];
            pintador = new PintarElemento(richTextBox);
            this.richTextBox = richTextBox;
            for(int indexLenguaje=0; indexLenguaje < lenguaje.GetGramaticas().Length; indexLenguaje++)
            {
                gramatica[indexLenguaje] = new Gramatica(lenguaje.GetGramaticas()[indexLenguaje]);
            }
        }

        /// <summary>
        /// Obtiene todos los errores encontrados
        /// </summary>
        /// <returns></returns>
        public string GetErroresAsString()
        {
            string erroresMensaje ="";
            Error error;
            for(int indexErrores = 0; indexErrores < errores.Count; indexErrores++)
            {
                errores.ToArray()[indexErrores].ChangeIndexToLine(richTextBox);
                error = errores.ToArray()[indexErrores];
                erroresMensaje += error.Message();
            }
            return erroresMensaje;
        }

        public int GetNoMistakes()
        {
            return errores.Count;
        }

        public void Leer(char caracter, int indexActual)
        {
            int resultado = 0;
            bool permisoParaAgregarError = false;
            bool permisoAgregarCadena = false;
            ArrayList posicionAutomatasErroneos = new ArrayList();
            for (int indexGramatica=0;indexGramatica<gramatica.Length; indexGramatica++)
            {
                //Miramos si hay automatas que se estan analizando actualmente, sino analizamos todos
                if(analizandoAutomatasEnAccion == true)
                {
                    while(posicionesAutomatasParaAvanzar.Contains(indexGramatica) == false)
                    {
                        if (indexGramatica < gramatica.Length)
                        {
                            indexGramatica++;
                        }
                        else
                        {
                            break;
                        }
                            
                    }
                }
                if (indexGramatica == gramatica.Length)
                {
                    break;
                }
                resultado = gramatica[indexGramatica].ComprobarToken(caracter);

                

                if (resultado == 1)
                {                    
                    //Indicamos que esta gramatica indicada llego estado final
                    if (index == -1)
                    {
                        index = indexActual;
                    }

                    if (posicionesAutomatasParaAvanzar.Contains(indexGramatica) == false)
                    {
                        posicionesAutomatasParaAvanzar.Add(indexGramatica);
                    }

                    //Agregamos el caracter a la cadena si este entro a un automata
                    if (permisoAgregarCadena == false)
                    {
                        cadena += caracter;
                        permisoAgregarCadena = true;
                    }

                    //Pintamos el texto                    
                    pintador.pintarTexto(gramatica[indexGramatica].GetName(), cadena, index);
                        permisoParaPintar = false;
                    
                }
                else if (resultado == 2)
                {

                    //Indica que se trabajara este estado
                    if (index == -1)
                    {
                        index = indexActual;
                    }
                    
                    if (posicionesAutomatasParaAvanzar.Contains(indexGramatica) == false)
                    {
                        posicionesAutomatasParaAvanzar.Add(indexGramatica);
                    }

                    //Agregamos el caracter a la cadena si este entro a un automata
                    if (permisoAgregarCadena == false)
                    {
                        cadena += caracter;
                        permisoAgregarCadena = true;
                    }
                }
                    
                else if (resultado == 3)
                {
                    posicionAutomatasErroneos.Add(indexGramatica);
                    //Eliminamos el automata que se estaba analizando si se halla error
                }
                
            }

            //Para determinar como pintaremos los errores
            if (posicionAutomatasErroneos.Count > 0)
            {
                String lastStateGramatics;
                bool finalStateReached = false;
                for (int indexErrores = 0; indexErrores < posicionAutomatasErroneos.Count; indexErrores++)
                {
                    
                    if (posicionAutomatasErroneos.Count == 1)
                    {
                        lastStateGramatics = gramatica[Convert.ToInt32(posicionAutomatasErroneos.ToArray()[indexErrores])].GetActualState();
                        //Corroboramos si el estado era final o no, es decir si queda como error o lo omitimos
                        //Indica que si era estado final y lo pintaremos como corresponde
                        
                        if (gramatica[Convert.ToInt32(posicionAutomatasErroneos.ToArray()[indexErrores])].checkIfActualStateIsFinal(lastStateGramatics))
                        {
                            if(permisoParaPintar == true)
                            {
                                pintador.pintarTexto(gramatica[Convert.ToInt32(posicionAutomatasErroneos.ToArray()[indexErrores])].GetName(), cadena, index);
                                permisoParaPintar = false;
                            }
                            finalStateReached=true;
                        }
                        else //Al no ser estado final pintaremos la cadena que es por el color negro y marcaremos como error
                        {

                            if(permisoParaPintar == true)
                            {
                                pintador.pintarTexto(cadena, cadena, index);
                                permisoParaPintar = false;
                            }
                            
                        }
                        //Al eliminar el ultimo automata que estabamos revisando entonces reiniciara todos, y volvera a analizar todos los automatas
                        //en el siguiente caracter enviado

                        if (posicionesAutomatasParaAvanzar.Count == posicionAutomatasErroneos.Count)
                        {

                            if (!gramatica[Convert.ToInt32(posicionAutomatasErroneos.ToArray()[indexErrores])].checkIfActualStateIsFinal(lastStateGramatics))
                            {
                                if (permisoParaAgregarError == false)
                                {
                                    errores.Add(new Error(cadena, gramatica[Convert.ToInt32(posicionAutomatasErroneos.ToArray()[indexErrores])].GetName(), index));
                                }
                                index = -1;
                                cadena = "";
                                permisoParaAgregarError = true;
                            }
                            
                        }
                        permisoParaPintar = true;
                    }
                    else
                    {
                        //Verificamos si de los numerosos automatas con error alguno alcanzo su estado final
                        lastStateGramatics = gramatica[Convert.ToInt32(posicionAutomatasErroneos.ToArray()[indexErrores])].GetActualState();
                        if (gramatica[Convert.ToInt32(posicionAutomatasErroneos.ToArray()[indexErrores])].checkIfActualStateIsFinal(lastStateGramatics))
                        {
                            finalStateReached = true;
                        }
                    }

                    

                    //Eliminamos el automata que se estaba analizando
                    gramatica[Convert.ToInt32(posicionAutomatasErroneos.ToArray()[indexErrores])].resetState();
                    posicionesAutomatasParaAvanzar.Remove(Convert.ToInt32(posicionAutomatasErroneos.ToArray()[indexErrores]));
                    
                }
                //Si lo alcanzo entonces decimos que ya lo pinto y opero por ende podemos reiniciar
                if (finalStateReached == true && (posicionesAutomatasParaAvanzar.Count + posicionAutomatasErroneos.Count) == posicionAutomatasErroneos.Count)
                {
                    index = -1;
                    cadena = "";
                    permisoParaPintar = true;
                }
                else if (finalStateReached==false && (posicionesAutomatasParaAvanzar.Count + posicionAutomatasErroneos.Count) == posicionAutomatasErroneos.Count)
                {
                    if (permisoParaAgregarError == false)
                    {
                        errores.Add(new Error(cadena, gramatica[Convert.ToInt32(posicionAutomatasErroneos.ToArray()[0])].GetName(), index));
                    }
                    //Si no alcanzo quiere decir que ninguno pinto porque nunca fue estado final entonces pintamos la cadena de negro y reiniciamos
                    //valores
                    pintador.pintarTexto(cadena, cadena, index);
                    index = -1;
                    cadena = "";
                    permisoParaPintar = true;
                    
                    
                }
            }


            if (posicionesAutomatasParaAvanzar.Count>0)
            {
                analizandoAutomatasEnAccion = true;
            }else if( posicionesAutomatasParaAvanzar.Count == 0)
            {
                analizandoAutomatasEnAccion = false;
            }
                
            


        }
    }
}
