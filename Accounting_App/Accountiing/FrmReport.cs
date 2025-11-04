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
using Accounting.Utility.Convertor;
using Accounting_App.Accountiing;
using Accounting_App.Customers;
using Accounting.ViewModel.Customers;


namespace Accounting_App.Accountiing
{
    public partial class FrmReport : Form
    {
        public int typeID = 0;
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<GetcustomerList> list = new List<GetcustomerList>();
                list.Add(new GetcustomerList
                {
                    CustomerID = 0,
                    FullName = "Pleas Selected"

                });
                list.AddRange(db.CustomerRepository.GetNameCustomerByFilter());
                cmcustomer.DataSource = list;
                cmcustomer.DisplayMember = "fullName";
                cmcustomer.ValueMember = "CustomerID";
            }
         
            if (typeID == 1)
            {
                this.Text = "Receipts Report";
            }
            else
            {
                this.Text = "Payment Report";
            }
        }

        private void Btnsubmit_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
          
            DateTime? startDate;
            DateTime? EndDate;
            using (UnitOfWork db = new UnitOfWork())
            {
                List<Accounting.DataLAyer.Accounting> result = new List<Accounting.DataLAyer.Accounting>();
                if ((int)cmcustomer.SelectedIndex != 0)
                {
                    int id = int.Parse(cmcustomer.SelectedValue.ToString());
                    result.AddRange(db.GenericRepositorey.Get(c => c.TypeID == typeID && c.CustomerId == id));
                }
                else
                {
                    result.AddRange(db.GenericRepositorey.Get(c => c.TypeID == typeID).ToList());
                }
                if (txtstartdate.Text != "    /  /")
                {
                    try
                    {
                        startDate = Convert.ToDateTime(txtstartdate.Text);
                        startDate = startDate.Value.ToMiladi();
                        result = result.Where(r => r.Datatime >= startDate.Value).ToList();
                    }
                    catch
                    {
                        MessageBox.Show("Not Find!");
                    }
                }
                if (txtenddate.Text != "    /  /")
                {
                    try
                    {
                        EndDate = Convert.ToDateTime(txtenddate.Text);
                        EndDate = EndDate.Value.ToMiladi();
                        result = result.Where(r => r.Datatime <= EndDate.Value).ToList();
                    }
                    catch
                    {
                        MessageBox.Show("Not Find!");
                    }
                }
              dgreport.Rows.Clear();
                foreach (var item in result)
                {
                    string customerName = db.CustomerRepository.GetNamecustomrerById(item.CustomerId);
                    dgreport.Rows.Add(item.ID, customerName, item.Amount, item.Datatime.ToShamsi(), item.Description);
                }

            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Btndeletereport_Click(object sender, EventArgs e)
        {
            if (dgreport.CurrentRow != null)
            {
                string fullname = dgreport.CurrentRow.Cells[1].Value.ToString();
                if(MessageBox.Show($"You agree with the removal of {fullname}", "attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        int CustomerId = int.Parse(dgreport.CurrentRow.Cells[0].Value.ToString());
                        db.GenericRepositorey.Delete(CustomerId);
                        db.Save();
                        Filter();
                    }
                    

                }
            }
        }

        private void BtnEditreport_Click(object sender, EventArgs e)
        {
            if (dgreport.CurrentRow != null)
            {
                int ID = int.Parse(dgreport.CurrentRow.Cells[0].Value.ToString());
                NewTransaction newTransaction = new NewTransaction();
                newTransaction.AccountID = ID;
                if (newTransaction.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }

        }
    }
}
