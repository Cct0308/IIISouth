using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_POS__Simple_
{
    public partial class Form1 : Form
    {
        protected BeverageFactory beverages = new BeverageFactory();
        List<Beverage> listBeverages = new List<Beverage>();
        
        int n = 0;
        int menuNo = 1;
        int itemCount = 1;
        int itemChange = 0;
        string numberCount = "";
        string numberChange = "";
        int totalCount = 0;
        int totalPrice = 0;
        public string reportDate = String.Format(DateTime.Now.ToString("yyyy年MM月dd日"));

        bool boolCancel = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = boolCancel;
        }

        /*****flat buttons*****/

        private void 結帳功能_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Image = pic結帳功能up.Image;
        }

        private void 結帳功能_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).Image = pic結帳功能down.Image;
        }

        private void 結帳功能_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Label).Image = pic結帳功能up.Image;
        }

        private void 結帳功能_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Image = pic結帳功能flat.Image;
        }

        private void 結帳_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Image = pic結帳up.Image;
        }

        private void 結帳_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).Image = pic結帳down.Image;
        }

        private void 結帳_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Label).Image = pic結帳up.Image;
        }

        private void 結帳_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Image = pic結帳flat.Image;
        }

        private void 數字鍵盤_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Image = pic數字鍵盤up.Image;
        }

        private void 數字鍵盤_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).Image = pic數字鍵盤down.Image;
        }

        private void 數字鍵盤_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Label).Image = pic數字鍵盤up.Image;
        }

        private void 數字鍵盤_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Image = pic數字鍵盤flat.Image;
        }

        /*****select items*****/

        private void btn茉莉綠茶_Click(object sender, EventArgs e)
        {
            n = 1;
            itemDetailsArrangement();            
        }

        private void btn阿薩姆紅茶_Click(object sender, EventArgs e)
        {
            n = 2;
            itemDetailsArrangement();
        }

        private void btn四季春青茶_Click(object sender, EventArgs e)
        {
            n = 3;
            itemDetailsArrangement();
        }

        private void btn黃金烏龍_Click(object sender, EventArgs e)
        {
            n = 4;
            itemDetailsArrangement();
        }

        private void btn檸檬綠_Click(object sender, EventArgs e)
        {
            n = 5;
            itemDetailsArrangement();
        }

        private void btn梅果綠_Click(object sender, EventArgs e)
        {
            n = 6;
            itemDetailsArrangement();
        }

        private void btn８冰綠_Click(object sender, EventArgs e)
        {
            n = 7;
            itemDetailsArrangement();
        }

        private void btn多多綠_Click(object sender, EventArgs e)
        {
            n = 8;
            itemDetailsArrangement();
        }

        private void btn蜂蜜綠_Click(object sender, EventArgs e)
        {
            n = 9;
            itemDetailsArrangement();
        }

        private void btn冰淇淋紅茶_Click(object sender, EventArgs e)
        {
            n = 10;
            itemDetailsArrangement();
        }

        private void btn芒果青茶_Click(object sender, EventArgs e)
        {
            n = 11;
            itemDetailsArrangement();
        }

        private void btn鮮柚綠_Click(object sender, EventArgs e)
        {
            n = 12;
            itemDetailsArrangement();
        }

        private void btn紅茶拿鐵_Click(object sender, EventArgs e)
        {
            n = 13;
            itemDetailsArrangement();
        }

        private void btn烏龍拿鐵_Click(object sender, EventArgs e)
        {
            n = 14;
            itemDetailsArrangement();
        }

        private void btn珍珠紅茶拿鐵_Click(object sender, EventArgs e)
        {
            n = 15;
            itemDetailsArrangement();
        }

        private void btn波霸紅茶拿鐵_Click(object sender, EventArgs e)
        {
            n = 16;
            itemDetailsArrangement();
        }

        private void btn榛果紅茶拿鐵_Click(object sender, EventArgs e)
        {
            n = 17;
            itemDetailsArrangement();
        }

        private void btn焦糖紅茶拿鐵_Click(object sender, EventArgs e)
        {
            n = 18;
            itemDetailsArrangement();
        }

        private void btn仙草紅茶拿鐵_Click(object sender, EventArgs e)
        {
            n = 19;
            itemDetailsArrangement();
        }

        private void btn布丁紅茶拿鐵_Click(object sender, EventArgs e)
        {
            n = 20;
            itemDetailsArrangement();
        }

        private void btn冰淇淋紅茶拿鐵_Click(object sender, EventArgs e)
        {
            n = 21;
            itemDetailsArrangement();
        }

        private void btn阿華田拿鐵_Click(object sender, EventArgs e)
        {
            n = 22;
            itemDetailsArrangement();
        }

        private void btn可可芭蕾拿鐵_Click(object sender, EventArgs e)
        {
            n = 23;
            itemDetailsArrangement();
        }

        private void btn奶茶_Click(object sender, EventArgs e)
        {
            n = 24;
            itemDetailsArrangement();
        }

        private void btn奶綠_Click(object sender, EventArgs e)
        {
            n = 25;
            itemDetailsArrangement();
        }

        private void btn烏龍奶_Click(object sender, EventArgs e)
        {
            n = 26;
            itemDetailsArrangement();
        }

        private void btn珍珠奶茶_Click(object sender, EventArgs e)
        {
            n = 27;
            itemDetailsArrangement();
        }

        private void btn波霸奶茶_Click(object sender, EventArgs e)
        {
            n = 28;
            itemDetailsArrangement();
        }

        private void btn焦糖奶茶_Click(object sender, EventArgs e)
        {
            n = 29;
            itemDetailsArrangement();
        }

        private void btn仙草奶茶_Click(object sender, EventArgs e)
        {
            n = 30;
            itemDetailsArrangement();
        }

        private void btn布丁奶茶_Click(object sender, EventArgs e)
        {
            n = 31;
            itemDetailsArrangement();
        }

        private void btn冰淇淋奶茶_Click(object sender, EventArgs e)
        {
            n = 32;
            itemDetailsArrangement();
        }

        private void btn紅茶瑪奇朵_Click(object sender, EventArgs e)
        {
            n = 33;
            itemDetailsArrangement();
        }

        private void btn阿華田_Click(object sender, EventArgs e)
        {
            n = 34;
            itemDetailsArrangement();
        }

        private void btn可可芭蕾_Click(object sender, EventArgs e)
        {
            n = 35;
            itemDetailsArrangement();
        }

        private void btn檸檬汁_Click(object sender, EventArgs e)
        {
            n = 36;
            itemDetailsArrangement();
        }

        private void btn葡萄柚汁_Click(object sender, EventArgs e)
        {
            n = 37;
            itemDetailsArrangement();
        }

        private void btn金桔檸檬_Click(object sender, EventArgs e)
        {
            n = 38;
            itemDetailsArrangement();
        }

        private void btn檸檬梅子_Click(object sender, EventArgs e)
        {
            n = 39;
            itemDetailsArrangement();
        }

        private void btn檸檬多多_Click(object sender, EventArgs e)
        {
            n = 40;
            itemDetailsArrangement();
        }

        private void btn檸檬蜜_Click(object sender, EventArgs e)
        {
            n = 41;
            itemDetailsArrangement();
        }

        private void btn葡萄柚多多_Click(object sender, EventArgs e)
        {
            n = 42;
            itemDetailsArrangement();
        }

        private void btn金桔檸檬蜜_Click(object sender, EventArgs e)
        {
            n = 43;
            itemDetailsArrangement();
        }

        private void btn蜜茶_Click(object sender, EventArgs e)
        {
            n = 44;
            itemDetailsArrangement();
        }

        private void btn８冰茶_Click(object sender, EventArgs e)
        {
            n = 45;
            itemDetailsArrangement();
        }

        /*****item details*****/

        private void btn熱_Click(object sender, EventArgs e)
        {
            temperature("熱");
        }

        private void btn溫熱_Click(object sender, EventArgs e)
        {
            temperature("溫熱");
        }        

        private void btn溫_Click(object sender, EventArgs e)
        {
            temperature("溫");
        }

        private void btn微溫_Click(object sender, EventArgs e)
        {
            temperature("微溫"); 
        }

        private void btn常溫_Click(object sender, EventArgs e)
        {
            temperature("常溫");
        }

        private void btn少冰_Click(object sender, EventArgs e)
        {
            temperature("少冰");
        }

        private void btn微冰_Click(object sender, EventArgs e)
        {
            temperature("微冰");
        }

        private void btn碎冰_Click(object sender, EventArgs e)
        {
            temperature("碎冰");
        }

        private void btn去冰_Click(object sender, EventArgs e)
        {
            temperature("去冰");
        }

        private void btn完全去冰_Click(object sender, EventArgs e)
        {
            temperature("完全去冰");
        }

        private void btn7分糖_Click(object sender, EventArgs e)
        {
            sugar("7分糖");
        }

        private void btn5分糖_Click(object sender, EventArgs e)
        {
            sugar("5分糖");
        }

        private void btn3分糖_Click(object sender, EventArgs e)
        {
            sugar("3分糖");
        }

        private void btn1分糖_Click(object sender, EventArgs e)
        {
            sugar("1分糖");
        }

        private void btn無糖_Click(object sender, EventArgs e)
        {
            sugar("無糖");
        }

        private void btn大珍珠_Click(object sender, EventArgs e)
        {
            other("大珍珠");
        }

        private void btn小珍珠_Click(object sender, EventArgs e)
        {
            other("小珍珠");
        }

        private void btn仙草凍_Click(object sender, EventArgs e)
        {
            other("仙草凍");
        }

        private void btn椰果_Click(object sender, EventArgs e)
        {
            other("椰果");
        }

        private void btn布丁_Click(object sender, EventArgs e)
        {
            other("布丁");
        }

        /*****item setting*****/

        private void lbl數字鍵盤0_Click(object sender, EventArgs e)
        {
            numberCount += lbl數字鍵盤0.Text;
            numberChange += lbl數字鍵盤0.Text;
        }

        private void lbl數字鍵盤00_Click(object sender, EventArgs e)
        {
            numberCount += lbl數字鍵盤00.Text;
            numberChange += lbl數字鍵盤00.Text;
        }

        private void lbl數字鍵盤000_Click(object sender, EventArgs e)
        {
            numberCount += lbl數字鍵盤000.Text;
            numberChange += lbl數字鍵盤000.Text;
        }

        private void lbl數字鍵盤1_Click(object sender, EventArgs e)
        {
            numberCount += lbl數字鍵盤1.Text;
            numberChange += lbl數字鍵盤1.Text;
        }

        private void lbl數字鍵盤2_Click(object sender, EventArgs e)
        {
            numberCount += lbl數字鍵盤2.Text;
            numberChange += lbl數字鍵盤2.Text;
        }

        private void lbl數字鍵盤3_Click(object sender, EventArgs e)
        {
            numberCount += lbl數字鍵盤3.Text;
            numberChange += lbl數字鍵盤3.Text;
        }

        private void lbl數字鍵盤4_Click(object sender, EventArgs e)
        {
            numberCount += lbl數字鍵盤4.Text;
            numberChange += lbl數字鍵盤4.Text;
        }

        private void lbl數字鍵盤5_Click(object sender, EventArgs e)
        {
            numberCount += lbl數字鍵盤5.Text;
            numberChange += lbl數字鍵盤5.Text;
        }

        private void lbl數字鍵盤6_Click(object sender, EventArgs e)
        {
            numberCount += lbl數字鍵盤6.Text;
            numberChange += lbl數字鍵盤6.Text;
        }

        private void lbl數字鍵盤7_Click(object sender, EventArgs e)
        {
            numberCount += lbl數字鍵盤7.Text;
            numberChange += lbl數字鍵盤7.Text;
        }

        private void lbl數字鍵盤8_Click(object sender, EventArgs e)
        {
            numberCount += lbl數字鍵盤8.Text;
            numberChange += lbl數字鍵盤8.Text;
        }

        private void lbl數字鍵盤9_Click(object sender, EventArgs e)
        {           
            numberCount += lbl數字鍵盤9.Text;
            numberChange += lbl數字鍵盤9.Text;
        }

        private void lbl贈送_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            { }
            else
            {
                Beverage beverage = listBox1.SelectedItem as Beverage;
                totalPrice -= beverage.price;
                beverage.price = 0;
                refreshMenu();

                lblMenuStatus總金額.Text = "總金額: " + totalPrice.ToString();
            }
        }

        private void lblX數字_Click(object sender, EventArgs e)
        {
            if (numberCount == "")
            { }
            else
            {
                itemCount = Convert.ToInt32(numberCount);
                numberCount = "";
            }
        }

        private void lbl小計_Click(object sender, EventArgs e)
        {
            string menuPrice = "\t\t\t\t\t*小計: NTD" + totalPrice.ToString();
            listBox1.Items.Add("");
            listBox1.Items.Add(menuPrice);
        }

        private void lbl取消交易_Click(object sender, EventArgs e)
        {
            listBeverages.Clear();

            refreshMenu();

            totalCount = 0;
            totalPrice = 0;
            itemCount = 1;
            lblMenuStatus杯數.Text = "杯數: " + totalCount.ToString();
            lblMenuStatus總金額.Text = "總金額: " + totalPrice.ToString();
        }

        private void lbl刪除單品_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            { }
            else
            {
                Beverage beverage = listBox1.SelectedItem as Beverage;
                totalCount -= beverage.count;
                totalPrice -= beverage.price;

                for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    listBeverages.RemoveAt(listBox1.SelectedIndices[i]);
                }

                refreshMenu();

                lblMenuStatus杯數.Text = "杯數: " + totalCount.ToString();
                lblMenuStatus總金額.Text = "總金額: " + totalPrice.ToString();
            }
        }

        private void lbl清除金額_Click(object sender, EventArgs e)
        {
            numberChange = "";
        }

        private void lbl結帳_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0 || numberChange == "")
            { }
            else
            {
                itemChange = Convert.ToInt32(numberChange);
                int moneychange = itemChange - totalPrice;

                if (moneychange < 0)
                {
                    MessageBox.Show("實收金額不足總金額之數目", "無法結帳", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    string menuPay = "\t\t\t\t\t*實收: NTD" + itemChange.ToString();
                    string menuChange = "\t\t\t\t\t*找零: NTD" + moneychange.ToString();
                    listBox1.Items.Add("");
                    listBox1.Items.Add(menuPay);
                    listBox1.Items.Add(menuChange);                                       

                    DialogResult drResult;
                    drResult = MessageBox.Show("訂單已完成 !", "完成",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (drResult == DialogResult.OK)
                    {
                        writexlsx();
                        listBeverages.Clear();                        
                        refreshMenu();
                    }

                    menuNo += 1;
                    lblMenuStatus單號.Text = "單號: " + menuNo.ToString();
                                        
                    itemCount = 1;
                    totalCount = 0;
                    totalPrice = 0;
                    numberCount = "";
                    lblMenuStatus杯數.Text = "杯數: 0";
                    lblMenuStatus總金額.Text = "總金額: 0";
                }

                numberChange = "";
            }            
            
        }
        /*****method*****/

        private void itemDetailsArrangement()
        {
            if (beverages.moveTo(n).name.Length < 5)
            {
                beverages.addChar();
            }

            listBeverages.Add(new Beverage()
            {
                name = beverages.moveTo(n).name,                
                count = itemCount,
                unitPrice = beverages.moveTo(n).unitPrice,
                price = itemCount * beverages.moveTo(n).unitPrice
            });

            totalCount += itemCount;
            totalPrice += itemCount * beverages.moveTo(n).unitPrice;
            lblMenuStatus杯數.Text = "杯數: " + totalCount.ToString();
            lblMenuStatus總金額.Text = "總金額: " + totalPrice.ToString();

            refreshMenu();

            numberCount = "";
            numberChange = "";
            itemCount = 1;
        }

        private void refreshMenu()
        {
            listBox1.Items.Clear();
            foreach (Beverage b in listBeverages)
            {
                listBox1.Items.Add(b);
            }
        }

        private void temperature(string noteTemperature)
        {
            if (listBox1.SelectedItem == null)
            { }
            else
            {
                Beverage beverage = listBox1.SelectedItem as Beverage;
                beverage.noteT = noteTemperature;

                refreshMenu();
            }
        }

        private void sugar(string noteSugar)
        {
            if (listBox1.SelectedItem == null)
            { }
            else
            {
                Beverage beverage = listBox1.SelectedItem as Beverage;
                beverage.noteS = noteSugar;

                refreshMenu();
            }
        }

        private void other(string noteOther)
        {
            if (listBox1.SelectedItem == null)
            { }
            else
            {
                Beverage beverage = listBox1.SelectedItem as Beverage;

                if (beverage.noteO != null)
                { }
                else
                {
                    beverage.noteO = noteOther;
                    beverage.price += beverage.count * 10;

                    totalPrice += beverage.count * 10;
                }
                refreshMenu();

                lblMenuStatus總金額.Text = "總金額: " + totalPrice.ToString();
            }
        }

        public void frmclose()
        {
            boolCancel = false;
            return;
        }

        public void writexlsx()
        {
            StringBuilder sb = new StringBuilder();
            string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
            sb.Append("單號: " + menuNo + "\t\t\t\t\t" + reportDate + "     " + TimeNow + "\r\n");
            sb.Append("品名\t\t");
            sb.Append("杯數\t");
            sb.Append("單價\t");
            sb.Append("溫度\t");
            sb.Append("甜度\t");
            sb.Append("加料\t");
            sb.Append("總價\r\n\n");

            foreach (Beverage b in listBeverages)
            {
                sb.Append(b.name + "\t\t");
                sb.Append(b.count.ToString() + "\t");
                sb.Append(b.unitPrice.ToString() + "\t");
                sb.Append(b.noteT + "\t");
                sb.Append(b.noteS + "\t");
                sb.Append(b.noteO + "\t");
                sb.Append(b.price.ToString() + "\r\n");
            }

            sb.Append("\t\t\t\t\t");
            sb.Append("杯數: " + totalCount.ToString() + "\t" + "總金額: " + totalPrice.ToString() + "\r\n\n");
            
            StreamWriter writer = new StreamWriter(reportDate+".xls", true, Encoding.Default);
            writer.Write(sb.ToString());
            writer.Close();            
        }
    }
}
