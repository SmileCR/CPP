using System;
using System.IO;
using System.Windows.Forms;

namespace AnimalTree
{
    public partial class MainForm : Form
    {
        private const string DataFileName = "data.txt"; // ім'я файлу з даними
        private TreeNode root; // корінь дерева

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
            PopulateTree();
        }

        private void LoadData()
        {
            if (!File.Exists(DataFileName)) return;

            var lines = File.ReadAllLines(DataFileName);
            root = new TreeNode("Animals");

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length != 2) continue;

                var family = parts[0].Trim();
                var species = parts[1].Trim();

                var familyNode = FindOrCreateNode(root, family);
                familyNode.Nodes.Add(species);
            }
        }

        private void PopulateTree()
        {
            treeView.Nodes.Clear();
            treeView.Nodes.Add(root);
            treeView.ExpandAll();
        }

        private TreeNode FindOrCreateNode(TreeNode parent, string text)
        {
            foreach (TreeNode node in parent.Nodes)
            {
                if (node.Text == text)
                {
                    return node;
                }
            }

            var newNode = new TreeNode(text);
            parent.Nodes.Add(newNode);

            return newNode;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var text = txtNodeText.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter a node text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedNode = treeView.SelectedNode;
            if (selectedNode == null)
            {
                root.Nodes.Add(text);
            }
            else
            {
                selectedNode.Nodes.Add(text);
                selectedNode.Expand();
            }

            txtNodeText.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("Please select a node to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedNode.Parent == null)
            {
                MessageBox.Show("Cannot remove the root node.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedNode.Remove();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            using (var writer = new StreamWriter(DataFileName))
            {
                SaveNode(writer, root);
            }
        }

        private void SaveNode(StreamWriter writer, TreeNode node)
        {
            if (node == null) return;

            if (node.Parent == null)
            {
                writer.WriteLine(node.Text);
            }
            else
            {
                writer.WriteLine("{0}, {1}", node.Parent.Text, node.Text);
            }

            foreach (TreeNode childNode in node.Nodes)
            {
                SaveNode(writer, childNode);
            }
        }
    }
}
