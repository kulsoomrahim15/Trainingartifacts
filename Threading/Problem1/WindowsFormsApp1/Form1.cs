using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      



        private void button1_Click(object sender, EventArgs e)
        {
            // Generate random number of threads
            Random rand = new Random();
            int numThreads = rand.Next(1, 6);

            // Create and start threads
            for (int i = 0; i < numThreads; i++)
            {//generating thread from ThredProc
                Thread thread = new Thread(new ThreadStart(this.ThreadProc));
                thread.Start();
            }

        }

        //generating n no. of thereads
        private void ThreadProc()
        {
            // Append thread information to text box

            int threadId = Thread.CurrentThread.ManagedThreadId;

            //  textBox1.Text = textBox1.AppendText("This is some text being added to the end of the textbox"); threadId.ToString();

            textBox1.AppendText("Hello, My Thread ID is : [ " + threadId.ToString() + "]" + "\t");








        }





    }
}
