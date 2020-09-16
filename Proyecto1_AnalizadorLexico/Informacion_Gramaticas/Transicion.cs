using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Informacion_Gramaticas
{
    /// <summary>
    /// Clase para establecer transiciones de los automatas y sus estados respectivos
    /// </summary>
    class Transicion
    {
        char caracterApuntador=' ';
        string nombreEstadoInicial="";
        string nombreEstadoFinal="";

        public Transicion(char caracter,string EstadoInicial,string EstadoFinal)
        {
            this.caracterApuntador = caracter;
            nombreEstadoFinal = EstadoFinal;
            nombreEstadoInicial = EstadoInicial;
        }

        public string GetStartState()
        {
            return nombreEstadoInicial;
        }

        public string GetLastState()
        {
            return nombreEstadoFinal;
        }

        /// <summary>
        /// Clase para mostrar transiciones
        /// Simplemente mantiene el nombre del estado
        /// en el que está y el estado el que apunta,
        /// además que contiene el caractér que genera esta
        /// transición
        /// </summary>
        /// <returns></returns>
        Transicion GetTransicion()
        {
            return this;
        }


        /// <summary>
        /// Comprueba si el caractér si concuerda en la transición
        /// Se usara # para representar las minusculas y $ para representar
        /// las mayusculas
        /// </summary>
        /// <param name="caracter"></param>
        /// <returns></returns>
        public bool ProveChar(char caracter)
        {
            //Si hay minusculas o mayusculas o espacios libres o saltos de linea analizara esto
                if(caracterApuntador=='$' || caracterApuntador == '#' )
                {
                    if (caracter >= 97 && caracter <= 122)
                    {
                        return true;
                    }else if (caracter >= 65 && caracter <= 90)
                    {
                        return true;
                    }
                    
                }
                else
                {
                //Si el caracter enviado es el mismo con el que apunta al siguiente caracter
                    if (this.caracterApuntador == caracter)
                    {
                        return true;
                    }
                }
            return false;
        }

    }
}
