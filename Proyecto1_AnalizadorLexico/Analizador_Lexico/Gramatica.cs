using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Analizador_Lexico
{
    class Gramatica
    {
        private string nombreGramatica;
        private State[] estados;
        private Transicion[] transiciones;
        private string estadoActual = "S0";

        public Gramatica(InfoGramatica gramatica)
        {
            nombreGramatica = gramatica.GetName();
            estados = gramatica.GetStates();
            this.transiciones = gramatica.GetTransicions();
        }

        /// <summary>
        /// Retorna 0 si no entro a la gramatica del automata
        /// Retorna 1 si el automata llego al estado final
        /// Retorna 2 si se el caracter entro al analisis del automata
        /// Retorna 3 si durante el analisis del automata se encuentra un caracter que no pertenece
        /// y que no avanza en el estado
        /// </summary>
        /// <returns></returns>
        public int ComprobarToken(char caracter)
        {
            //Se analiza segun la cantidad de transiciones
            for(int indexTransiciones=0; indexTransiciones<transiciones.Length; indexTransiciones++)
            {
                if (transiciones[indexTransiciones].ProveChar(caracter,estadoActual)==true)
                {
                    if (estadoActual.Equals("S0"))
                    {
                        estadoActual = transiciones[indexTransiciones].GetLastState();
                        return 2;
                    }else if (estadoActual.Equals(transiciones[indexTransiciones]))
                    {
                        return 1;
                    }
                }
                else
                {
                    if (estadoActual.Equals("S0"))
                    {
                        return 0;
                    }else if (estadoActual.Equals(transiciones[indexTransiciones]))
                    {
                        estadoActual = "S0";
                        return 3;
                    }
                }
                
            }

            return 0;
        }

        
    }
}
