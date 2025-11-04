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

namespace Accounting_App
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public bool Isedit = false;
        public bool IsLogin = false;
        private void Showpass_Click(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                txtpass.PasswordChar = '\0';
            }
            else
                txtpass.PasswordChar = '*';
        }

        private void Btnsubmit_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (Isedit)
                {
                    var login = db.LogonRepository.Get().First();
                    login.Name = txtname.Text;
                    login.Password = txtpass.Text;
                    db.LogonRepository.Update(login);
                    db.Save();
                    Application.Restart();

                }
                else
                {
                    if (db.LogonRepository.Get(l => l.Name == txtname.Text && l.Password == txtpass.Text).Any())
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Not Find User!");
                    }
                }
               
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (Isedit)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    this.Text = "Edit Password";
                    var login = db.LogonRepository.Get().First();
                    txtname.Text = login.Name;
                    txtpass.Text = login.Password;
                }
            }
        }
    }
}
