using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TreeNode root = TvFolder.Nodes.Add("내컴퓨터");

            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                TreeNode node = root.Nodes.Add(drive);
                node.Nodes.Add("...");
            }
        }

        private void TvFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode current = e.Node;
            string path = current.FullPath.Replace("\\\\", "\\");
            TxtPath.Text = path.Substring(path.IndexOf("\\") + 1);

            try
            {
                LvFiles.Items.Clear();
                string[] directories = Directory.GetDirectories(TxtPath.Text);
                foreach (string directory in directories)
                {
                    DirectoryInfo info = new DirectoryInfo(directory);
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        info.Name, "", "파일폴더", info.LastWriteTime.ToString() 
                    });
                    LvFiles.Items.Add(item);
                }
                string[] files = Directory.GetFiles(TxtPath.Text);
                foreach (string file in files)
                {
                    FileInfo info = new FileInfo(file);
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        info.Name, info.Length.ToString(), info.Extension, info.LastWriteTime.ToString()
                    });
                    LvFiles.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace.Substring(ex.StackTrace.LastIndexOf("\\") + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TvFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode current = e.Node;
            if (current.Nodes.Count == 1 && current.Nodes[0].Text.Equals("..."))
            {
                current.Nodes.Clear();
                string path = current.FullPath.Substring(current.FullPath.IndexOf("\\") + 1);

                try
                {
                    string[] dir = Directory.GetDirectories(path);
                    foreach (string item in dir)
                    {
                        TreeNode newNode = current.Nodes.Add(item.Substring(item.LastIndexOf("\\") + 1));
                        newNode.Nodes.Add("...");
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
