using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Boolean_ : InfoGramatica
    {
        public Boolean_( )
        {
            this.nombre = "Boolean";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
            this.nombresEstados = new State[8];
            nombresEstados[0] = new State("S0", false);
            nombresEstados[1] = new State("S1", false);
            nombresEstados[2] = new State("S2", false);
            nombresEstados[3] = new State("S3", false);
            nombresEstados[4] = new State("S4", false);
            nombresEstados[5] = new State("S5", false);
            nombresEstados[6] = new State("S6", false);
            nombresEstados[7] = new State("S7", true);

            this.transiciones = new Transicion[7];
            transiciones[0] = new Transicion('B', "S0", "S1");
            transiciones[1] = new Transicion('o', "S1", "S2");
            transiciones[2] = new Transicion('o', "S2", "S3");
            transiciones[3] = new Transicion('l', "S3", "S4");
            transiciones[4] = new Transicion('e', "S4", "S5");
            transiciones[5] = new Transicion('a', "S5", "S6");
            transiciones[6] = new Transicion('n', "S6", "S7");

        }
    }
}
