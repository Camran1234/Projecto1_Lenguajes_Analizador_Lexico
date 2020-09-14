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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {                       
              
            for(int index = 0; index < richTextBoxCuadro.TextLength; index++)
            {
                MessageBox.Show("La letra " + richTextBoxCuadro.GetCharFromPosition(richTextBoxCuadro.GetPositionFromCharIndex(index)) + " se encuentra en la posicion " + richTextBoxCuadro.GetPositionFromCharIndex(index));
            }
            
            
        }
    }
}
