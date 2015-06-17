using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Resources;
using System.Reflection;
using System.Globalization;


namespace ex1
{
    public partial class Login : Form
    {
        protected CCustomerFactory factory = new CCustomerFactory();
        bool boolCancel = true;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("plz type in account or password.");
                //return;
            }

            CCustomer customer = factory.getById(textBox1.Text);

            if (customer != null)
            {
                if (textBox2.Text.Equals(customer.mail))
                {
                    boolCancel = false;
                    this.Close();                   
                    return;
                }
            }

            MessageBox.Show("one of the account and password is not correct.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = boolCancel;
        }

        private void rdo中文_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo中文.Checked)
            {
                label3.Text = resTChinese.L_title;
                label1.Text = resTChinese.L_account;
                label2.Text = resTChinese.L_password;
                button1.Text = resTChinese.L_login;
                button2.Text = resTChinese.L_clear;
            }
            else if (rdo英文.Checked)
            {
                label3.Text = resEnglish.L_title;
                label1.Text = resEnglish.L_account;
                label2.Text = resEnglish.L_password;
                button1.Text = resEnglish.L_login;
                button2.Text = resEnglish.L_clear;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switchLanguage("ja-JP");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switchLanguage("ko-KR");
        }

        void switchLanguage(string p_strKey)
        {
            ResourceManager l_manager = new ResourceManager(
                "prjMultiLanguageSample.Form1",
                Assembly.GetExecutingAssembly());

            CultureInfo l_cultureInfo = new CultureInfo(p_strKey);

            Thread.CurrentThread.CurrentUICulture = l_cultureInfo;

            ComponentResourceManager l_resourceManager =
                new ComponentResourceManager(this.GetType());

            l_resourceManager.ApplyResources(label3, label3.Name);
            l_resourceManager.ApplyResources(label1, label1.Name);
            l_resourceManager.ApplyResources(label2, label2.Name);
            l_resourceManager.ApplyResources(button1, button1.Name);
            l_resourceManager.ApplyResources(button2, button2.Name);
        }
    }
}
