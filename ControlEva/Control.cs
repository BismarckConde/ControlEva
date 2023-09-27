using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEva
{
    public partial class Control : Form
    {
        public List<Promedio> promedios;
        private object rbRegular;

        public Control()
        {
            InitializeComponent();
            promedios = new List<Promedio>();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Control_Load(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void Motrar(double promedioRegular)
        {

        }

        private void btnregistrar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtnombre.Text) &&
                    double.TryParse(txteva1.Text, out double eva1) &&
                    double.TryParse(txteva2.Text, out double eva2) &&
                    double.TryParse(txteva3.Text, out double eva3) &&
                    double.TryParse(txtacti.Text, out double acti))
            {
                Promedio promedio;
                {

                    promedio = new PromedioProgramacion
                    {
                        nombre = txtnombre.Text,
                        eva1 = eva1,
                        eva2 = eva2,
                        eva3 = eva3,
                        NActtitu = acti,
                    };
                    double promedioRegular = ((PromedioProgramacion)promedio).CalcularPromedioRegu();
                    Motrar(promedioRegular);
                }

                Promedio promedios;
                {

                    promedio = new PromedioProgramacion
                    {
                        nombre = txtnombre.Text,
                        eva1 = eva1,
                        eva2 = eva2,
                        eva3 = eva3,
                        NActtitu = acti,
                    };
                    double promedioPregrado = ((PromedioProgramacion)promedio).CalcularPromedioRegu();
                    Motrar(promedioPregrado);
                }




            }

        }
    }
}





