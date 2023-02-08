using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private delegate int GenerateRandomDelegate();
        private GenerateRandomDelegate generateRandomDelegate;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int threadCount = int.Parse(textBox1.Text);
            generateRandomDelegate = new GenerateRandomDelegate(GenerateRandom);
            IAsyncResult[] asyncResultArray = new IAsyncResult[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                asyncResultArray[i] = generateRandomDelegate.BeginInvoke(null, null);
            }

            for (int i = 0; i < threadCount; i++)
            {
                int randomNumber = generateRandomDelegate.EndInvoke(asyncResultArray[i]);
             
                //textBox2.Text(randomNumber.ToString());
                textBox2.AppendText(randomNumber.ToString());
                textBox2.Clear();

               // lstRandomNumbers.Items.Add(randomNumber);
            }
        }



        private int GenerateRandom()
        {
          Thread.Sleep(1000);
            Random random = new Random();
            return random.Next(1, 100);
        }
    }
}
