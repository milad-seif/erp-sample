using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.part' table. You can move, or remove it, as needed.
            this.partTableAdapter.Fill(this.dataSet2.part);
            this.bomTableAdapter.Fill(this.dataSet2.bom);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //DataSet2.bomRow
            //dataSet2.bom
            //dataSet2.bom.
            var strExpr = "PARENT_NAME = ''";
            var result = dataSet2.bom.Select(strExpr);
            var parent = result[0]["COMPONENT_NAME"].ToString();
            TreeNode node = new TreeNode(parent);
            node = tree_builder(parent, node);
            treeView.Nodes.Add(node);
            // foreach (DataRow row in dataSet2.bom.Rows)
            //{
            //    TreeNode node = new TreeNode(row["COMPONENT_NAME"].ToString());
            //    treeView1.Nodes.Add(node);
            //}
            populateButton.Enabled = false;
        }
        private TreeNode tree_builder(String parent, TreeNode tree)
        {
            var strExpr = "PARENT_NAME = '" + parent + "'";
            var results = dataSet2.bom.Select(strExpr);
            foreach (DataRow result in results)
            {
                var parentName = result["COMPONENT_NAME"].ToString();
                TreeNode node = new TreeNode(parentName);
                node = tree_builder(parentName, node);
                tree.Nodes.Add(node);
            }
            return tree;
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //var strExpr = ""
            //var results = dataSet2.part.Join(dataSet2.bom, "NAME", "COMPONENT_NAME", ;
            var filter = e.Node.Text;
            currentLabel.Text = filter;
            var parent = dataSet2.bom.Select("COMPONENT_NAME = '" + filter + "'");
            if (parent.Length > 0)
                parentChildLabel.Text = parent[0]["PARENT_NAME"].ToString() + "\\" + filter;
            else
                parentChildLabel.Text = filter;
            var results = from b in dataSet2.bom
                          join p in dataSet2.part
                          on b.COMPONENT_NAME equals p.NAME
                          where b.PARENT_NAME == filter
                          select new
                          {
                              b.PARENT_NAME,
                              b.COMPONENT_NAME,
                              p.PART_NUMBER,
                              p.TITLE,
                              b.QUANTITY,
                              p.TYPE,
                              p.ITEM,
                              p.MATERIAL
                          };
            partView.DataSource = results.ToList();
        }
    }
}
