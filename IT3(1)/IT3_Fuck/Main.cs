using System;

using System.Windows.Forms;

namespace IT3_Degradation
{
    public partial class Main : Form
    {
        double[] freqArray, ampArray;
        int size, noise, amount, sizeM;
        double edge;
        double[] signal, autoReg;

        public Main()
        {
            InitializeComponent();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            label16.Visible = false;
            EdgeText.Visible = false;
            freqArray = new double[5];
            ampArray = new double[5];
        }

        void Initialize()
        {
            freqArray[0] = Convert.ToDouble(Freq1.Text);
            freqArray[1] = Convert.ToDouble(Freq2.Text);
            freqArray[2] = Convert.ToDouble(Freq3.Text);
            freqArray[3] = Convert.ToDouble(Freq4.Text);
            freqArray[4] = Convert.ToDouble(Freq5.Text);

            ampArray[0] = Convert.ToDouble(Amp1.Text);
            ampArray[1] = Convert.ToDouble(Amp2.Text);
            ampArray[2] = Convert.ToDouble(Amp3.Text);
            ampArray[3] = Convert.ToDouble(Amp4.Text);
            ampArray[4] = Convert.ToDouble(Amp5.Text);

            size = Convert.ToInt32(SizeText.Text);
            noise = Convert.ToInt32(NoiseText.Text);//use "try catch" or "try parce"
            amount = Convert.ToInt32(AmountText.Text);
            sizeM = Convert.ToInt32(SizeMText.Text);
            edge = Convert.ToDouble(EdgeText.Text);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Initialize();

            Autoregresion drawer = new Autoregresion(ampArray, freqArray, amount, noise, sizeM, size, edge);

            signal = new double[size];
            signal = drawer.CreateGraph(signal);

            signal = drawer.AddNoise(signal);

            autoReg = drawer.Calc(signal);

            MainChart.Series[0].Points.Clear();
            MainChart.Series[1].Points.Clear();
            for (int i = 1; i < size; i++)
            {
                MainChart.Series[0].Points.AddXY(i, signal[i]);
                MainChart.Series[1].Points.AddXY(i, autoReg[i]);
            }
        }
    }
}
