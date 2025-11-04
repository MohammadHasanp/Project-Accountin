using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLAyer;
using Accounting.DataLAyer.Context;

namespace Accounting_App.Customers
{
    public partial class CustomerChange : Form
    {
        public CustomerChange()
        {
            InitializeComponent();
        }

        private void CustomerChange_Load(object sender, EventArgs e)
        {
            Startover();
        }

        private void Startover()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomerList.AutoGenerateColumns = false;
                dgCustomerList.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtseerch.Clear();
            Startover();
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomerList.CurrentRow != null)
            {
                string fullname = dgCustomerList.CurrentRow.Cells[1].Value.ToString();
               
                if (MessageBox.Show($"Do you agree with the removal of {fullname}", "attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        int Customerid = int.Parse(dgCustomerList.CurrentRow.Cells[0].Value.ToString());
                        db.CustomerRepository.DeleteCustomer(Customerid);
                        db.Save();
                        Startover();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا شخصی را انتخاب کنید");
            }
        }

        private void BtnInsertCustomer_Click(object sender, EventArgs e)
        {
            Add_or_edit_customer frmaddoredit = new Add_or_edit_customer();
            if (frmaddoredit.ShowDialog() == DialogResult.OK)
            {
                Startover();
            }
        }

        private void EditCystomer_Click(object sender, EventArgs e)
        {
            if (dgCustomerList.CurrentRow != null)
            {
                int customerId = int.Parse(dgCustomerList.CurrentRow.Cells[0].Value.ToString());
                Add_or_edit_customer frmaddoredit = new Add_or_edit_customer();
                frmaddoredit.CustomerID = customerId;
                if (frmaddoredit.ShowDialog() == DialogResult.OK)
                {
                    Startover();
                }
            }

        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomerList.DataSource = db.CustomerRepository.GetCustomersByFilter(txtseerch.Text);
            }
        }

        private void dgCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
