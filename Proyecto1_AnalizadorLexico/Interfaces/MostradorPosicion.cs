﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico.Interfaces
{
    class MostradorPosicion
    {
        
        public string GetRow(RichTextBox richTextBox)
        {
            string rows = "Fila: ";
            int linea = 0;
            //Obtenemos el index de la posicion del cursor
            int index = richTextBox.SelectionStart;
            //Colocamos la linea obteniendo la linea mas cercana
            linea = richTextBox.GetLineFromCharIndex(index);
            rows += linea+1;

            return rows;
        }

        public string GetCols(RichTextBox richTextBox)
        {

            string cols = "Columna: ";
            int linea = 0;
            //Obtenemos el index de la posicion del cursor
            int index = richTextBox.SelectionStart;
            //Colocamos la linea obteniendo la linea mas cercana
            linea = richTextBox.GetLineFromCharIndex(index);
            
            //Encotramos el primer index de la linea establecida
            int posicionLinea = richTextBox.GetFirstCharIndexFromLine(linea);
            //Para hallar la columa le quitamos el index actual con el index del inicio
            int column = index - posicionLinea;

            cols += column+1;
            return cols;

        }
    }
}
