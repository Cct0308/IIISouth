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
    public partial class FrmTree : Form1, IUiListener
    {
        public FrmTree()
        {
            InitializeComponent();
        }

        private void FrmTree_Load(object sender, EventArgs e)
        {
            CCustomer[] customers = base.factory.getAll();
            Dictionary<string, TreeNode> table = getGroupBy地址(customers);
            foreach (TreeNode t in table.Values)
            {
                treeView1.Nodes.Add(t);
            }
        }

        private Dictionary<string, TreeNode> getGroupBy地址(CCustomer[] customers)
        {
            Dictionary<string, TreeNode> table = new Dictionary<string, TreeNode>();
            foreach (CCustomer c in customers)
            {
                TreeNode node地址;
                TreeNode node客戶;
                if (table.ContainsKey(c.addrs))
                {
                    node地址 = table[c.addrs];
                }
                else
                {
                    node地址 = new TreeNode(c.addrs);
                    table[c.addrs] = node地址;
                }
                node客戶 = new TreeNode(c.name);
                node客戶.Tag = c;
                node地址.Nodes.Add(node客戶);
            }
            return table;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag != null)
            {
                CCustomer customer = treeView1.SelectedNode.Tag as CCustomer;
                base.findById(customer.id.ToString());
            }
        }
    }
}
