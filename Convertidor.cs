using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FahrenheitCelsius;

namespace ConvertidorGrados
{
    public partial class Convertidor : UserControl
    {
        double fahrn, celss;
        public Convertidor()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Grados change = new Grados(fahrn, celss);
            
            if (rbCelToFah.Checked == true)
            {
                celss = double.Parse(tbxWrite.Text);
                change.Fah();
                tbxResults.Text = Convert.ToString(change.R);
            } else if (rbFahToCel.Checked == true)
            {
                fahrn = double.Parse(tbxWrite.Text);
                change.Cel();
                tbxResults.Text = Convert.ToString(change.R);
            }
        }
    }
}
