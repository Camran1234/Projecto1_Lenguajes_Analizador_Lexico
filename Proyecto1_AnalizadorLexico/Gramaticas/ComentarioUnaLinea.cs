using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class ComentarioUnaLinea : InfoGramatica
    {
        public ComentarioUnaLinea()
        {
            this.nombre = "ComentarioUnaLinea";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
            this.nombresEstados = new State[3];
            nombresEstados[0] = new State("S0", false);
            nombresEstados[1] = new State("S1", false);
            nombresEstados[2] = new State("S2", true);

            this.transiciones = new Transicion[5];
            transiciones[0] = new Transicion('/', "S0", "S1");
            transiciones[1] = new Transicion('/', "S1", "S2");
            transiciones[2] = new Transicion('#', "S2", "S2");
            transiciones[3] = new Transicion('$', "S2", "S2");
            transiciones[4] = new Transicion(' ', "S2", "S2");
        }
    }
}
