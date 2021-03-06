﻿using Proyecto1_AnalizadorLexico.Informacion_Gramaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_AnalizadorLexico.Gramaticas
{
    class Mientras : InfoGramatica
    {
        public Mientras()
        {
            this.nombre = "Mientras";
            this.MakeStatesAndTransition();
        }

        public override void MakeStatesAndTransition()
        {
            this.nombresEstados = new State[9];
            nombresEstados[0] = new State("S0", false);
            nombresEstados[1] = new State("S1", false);
            nombresEstados[2] = new State("S2", false);
            nombresEstados[3] = new State("S3", false);
            nombresEstados[4] = new State("S4", false);
            nombresEstados[5] = new State("S5", false);
            nombresEstados[6] = new State("S6", false);
            nombresEstados[7] = new State("S7", false);
            nombresEstados[8] = new State("S8", true);

            this.transiciones = new Transicion[8];
            transiciones[0] = new Transicion('M', "S0", "S1");
            transiciones[1] = new Transicion('I', "S1", "S2");
            transiciones[2] = new Transicion('E', "S2", "S3");
            transiciones[3] = new Transicion('N', "S3", "S4");
            transiciones[4] = new Transicion('T', "S4", "S5");
            transiciones[5] = new Transicion('R', "S5", "S6");
            transiciones[6] = new Transicion('A', "S6", "S7");
            transiciones[7] = new Transicion('S', "S7", "S8");
        }
    }
}
