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

namespace esercizio_stackqueue
{
    public partial class Form1 : Form
    {
        private Stack<int> stack = new Stack<int>();
        private Queue<int> queue = new Queue<int>();
        private Thread threadStack, threadQueue;
        private bool runningStack = false, runningQueue = false;
        private int counterS = 0, counterQ = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartStack_Click(object sender, EventArgs e)
        {
            if (threadStack == null || !runningStack)
            {
                runningStack = true;
                threadStack = new Thread(RunThreadStack);
                threadStack.Start();
            }
        }

        private void btnStartQueue_Click(object sender, EventArgs e)
        {
            if (threadQueue == null || !runningQueue)
            {
                runningQueue = true;
                threadQueue = new Thread(RunThreadQueue);
                threadQueue.Start();
            }
        }

        private void RunThreadStack()
        {
            while (runningStack)
            {
                counterS++;
                stack.Push(counterS);
                Invoke((MethodInvoker)(() => listBox1.Items.Add(counterS)));
                Thread.Sleep(1000);
            }
        }

        private void RunThreadQueue()
        {
            while (runningQueue)
            {
                counterQ++;
                queue.Enqueue(counterQ);
                Invoke((MethodInvoker)(() => listBox2.Items.Add(counterQ)));
                Thread.Sleep(1000);
            }
        }

        private void btnStopStack_Click(object sender, EventArgs e)
        {
            runningStack = false;
            threadStack = null;
            listBox1.Items.Clear();

            foreach (int num in stack)
            {
                listBox1.Items.Add(num);
            }
        }

        private void btnStopQueue_Click(object sender, EventArgs e)
        {
            runningQueue = false;
            threadQueue = null;
            listBox2.Items.Clear();

            foreach (int num in queue)
            {
                listBox2.Items.Add(num);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
