using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Suma : InfoGramatica
    {
        public Suma()
        {
            this.nombre = "Suma";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
            this.nombresEstados = new State[2];
            nombresEstados[0] = new State("S0", false);
            nombresEstados[1] = new State("S1", true);

            this.transiciones = new Transicion[1];
            transiciones[0] = new Transicion('+', "S0", "S1");
            
        }
    }
}
