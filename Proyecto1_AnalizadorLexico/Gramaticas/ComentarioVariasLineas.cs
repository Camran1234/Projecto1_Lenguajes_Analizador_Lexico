using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class ComentarioVariasLineas : InfoGramatica
    {
        public ComentarioVariasLineas()
        {
            this.nombre = "ComentarioVariasLineas";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
            this.nombresEstados = new State[5];
            nombresEstados[0] = new State("S0", false);
            nombresEstados[1] = new State("S1", false);
            nombresEstados[2] = new State("S2", false);
            nombresEstados[3] = new State("S3", false);
            nombresEstados[4] = new State("S4", true);

            this.transiciones = new Transicion[8];
            transiciones[0] = new Transicion('/', "S0", "S1");
            transiciones[1] = new Transicion('*', "S1", "S2");
            transiciones[2] = new Transicion('#', "S2", "S2");
            transiciones[3] = new Transicion('$', "S2", "S2");
            transiciones[4] = new Transicion('\n', "S2", "S2");
            transiciones[5] = new Transicion(' ', "S2", "S2");
            transiciones[6] = new Transicion('*', "S2", "S3");
            transiciones[7] = new Transicion('/', "S3", "S4");

        }
    }
}
