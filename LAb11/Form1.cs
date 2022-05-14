using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAb11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double mean, variance;
        int size;

        double empiricMean, empiricVariance;
        double errE, errD;
        double chiSquared;
        double[] chiSquaredValues = new double[15] {3.841, 5.991, 7.815, 9.488, 11.070, 12.592, 14.067, 15.507, 
                                                    16.919, 18.307, 19.675, 21.026, 22.362, 23.685, 24.996};

        int k;
        double spanLength;
        int[] spanCount;
        double[] spanFrequency;
        double[] spanLen;
        double max = -99999, min = 99999;
        double[] normalDis = new double[10000];

        double curLength;

        Random rnd = new Random();
        double l1, l2;

        private void btStart_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            max = 0; min = 0; chiSquared = 0;
            mean = (double)numMean.Value;
            variance = (double)numVariance.Value;
            size = (int)numSize.Value;
            
            for (int i = 0; i < size; i+=2)
            {
                l1 = rnd.NextDouble();
                l2 = rnd.NextDouble();
                normalDis[i] = Math.Sqrt((-2) * Math.Log(l1)) * Math.Sin(2 * Math.PI * l2) * Math.Sqrt(variance) + mean;
                normalDis[i + 1] = Math.Sqrt((-2) * Math.Log(l1)) * Math.Cos(2 * Math.PI * l2) * Math.Sqrt(variance) + mean;
                if (normalDis[i] > max)
                    max = normalDis[i];
                if (normalDis[i] < min)
                    min = normalDis[i];
                if (normalDis[i + 1] > max)
                    max = normalDis[i + 1];
                if (normalDis[i + 1] < min)
                    min = normalDis[i + 1];

                empiricMean += normalDis[i] + normalDis[i + 1];
                empiricVariance += normalDis[i] * normalDis[i] + normalDis[i + 1] * normalDis[i + 1];
            }
            
            empiricMean = empiricMean / size;
            empiricVariance = empiricVariance / size - empiricMean * empiricMean;
            errE = Math.Abs(empiricMean - mean) / Math.Abs(mean) * 100;
            errD = Math.Abs(empiricVariance - variance) / Math.Abs(variance) * 100;
            labelAverage.Text = "Average: " + Math.Round(empiricMean, 2).ToString() + 
                                "(error = " + Math.Round(errE, 2) + "%)";
            labelVariance.Text = "Variance: " + Math.Round(empiricVariance, 2).ToString() + 
                                "(error = " + Math.Round(errD, 2) + "%)";

            k = (int)Math.Log(size, 2) + 1;
            spanLength = (max - min) / k;
            spanCount = new int[k];
            for(int i = 0; i < size; i++)
            {
                curLength = min + spanLength;
                int j = 0;
                while (j < k)
                {
                    if (normalDis[i] < curLength)
                    {
                        spanCount[j]++;
                        break;
                    }
                    else
                    {
                        curLength += spanLength;
                        j++;
                    }   
                }
                normalDis[i] = 0;
            }
            
            spanFrequency = new double[k];
            spanLen = new double[k + 1];
            double min1 = min;
            double pi = 0, px = 0;
            double x = 0;
            for (int i = 0; i < k; i++)
            {
                spanFrequency[i] = (double)spanCount[i] / size;
                x = (min1 + min1 + spanLength) / 2;
                px = (1 / (Math.Sqrt(2 * Math.PI) * Math.Sqrt(variance))) *
                    Math.Exp(-((x - mean) * (x - mean)) / (2 * variance));
                pi = ((min1 + spanLength) - min1) * px;
                chiSquared += (spanCount[i] * spanCount[i]) / (double)(size * pi); 
                spanLen[i] = min1;
                chart1.Series[0].Points.AddXY(min1, spanFrequency[i]);
                min1 += spanLength;
            }
            chart1.Series[0].Points.AddXY(min1, spanFrequency[k - 1]);
            //chart1.ChartAreas[0].AxisX.Minimum = min - 0.01;
            //chart1.ChartAreas[0].AxisX.Maximum = max + 0.01;
            chart1.ChartAreas[0].AxisX.Minimum = -5;
            chart1.ChartAreas[0].AxisX.Maximum = 5;

            chiSquared -= size;
            labelChiSquared.Text = "Chi-squared: " + Math.Round(chiSquared, 2) + " > " + chiSquaredValues[k - 1].ToString() + " is ";
            if (chiSquared > chiSquaredValues[k - 2])
            {
                labelChiSquared.Text += "True";
            }
            else
                labelChiSquared.Text += "False";
        }
    }
}
