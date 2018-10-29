using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FSPM
{
    public partial class window_Main : Form
    {
        private Boolean KeyDown_textBox_name = false;
        public window_Main()
        {
            InitializeComponent();
            treeView.Nodes.Add(new Node());
        }

        private void ContextMenuItem_AddDirectory_Click(object sender, EventArgs e)
        {
            treeView.SelectedNode.Nodes.Add(new Node(NodeType.Directory));
            treeView.SelectedNode.Expand();
        }

        private void ContextMenuItem_AddMultiDirectory_Click(object sender, EventArgs e)
        {
            Node n = new Node(NodeType.MultiDirectory);
            treeView.SelectedNode.Nodes.Add(new Node(NodeType.MultiDirectory));
            treeView.SelectedNode.Expand();
        }

        private void ContextMenuItem_AddServer_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Add(new Node());
        }

        private void ContextMenuItem_AddShare_Click(object sender, EventArgs e)
        {
            treeView.SelectedNode.Nodes.Add(new Node(NodeType.Share));
            treeView.SelectedNode.Expand();
        }

        private void ContextMenuItem_ConvertDirectory_Click(object sender, EventArgs e)
        {
            ((Node) treeView.SelectedNode).Type = NodeType.MultiDirectory;
            if (treeView.SelectedNode.Text == "Directory")
            {
                treeView.SelectedNode.Text = "MultiDirectory";
            }
            TreeView_AfterSelect(null, null);
        }

        private void ContextMenuItem_ConvertMultiDirectory_Click(object sender, EventArgs e)
        {
            ((Node)treeView.SelectedNode).Type = NodeType.Directory;
            if (treeView.SelectedNode.Text == "MultiDirectory")
            {
                treeView.SelectedNode.Text = "Directory";
            }
            TreeView_AfterSelect(null, null);
        }

        private void ContextMenuItem_Delete_Click(object sender, EventArgs e)
        {
            Node selected = (Node)treeView.SelectedNode;
            DialogResult result = MessageBox.Show(
                    String.Format("Are you sure you want to delete {0}:'{1}'?", selected.Type, selected.Text),
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                treeView.SelectedNode.Remove();
            }
        }

        private void ContextMenuItem_Rename_Click(object sender, EventArgs e)
        {
            textBox_Name.Focus();
        }

        private void MenuItem_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by github.com/WaywardScripts\nCome check me out ;)","About FSPM...",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void MenuItem_ImportPermissions_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItem_LoadProfile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItem_SaveProfile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItem_SaveProfileAs_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBox_Name_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.KeyDown_textBox_name && e.KeyCode == Keys.Enter)
            {
                treeView.Focus();
            } else {
                treeView.SelectedNode.Text = textBox_Name.Text;
            }
            this.KeyDown_textBox_name = false;
        }

        private void TextBox_RegexPattern_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_RegexPattern.Text))
            {
                label_RegexState.Text = "Valid";
                label_RegexState.ForeColor = Color.Black;
            }
            else
            {
                try
                {
                    Regex.Match("", textBox_RegexPattern.Text);
                    label_RegexState.Text = "Valid";
                    label_RegexState.ForeColor = Color.Black;
                    ((Node) treeView.SelectedNode).Filter = textBox_RegexPattern.Text;
                }
                catch (ArgumentException)
                {
                    label_RegexState.Text = "Invalid";
                    label_RegexState.ForeColor = Color.Red;
                }
            }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox_Name.Text = treeView.SelectedNode.Text;
            if (((Node)treeView.SelectedNode).Type == NodeType.MultiDirectory)
            {
                textBox_RegexPattern.Enabled = true;
                textBox_RegexPattern.Text = ((Node)treeView.SelectedNode).Filter;
            }
            else
            {
                textBox_RegexPattern.Enabled = false;
                textBox_RegexPattern.Text = "";
            }
        }

        private void TreeView_MouseUp(object sender, MouseEventArgs e)
        {
            treeView.SelectedNode = treeView.GetNodeAt(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    switch (((Node)treeView.SelectedNode).Type)
                    {
                        case NodeType.Server:
                            contextMenu_Server.Show(Cursor.Position);
                            break;
                        case NodeType.Share:
                            contextMenu_Share.Show(Cursor.Position);
                            break;
                        case NodeType.Directory:
                            contextMenu_Directory.Show(Cursor.Position);
                            break;
                        case NodeType.MultiDirectory:
                            contextMenu_MultiDirectory.Show(Cursor.Position);
                            break;
                    }
                } catch (NullReferenceException c)
                {
                    contextMenu_Root.Show(Cursor.Position);
                }
            }
        }

        private void TreeView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Apps)
            {
                try
                {
                    Point p = treeView.PointToScreen(new Point(treeView.SelectedNode.Bounds.Left,treeView.SelectedNode.Bounds.Bottom));
                    switch (((Node)treeView.SelectedNode).Type)
                    {
                        case NodeType.Server:
                            contextMenu_Server.Show(p);
                            break;
                        case NodeType.Share:
                            contextMenu_Share.Show(p);
                            break;
                        case NodeType.Directory:
                            contextMenu_Directory.Show(p);
                            break;
                        case NodeType.MultiDirectory:
                            contextMenu_MultiDirectory.Show(p);
                            break;
                    }
                }
                catch (NullReferenceException c)
                {
                    contextMenu_Root.Show(treeView.Bounds.Location);
                }
            }
        }

        private void textBox_Name_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyDown_textBox_name = true;
        }
    }

    public enum NodeType
    {
        Server         = 0,
        Share          = 1,
        Directory      = 2,
        MultiDirectory = 3
    }

    public class Node : TreeNode
    {
        public NodeType Type;
        public string Filter;
        public Node() {
            this.Text = "Server Name";
        }
        public Node(NodeType type) {
            this.Type = type;
            this.Text = type.ToString();
        }
    }
}
