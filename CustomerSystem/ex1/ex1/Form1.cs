using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form1 : Form, IUiListener
    {
        protected CCustomerFactory factory = new CCustomerFactory();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void displayCustomerInfo()
        {
            txtId.Text = factory.getCurrent().id.ToString();
            txtName.Text = factory.getCurrent().name;
            txtPhone.Text = factory.getCurrent().phone;
            txtEmail.Text = factory.getCurrent().mail;
            txtAddrs.Text = factory.getCurrent().addrs;
        }

        public void moveFirst()
        {
            factory.moveFirst();
            displayCustomerInfo();
        }

        public void moveLeft()
        {
            factory.moveLeft();
            displayCustomerInfo();
        }

        public void moveRight()
        {
            factory.moveRight();
            displayCustomerInfo();
        }

        public void moveLast()
        {
            factory.moveLast();
            displayCustomerInfo();
        }

        internal void moveTo(int p)
        {
            factory.moveTo(p);
            displayCustomerInfo();
        }

        protected void findById(string strId)
        {
            factory.getById(strId);
            displayCustomerInfo();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*if ((e.Control) && (e.KeyValue == 37))
            {
                count = 0;
                displayCustomerInfo();
            }
            else if ((e.Shift) && (e.KeyValue == 37))
            {
                count--;
                if (count < 0)
                {
                    count = 0;
                }
                displayCustomerInfo();
            }
            else if ((e.Shift) && (e.KeyValue == 39))
            {
                count++;
                if (count > customers.Length - 1)
                {
                    count = customers.Length - 1;
                }
                displayCustomerInfo();
            }
            else if ((e.Control) && (e.KeyValue == 39))
            {
                count = customers.Length - 1;
                displayCustomerInfo();
            }*/

            if ((e.Control) && (e.KeyCode == Keys.Left))
            {
                moveFirst();
            }
            else if ((e.Shift) && (e.KeyCode == Keys.Left))
            {
                moveLeft();
            }
            else if ((e.Shift) && (e.KeyCode == Keys.Right))
            {
                moveRight();
            }
            else if ((e.Control) && (e.KeyCode == Keys.Right))
            {
                moveLast();
            }            
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txtId.Focus();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                this.txtName.Focus();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txtId.Focus();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                this.txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txtName.Focus();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                this.txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txtPhone.Focus();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                this.txtAddrs.Focus();
            }
        }

        private void txtAddrs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.txtEmail.Focus();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                this.txtAddrs.Focus();
            }
        }
    }
}
