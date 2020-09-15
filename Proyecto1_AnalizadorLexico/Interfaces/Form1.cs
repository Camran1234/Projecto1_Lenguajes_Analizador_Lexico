using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_AnalizadorLexico
{
    public partial class Form1 : Form
    {
        int indexColor = -1;
        string cadena="";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string a = "Hola";
                string texto = richTextBoxCuadro.Text;

                int index=-1;
                int length = 0;

                for (int i = 0; i < texto.Length; i++)
                {
                    //Hola mundo como estas el dia de hoy, hola sol, Hola a todos, HolaMundo
                    
                    MessageBox.Show("Caracter: '" + texto[i] + "'");
                    if (texto[i] == ' ' )
                    {
                        MessageBox.Show("Index: "+i);
                        cadena = "";
                        index = -1;
                    }else if (texto[i] == '\n')
                    {
                        MessageBox.Show("Index:/n " + i);
                        cadena = "";
                        index = -1;
                    }
                    else
                    {
                        if (index == -1)
                        {
                            index = i;
                        }

                        cadena += texto[i];
                        length = cadena.Length;
                    }

                    if (cadena.Equals("Hola"))
                    {
                        richTextBoxCuadro.Select(index, length);
                        richTextBoxCuadro.SelectionColor = Color.BlueViolet;        
                    }
                }

                cadena = "";
                index = -1;
            }
            catch (Exception es)
            {
                MessageBox.Show("Error: " + es.Message) ;
            }
            

            /*
             * for(int index = 0; index < richTextBoxCuadro.TextLength; index++)
                        {
                            MessageBox.Show("La letra " + richTextBoxCuadro.GetCharFromPosition(richTextBoxCuadro.GetPositionFromCharIndex(index)) + " se encuentra en la posicion " + richTextBoxCuadro.GetPositionFromCharIndex(index));
                        }
             * 
             * */



        }
    }
}
