using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ex1
{
    public partial class FrmGrid : ex1.Form1, IUiListener
    {
        public FrmGrid()
        {
            InitializeComponent();
        }

        private void FrmGrid_Load(object sender, EventArgs e)
        { 
            dataGridView1.DataSource = base.factory.getAll();
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[0].Width = 120;                              
        }        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPhone.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                txtAddrs.Text = row.Cells[4].Value.ToString();
            }*/
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            base.moveTo(e.RowIndex);
        }

        private void FrmGrid_Paint(object sender, PaintEventArgs e)
        {
            bool blnColorChange = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                blnColorChange = !blnColorChange;
                if (blnColorChange)
                {
                    r.DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else
                {
                    r.DefaultCellStyle.BackColor = Color.SlateGray;
                }
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
            }
        }
    }
}
