using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub_Taschenrechner_Grote
{
    public partial class frmTaschenrechner : Form
    {
        public frmTaschenrechner()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Leerstellen entfernen

            string input = txtCalc.Text.Replace(" ","");
            double result = 0;

            try
            {
                //Input aufteilen zum Addieren

                string[] inputStringAddArr = input.Split('+');

                //dieses array weiter aufteilen

                string[][] inputStringArr = inputStringAddArr.Select(x => x.Split('*')).ToArray();

                //Die einzelnen werte Konvertieren

                double[][] doubleArrArr = inputStringArr.Select(x => x.Select(y => Convert.ToDouble(y)).ToArray()).ToArray();

                //zuerst Multiplizieren

                double[] doubleArr = doubleArrArr.Select(x=> 
                {
                    double a = 1;
                    x.ToList().ForEach(y => a *= y);

                    return a;
                }).ToArray();

                //dann Summieren;

                result = doubleArr.Sum();

                txtResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Falsche Eingabe!");
            }                                  
        }
    }
}
