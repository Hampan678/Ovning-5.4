using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            bool ordning = false;
            int TalA = int.Parse(tbxA.Text);
            int TalB = int.Parse(tbxB.Text);
            int TalC = int.Parse(tbxC.Text);
            //TalA måste vara mindre eller lika med TalB och TalB måste vara mindre eller lika med TalC för att svaret ska bli: True//
            ordning = TalA <= TalB && TalB <= TalC;
            
            lblSvar.Text = " Talen är i ordningsföljd: " + ordning.ToString();
         
        }
   
    }
}
