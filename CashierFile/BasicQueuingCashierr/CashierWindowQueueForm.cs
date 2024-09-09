using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashierr
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable cashierQueue)
        {
            listCashierQueue.Items.Clear(); 

            if (cashierQueue == null)
            {
                MessageBox.Show("Queue is null");
                return;
            }

            int count = 0;
            foreach (var item in cashierQueue)
            {
                listCashierQueue.Items.Add(item.ToString()); 
                count++;
            }
            Console.WriteLine($"Displayed {count} items in the list view.");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnRefresh.PerformClick(); 
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0) 
            {
                CashierClass.CashierQueue.Dequeue(); 
                btnRefresh.PerformClick(); 
            }
        }
    }
}
