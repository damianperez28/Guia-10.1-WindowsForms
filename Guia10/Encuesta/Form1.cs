using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuesta
{
    public partial class Encuesta : Form
    {
        public Encuesta()
        {
            InitializeComponent();
        }
        static int contBici = 0;
        static int contMoto = 0;
        static int contAuto = 0;
        static int contTrPublic = 0;
        static double acumKmBici = 0;
        static double acumKmMoto = 0;
       
        private void button1_Click(object sender, EventArgs e)
        {
            double kilometros = Convert.ToDouble(textBox1.Text);

            if (rbBici.Checked == true)
            {
                contBici++;
                acumKmBici = acumKmBici + kilometros;
            }
            if (rbMoto.Checked == true)
            {
                contMoto++;
                acumKmMoto = acumKmMoto + kilometros;
            }
            if (rbAuto.Checked == true)
            {
                contAuto++;
            }
            if (rbTrPublic.Checked == true)
            {
                contTrPublic++;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int poblacion = contAuto + contBici + contTrPublic + contMoto;
            double promBici = acumKmBici / contBici;
            double promMoto = acumKmMoto / contMoto;

            listBox1.Items.Add("Poblacion total: " + poblacion);
            listBox1.Items.Add("Cantidad de personas que usan bicicleta: " + contBici);
            listBox1.Items.Add("Cantidad de personas que usan motocicleta: " + contMoto);
            listBox1.Items.Add("Cantidad de personas que usan automovil: " + contAuto);
            listBox1.Items.Add("Cantidad de personas que usan transporte publico: " + contTrPublic);
            listBox1.Items.Add("Promedio de distancia de usuarios de bicicleta: " + promBici);
            listBox1.Items.Add("Promedio de distancia de usuarios de motocicleta: " + promMoto);

        }
    }
}
