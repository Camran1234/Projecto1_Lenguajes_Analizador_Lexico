using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Informacion_Gramaticas
{
    class InfoGramatica
    {
        protected string nombre;
        protected State[] nombresEstados;
        protected Transicion[] transiciones;

        public InfoGramatica()
        {
            this.MakeStatesAndTransition();
        }

        /// <summary>
        /// Obtiene los estados del automata
        /// </summary>
        /// <returns></returns>
        public State[] GetStates()
        {
            return nombresEstados;
        }

        /// <summary>
        /// Obtiene las transiciones del automata
        /// </summary>
        /// <returns></returns>
        public Transicion[] GetTransicions()
        {
            return transiciones;
        }

        public string GetName()
        {
            return this.nombre;
        }

        public virtual void MakeStatesAndTransition()
        {

        }

    }
}
