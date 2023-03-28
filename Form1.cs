using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knut
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//rand
        {
            int[] numbers = new int[20];
            int[] Array = new int[20];
            Random rnd1 = new Random();

            for (int i = 0; i < 20; i++)
                table.Rows.Add();

            for (int i = 0; i < 1; i++)
                table.Columns.Add(i.ToString(), i.ToString());

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    numbers[i] = i + 1;
                    table.Rows[i].Cells[0].Value = numbers[i];
                    table.Rows[i].Cells[1].Value = rnd1.Next(0, 99);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//coef
        {
            string[] a = new string[table.RowCount];
            int[] b = new int[table.RowCount];

            int sum_el = 0;
            int sum_el2 = 0;
            int first_coef = 0; 
            int second_coef = 0;

            for (int i = 0; i < table.RowCount - 1; i++)
            {
                a[i] = table[1, i].Value.ToString();
                int.TryParse(a[i], out b[i]);
            }

           for (int i = 0; i < b.Length; i++)
               sum_el += b[i];

            first_coef = sum_el / b.Length;

           for (int i = 0;i < b.Length; i++)
                sum_el2 += Math.Abs(b[i] - first_coef);

            second_coef = sum_el2 / b.Length;

            
            MessageBox.Show(string.Format(Convert.ToString(second_coef).PadLeft(2, '0') + " "), "Коэффициент:");

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/* double sum = 0, sum2 = 0, sumShifted = 0;
            double first = GetNext(0);
            double prev = first;
            for (int i = 0; i < n; i++)
            {
                double next = i == (n - 1) ? first : GetNext(i + 1);

                sum += prev;
                sum2 += prev * prev;
                sumShifted += prev * next;

                prev = next;
            }
            double coeff = (n * sumShifted - sum * sum) / (n * sum2 - sum * sum);*/


/*int[] numbers_vvod = new int[20];
           int[] num = new int[50];

          for (int i = 0; i < textBox1.TextLength; i++)
              numbers_vvod[i] = int.Parse(textBox1.ToString());

           for (int i = 0; i < numbers_vvod.Length; i++)
               table.Rows.Add();

           for (int i = 0; i < 1; i++)
               table.Columns.Add(i.ToString(), i.ToString());

           for (int i = 0; i < numbers_vvod.Length; i++)
           {
               for (int j = 0; j < 2; j++)
               {
                   num[i] = i + 1;
                   table.Rows[i].Cells[0].Value = num[i];
                   table.Rows[i].Cells[1].Value = numbers_vvod[i];
               }
           }*/