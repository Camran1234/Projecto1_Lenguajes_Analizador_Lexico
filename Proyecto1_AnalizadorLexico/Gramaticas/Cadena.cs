using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Cadena : InfoGramatica
    {
        public Cadena( )
        {
            this.nombre = "Cadena";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
            this.nombresEstados = new State[7];
            nombresEstados[0] = new State("S0", false);
            nombresEstados[1] = new State("S1", false);
            nombresEstados[2] = new State("S2", false);
            nombresEstados[3] = new State("S3", false);
            nombresEstados[4] = new State("S4", false);
            nombresEstados[5] = new State("S5", false);
            nombresEstados[6] = new State("S6", true);
            

            this.transiciones = new Transicion[6];
            transiciones[0] = new Transicion('C', "S0", "S1");
            transiciones[1] = new Transicion('a', "S1", "S2");
            transiciones[2] = new Transicion('d', "S2", "S3");
            transiciones[3] = new Transicion('e', "S3", "S4");
            transiciones[4] = new Transicion('n', "S4", "S5");
            transiciones[5] = new Transicion('a', "S5", "S6");
            

        }
    }
}
