using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Halfway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // **********************************************************************

        /// <summary>
        /// Calcul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calc_Click(object sender, EventArgs e)
        {
            // Déclaration
            decimal middlerange, up, dn;
            
            // Calcul de la valeur milieu en f° de la direction
            if (isShort.Checked)
            {
                up = upValue.Value + (decimal)0.01;
                dn = dnValue.Value;
            }
            else
            {
                up = upValue.Value;
                dn = dnValue.Value - (decimal)0.01;
            }
            middlerange = (up + dn) / 2;

            // Affichage
            mid.Text = middlerange.ToString();
        }

        // **********************************************************************

        /// <summary>
        /// Remplacement des '.' en ',' en tapant sur up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

        // **********************************************************************

        /// <summary>
        /// Remplacement des '.' en ',' en tapant sur dn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dnValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
        }
    }
}
