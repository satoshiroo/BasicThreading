using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BasicThreading
{
    public partial class BasicThreading : Form
    {
        private Thread ThreadA, ThreadB;

        public BasicThreading()
        {
            InitializeComponent();
        }

        private void BasicThreading_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Before starting thread");

            ThreadA = new Thread(MyThreadClass.Thread1);
            ThreadB = new Thread(MyThreadClass.Thread1);

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();


            Console.WriteLine("-End of thread-");
            label1.Text = "-End of Thread-";
            //comment kasi namali ng commit//
        }
    }
}
