using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pressure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            double Density = Convert.ToDouble(txtdensity.Text);
            double Height = Convert.ToDouble(txtheight.Text);
            double Gravity = Convert.ToDouble(txtgravity.Text);
            double Pressure = Density * Height * Gravity;
            string pressure = Convert.ToString(Pressure);
            double Pressurecmhg = Pressure / 1360;
            string pressurecmhg = Convert.ToString(Pressurecmhg);
            double Pressuremmhg = Pressure / 13600;
            string pressuremmhg = Convert.ToString(Pressuremmhg);
            double Pressurebar = Pressure / 100000;
            string pressurebar = Convert.ToString(Pressurebar);
            lblheight2.Text = txtheight.Text;
            lbldensity2.Text =txtdensity.Text;
            lblanspa.Text = pressure;
            lblanscm.Text = pressurecmhg;
            lblasnmm.Text = pressuremmhg;
            lblansbar.Text = pressurebar; 


        }
    }
}
