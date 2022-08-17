using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            //treeView1.CollapseAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Add(new TreeNode(textBox1.Text, 2, 2));
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("노드추가할 이름을 넣고, 추가할 위치의 폴더를 선택하세요.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                treeView1.Nodes.Add(new TreeNode(textBox1.Text, 0, 1));
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("노드추가할 이름 입력");
            }
        }
    }
}
