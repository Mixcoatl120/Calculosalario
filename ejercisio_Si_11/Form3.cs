using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercisio_Si_11
{
    public partial class Form3 : Form
    {
        public static decimal bono, premio, dieta, primaD, primaV,ISR,SS,infonavit,ajuste,FA,CS,afore;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = Form2.Empleado;
            label3.Text = Form2.SS;
            label11.Text = Form2.nombre;
            //Persepcion
            dieta = Form2.Salario * (5/100);
            premio = Form2.Salario * (10/100);
            if (Form2.dias >= 15)
            {
                bono = Form2.Salario * (1/100);
            }
            if (Form2.dias >= 15)
            {
                primaD = Form2.Salario * (40 / 100);
            }
            else
            {
                primaD = Form2.Salario * (20 / 100);
            }
            if (Form2.dias >= 15)
            {
                primaV = Form2.Salario * ((1/2) / 100);
            }
            else
            {
                primaV = Form2.Salario * (1 / 100);
            }
        }
    }
}
