using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Sino : InfoGramatica
    {
        public Sino()
        {
            this.nombre = "Sino";
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

            this.transiciones = new Transicion[4];
            transiciones[0] = new Transicion('S', "S0", "S1");
            transiciones[1] = new Transicion('I', "S1", "S2");
            transiciones[2] = new Transicion('N', "S2", "S3");
            transiciones[3] = new Transicion('O', "S3", "S4");
        }

    }
}
