using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT3_Fuck
{
    public partial class Fourea : Form
    {
        double[] sourceModule, predictedModule;

        public Fourea(double[] sourceModule, double[] predictedModule)
        {
            InitializeComponent();
            this.sourceModule = sourceModule;
            this.predictedModule = predictedModule;
        }

        private void Fourea_Load(object sender, EventArgs e)
        {
            FoureaChart.Series[0].Points.Clear();
            FoureaChart.Series[1].Points.Clear();

            for(int i = 0; i < sourceModule.Length; i++)
            {
                FoureaChart.Series[0].Points.AddXY(i / (double)sourceModule.Length, sourceModule[i]);
            }

            for (int i = 0; i < predictedModule.Length; i++)
            {
                FoureaChart.Series[1].Points.AddXY(i / (double)predictedModule.Length, predictedModule[i]);
            }
        }
    }
}
