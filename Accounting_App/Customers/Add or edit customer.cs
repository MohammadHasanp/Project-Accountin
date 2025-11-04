using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Accounting.DataLAyer;
using Accounting.DataLAyer.Context;

namespace Accounting_App.Customers
{
    public partial class Add_or_edit_customer : Form
    {
        public Add_or_edit_customer()
        {
            InitializeComponent();
        }
        UnitOfWork db = new UnitOfWork();
        public int CustomerID = 0;
        bool check()
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Pleas Fill Name!");
                return false;
            }
            if (txtmobil.Text == "")
            {
                MessageBox.Show("Pleas Fill Mobil!");
                return false;
            }
            if (txtemail.Text == "")
            {
                MessageBox.Show("Pleas Fill Email!");
                return false;
            }
            return true;
        }
        private void Btnaddoredit_Click(object sender, EventArgs e)
        {
            string imagename = Guid.NewGuid().ToString() + Path.GetExtension(openFileDialog1.FileName);
            string path = Application.StartupPath + "/Image/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            pictureBox1.Image.Save(path + imagename);
            if (check())
            {
                Customer customers = new Customer()
                {
                    Address = txtaddress.Text,
                    Email = txtemail.Text,
                    FullName = txtname.Text,
                    Mobil = txtmobil.Text,
                    CustomerImage = imagename
                };
                if (CustomerID == 0)
                {
                    db.CustomerRepository.InsertCustomer(customers);
                }
                else
                {
                    customers.CustomerID = CustomerID;
                    db.CustomerRepository.Update(customers);
                }

                db.Save();
                DialogResult = DialogResult.OK;

            }
        }

        private void Btnselectimage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Add_or_edit_customer_Load(object sender, EventArgs e)
        {
            if (CustomerID != 0)
            {
                this.Text = "Edit Person";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var customer = db.CustomerRepository.GetCustomerById(CustomerID);
                    txtname.Text = customer.FullName;
                    txtmobil.Text = customer.Mobil;
                    txtemail.Text = customer.Email;
                    txtaddress.Text = customer.Address;
                    pictureBox1.ImageLocation = Application.StartupPath + "/Image/" + customer.CustomerImage;
                }
                
            }
            else
                this.Text = "New Person";

        }
    }
}
