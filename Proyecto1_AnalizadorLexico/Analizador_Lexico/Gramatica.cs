﻿using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Analizador_Lexico
{
    class Gramatica
    {
        private string nombreGramatica;
        private State[] estados;
        private Transicion[] transiciones;
        private string estadoActual = "S0";
        private int lastTransition = 0;
        bool posiblesTransicionesRepetidas = false;
        public Gramatica(InfoGramatica gramatica)
        {
            nombreGramatica = gramatica.GetName();
            estados = gramatica.GetStates();
            this.transiciones = gramatica.GetTransicions();
        }

        /// <summary>
        /// Retorna 0 si no entro a la gramatica del automata
        /// Retorna 1 si el automata llego al estado final
        /// Retorna 2 si se el caracter entro al analisis del automata o se sigue analizando
        /// Retorna 3 si durante el analisis del automata se encuentra un caracter que no pertenece
        /// y que no avanza en el estado
        /// </summary>
        /// <returns></returns>
        public int ComprobarToken(char caracter)
        {
            bool comprobacionCaracter=false;
            bool retornarError = false;
            //Se analiza segun la cantidad de transiciones
            
            for(int indexTransiciones=lastTransition; indexTransiciones<transiciones.Length; indexTransiciones++)
            {
                if (transiciones[indexTransiciones].GetStartState().Equals(estadoActual))
                {

                    try
                    {
                        if (transiciones[indexTransiciones - 1].GetLastState() == transiciones[indexTransiciones].GetLastState())
                        {
                            posiblesTransicionesRepetidas = true;
                        }
                    }
                    catch (Exception e)
                    {

                    }


                    //Se comprueba si el caracter pertenece a la transicion, verdadero si si pertenece, falso si no
                    comprobacionCaracter = transiciones[indexTransiciones].ProveChar(caracter);
                    if (comprobacionCaracter == true)
                    {
                        
                        
                        
                            //Colocamos de que el estado actual de esta gramatica es el ultimo analizado en la transicion
                            estadoActual = transiciones[indexTransiciones].GetLastState();


                        //Si este estado no es final
                        if (this.checkIfActualStateIsFinal(estadoActual) == false)
                        {
                            if (posiblesTransicionesRepetidas == false)
                            {
                                lastTransition++;
                                indexTransiciones = lastTransition;
                            }

                            //Hacemos el brinco de transiciones cuando detecte una que ya no sea diferente a la anterior
                            if (posiblesTransicionesRepetidas == true && transiciones[indexTransiciones - 1].GetLastState() != transiciones[indexTransiciones].GetLastState())
                            {
                                //Aumentamos por uno
                                lastTransition = indexTransiciones;
                                posiblesTransicionesRepetidas = false;
                            }


                            return 2;
                        }
                        else
                        {
                            if (!nombreGramatica.Equals("ComentarioUnaLinea"))
                            {
                                if (lastTransition != transiciones.Length - 1)
                                {
                                    lastTransition++;
                                }
                            }
                            return 1;
                        }
                        
                    }
                    else
                    {
                        if (estadoActual.Equals("S0"))
                        {
                            return 0;
                        }
                        else if (estadoActual.Equals("S0") == false && indexTransiciones == transiciones.Length-1)
                        {
                            return 3;
                        }
                        retornarError = true;
                    }

                }
            }

            if(retornarError == true)
            {
                return 3;
            }

            //Indica que si no hay mas transiciones entonces retornara que es un error
            if (lastTransition == transiciones.Length - 1)
            {
                return 3;
            }

            return 0;
        }


        public void resetState()
        {
            estadoActual = "S0";
            lastTransition = 0;
            posiblesTransicionesRepetidas = false;
        }

        public string GetName()
        {
            return this.nombreGramatica;
        }
        
        public string GetActualState()
        {
            return this.estadoActual;
        }


        /// <summary>
        /// Devuelve si era un estado final o no
        /// True si era estado final
        /// False si no era estado final
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool checkIfActualStateIsFinal(String state)
        {
            if (state.Equals(estados[estados.Length - 1].GetName()) && estados[estados.Length -1].GetStateType()==true)
            {
                return true;
            }

            return false;
        }

       
    }
}
