using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_POS__Simple_
{
    public partial class Login : Form
    {
        protected Employeefactory factory = new Employeefactory();
        bool boolCancel = true;

        public Login()
        {
            InitializeComponent();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(tb帳號輸入.Text)) || (string.IsNullOrEmpty(tb密碼輸入.Text)))
            {
                MessageBox.Show("Please type in account or password.");
                return;
            }

            Employee employees = factory.getById(tb帳號輸入.Text);

            if (employees != null)
            {
                if (tb密碼輸入.Text.Equals(employees.mail))
                {
                    boolCancel = false;
                    this.Close();                    

                    return;                    
                }
            }

            MessageBox.Show("One of the account and password is not correct.");
        }

        private void btn清除欄位_Click(object sender, EventArgs e)
        {
            tb帳號輸入.Clear();
            tb密碼輸入.Clear();
        }

        private void Login_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = boolCancel;
        }
    }
}
