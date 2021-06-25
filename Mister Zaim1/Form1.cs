using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mister_Zaim1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sum;
        double sum1;
        string Percent;
        double time;
        double payment;
        string[] percents;
        double[] dpercents;
        double nakoplenie;
        private void ButtonCount_Click(object sender, EventArgs e)
        {
            LvPayments.Items.Clear();

                try
            {
                double[] dpercents = new double[40];
                sum = Convert.ToDouble(TbSum.Text);
                time = Convert.ToDouble(TbDays.Text);
                string Percent = TbPercent.Text;
                string[] percents = TbPercent.Text.Split(' ');
                for(int i = 0; i <= percents.Length; i++)
                {
                    dpercents[i] = Convert.ToDouble(percents[i]);
                }
                for (int i = 0; i <= percents.Length; i++)
                {
                    dpercents[i] = Convert.ToDouble(percents[i]);
                }
            }
                catch (FormatException)
            {
                MessageBox.Show("Неправильный формат ввода данных");
            }

            for (int i=0; i < dpercents.Length;i++)
            {
                sum1+= dpercents[i];
            }
            sum1 = sum1 * 100;
            TbSumOfPercent.Text = Convert.ToString(sum1);

            TbFullSum.Text = Convert.ToString(sum1 + sum);


            
        }
    }
}

