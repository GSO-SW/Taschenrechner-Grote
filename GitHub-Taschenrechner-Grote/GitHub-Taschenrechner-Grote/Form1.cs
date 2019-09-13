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
                //Input aufteilen 

                string[] inputStringArr = input.Split('+');

                //input Konvertieren

                double[] inputIntArr = inputStringArr.Select(x => Convert.ToDouble(x)).ToArray();

                //summieren

                result = inputIntArr.Sum();

                txtResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Falsche Eingabe!");
            }
            
            
            


        }
    }
}
