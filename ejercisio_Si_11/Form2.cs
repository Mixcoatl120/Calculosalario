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
    public partial class Form2 : Form
    {
        public static string Empleado, SS,nombre;
        public static decimal Salario;
        public static int dias;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SS = textBox1.Text;
            Empleado = textBox2.Text;
            Salario = Convert.ToDecimal(textBox3.Text);
            nombre = textBox5.Text;
            dias = Convert.ToInt16(textBox4.Text);
            Form3 form3 = new Form3();
            form3.Show();
            Close();
        }
    }
}
