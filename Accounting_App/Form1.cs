using Accounting.Business;
using Accounting.ViewModel.Accounting;
using Accounting_App.Accountiing;
using Accounting_App.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_App
{
    public partial class Form1 : Form
    {
        public bool IsLogin = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccountside_Click(object sender, EventArgs e)
        {
            CustomerChange customerChange = new CustomerChange();
            customerChange.ShowDialog();
        }

        private void btnpaymentreport_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.typeID = 2;
            frmReport.ShowDialog();
        }

        private void btnIncomingreports_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.typeID = 1;
            frmReport.ShowDialog();
        }

        private void btnNewtransaction_Click(object sender, EventArgs e)
        {
            NewTransaction newTransaction = new NewTransaction();
            newTransaction.ShowDialog();
        }

        private void editPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Isedit = true;
            frmLogin.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            report();
        }
        void report()
        {
            ReportViewModel reportview = Account.reportView();
            lblpayment.Text = reportview.Pay.ToString("#,0");
            lblreceived.Text = reportview.Recive.ToString("#,0");
            lblremainder.Text = reportview.AccountBalamce.ToString("#,0");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            report();
        }
    }
}
