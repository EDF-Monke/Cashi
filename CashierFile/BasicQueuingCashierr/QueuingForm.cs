using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashierr
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier = new CashierClass();
        public QueuingForm()
        {
            InitializeComponent();
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
            cashierWindow.Show();
        }
        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
            Console.WriteLine($"Enqueued: {CashierClass.getNumberInQueue}"); 
        }  
        private void label2_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
        }
    }
}
