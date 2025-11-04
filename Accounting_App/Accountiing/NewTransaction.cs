using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting_App.Accountiing;
using Accounting.ViewModel.Customers;
using Accounting.DataLAyer.Servises;
using Accounting.DataLAyer.repository;
using Accounting.DataLAyer.Context;
using Accounting.DataLAyer;

namespace Accounting_App.Customers
{
    public partial class NewTransaction : Form
    {
        public NewTransaction()
        {
            InitializeComponent();
        }
        private UnitOfWork db;
        public int AccountID = 0;
        private void NewTransaction_Load(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.CustomerRepository.GetCustomersByFilter("");
            if (AccountID != 0)
            {
                    var res = db.GenericRepositorey.GetById(AccountID);
                    txtname.Text = db.CustomerRepository.GetNamecustomrerById(res.CustomerId);
                    txtdescription.Text = res.Description;
                    txtamount.Value = (int)res.Amount;
                    if (res.TypeID == 1) radioreceive.Checked = true;
                    else radiopayment.Checked = true;
                    this.Text = "Edit Transaction";
                db.Dispose();
            }
        }
        private void Txtseerch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.CustomerRepository.GetCustomersByFilter(txtseerch.Text);
        }
        public bool Check()
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Please fill Tom from the side list!");
                return false;
            }
            if (txtamount.Value == 0)
            {
                MessageBox.Show("Pleas Enter Amount!");
                return false;
            }
            if (radiopayment.Checked == false && radioreceive.Checked == false)
            {
                MessageBox.Show("Pleas Enter Transaction type!");
                return false;
            }
            return true;
        }
        private void Btnsubmit_Click_1(object sender, EventArgs e)
        {
            if (Check())
            {
                db = new UnitOfWork();
                Accounting.DataLAyer.Accounting accounting = new Accounting.DataLAyer.Accounting()
                {
                    Amount = int.Parse(txtamount.Value.ToString()),
                    CustomerId = db.CustomerRepository.GetCustomerIDByName(txtname.Text),
                    TypeID = (radioreceive.Checked) ? 1 : 2,
                    Datatime = DateTime.Now,
                    Description = txtdescription.Text,
                };
                if (AccountID == 0)
                {
                    db.GenericRepositorey.Insert(accounting);
                    db.Save();
                }
                else
                {
                    accounting.ID = AccountID;
                    db.GenericRepositorey.Update(accounting);
                    db.Save();
                }
            }
            db.Dispose();
            DialogResult = DialogResult.OK;
        }

        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
