using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class And : InfoGramatica
    {
        
        public And() 
        {
            this.nombre = "And";

        }

        public override void MakeStatesAndTransition()
        {
            this.nombresEstados = new State[3];
            nombresEstados[0] = new State("S0", false);
            nombresEstados[1] = new State("S1", false);
            nombresEstados[2] = new State("S2", true);

            this.transiciones = new Transicion[2];
            transiciones[0] = new Transicion('&', "S0", "S1");
            transiciones[1] = new Transicion('&', "S1", "S2");
        }
    }
}
