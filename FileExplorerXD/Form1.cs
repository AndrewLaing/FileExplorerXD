using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace FileExplorerXD
{
    /* DriveType Enum values used as Indexes for drive icons in imageList1
     * -----------------------------------------------------------------------------------------
     * Unknown          - 0 - The type of drive is unknown. 
     * NoRootDirectory  - 1 - The drive does not have a root directory.
     * Removable        - 2 - The drive is a removable storage device, such as a USB flash drive.
     * Fixed            - 3 - The drive is a fixed disk.
     * Network          - 4 - The drive is a network drive.
     * CDRom            - 5 - The drive is an optical disc device, such as a CD or DVD-ROM.
     * Ram              - 6 - The drive is a RAM disk.
    */


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStartDirectory();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            dirsTreeView.Focus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateInitialTreeViewStructure();
        }

        private void SetStartDirectory()
        {
            string start_directory = Environment.ExpandEnvironmentVariables("%USERPROFILE%");
            start_directory = start_directory.Replace(@"\", "/");
            webBrowser1.Navigate(start_directory);
            path_textBox.Text = start_directory;
        }


        #region "TreeView"

        private void CreateInitialTreeViewStructure()
        {
            dirsTreeView.ImageList = imageList1; // drive icons
            string[] drive_list = Environment.GetLogicalDrives();

            foreach (string drive in drive_list)
            {
                DriveInfo di = new DriveInfo(drive);

                // TEXT, ImageIDX, selectedImageIDX
                TreeNode node = new TreeNode(drive,
                                             (int)di.DriveType,
                                             (int)di.DriveType);
                node.Tag = drive;

                if (di.IsReady == true)
                {
                    node.Nodes.Add("...");
                }

                dirsTreeView.Nodes.Add(node);
            }
            dirsTreeView.Update();
            updateTreeViewWithSelection();
        }

        private void AddChildNodesToTreeNode(TreeNode tn)
        {
            if (tn.Nodes.Count <= 0) return;

            if (tn.Nodes[0].Text == "..." && tn.Nodes[0].Tag == null)
            {
                tn.Nodes.Clear();

                string[] subdirs = Directory.GetDirectories(tn.Tag.ToString());

                foreach (string dir in subdirs)
                {
                    DirectoryInfo di = new DirectoryInfo(dir);
                    TreeNode node = new TreeNode(di.Name,
                                                (int)DriveType.Unknown,
                                                (int)DriveType.NoRootDirectory);

                    try
                    {
                        node.Tag = dir;
                        if (di.GetDirectories().Count() > 0)
                        {
                            node.Nodes.Add(null, "...",
                                                (int)DriveType.Unknown,
                                                (int)DriveType.NoRootDirectory);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        node.ImageIndex = 7;          //display a locked folder icon
                        node.SelectedImageIndex = 7;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "FileExplorerXD",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        tn.Nodes.Add(node);
                    }
                }
            }
        }

        private void updateTreeViewWithSelection()
        {
            if (dirsTreeView.Nodes.Count <= 0) return;

            TreeNodeCollection nodes = null;
            TreeNode tn = null;
            TreeNode found = null;

            string dir;
            string path = DecodeUrl(webBrowser1.Url.AbsolutePath);
            string[] parts = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            dirsTreeView.CollapseAll();
            nodes = dirsTreeView.Nodes;
            dir = parts[0];

            if (dir[dir.Length - 1] == ':')
            {
                dir += '\\';   // Drive nodes are named 'C:\' etc
            }

            // Find the drive node
            for (int j = 0; j < nodes.Count; j++)
            {
                tn = nodes[j];
                if (tn.Text == dir)
                {
                    found = tn;
                    break;
                }
            }

            AddChildNodesToTreeNode(found);

            for (int i = 1; i < parts.Length; i++)
            {
                dir = parts[i];

                for (int j = 0; j < found.Nodes.Count; j++)
                {
                    tn = found.Nodes[j];

                    if (tn.Text == dir)
                    {
                        found = tn;
                        AddChildNodesToTreeNode(found);
                        break;
                    }
                }
            }

            dirsTreeView.SelectedNode = found;
            dirsTreeView.SelectedNode.Expand();
            dirsTreeView.SelectedNode.EnsureVisible();
            dirsTreeView.Focus(); // focus to highlight selected node
        }

        private void dirsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Collapse Other Nodes of TreeView on Selection of a Node
            if (e.Node.Parent != null)
            {
                foreach (TreeNode node in e.Node.Parent.Nodes)
                {
                    if (node != e.Node)
                        node.Collapse();
                }
            }
        }

        private void dirsTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            AddChildNodesToTreeNode(e.Node);
        }

        private void dirsTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                dirsTreeView.SelectedNode = e.Node;
                path_textBox.Text = dirsTreeView.SelectedNode.FullPath.ToString();
                path_textBox.Text = path_textBox.Text.Replace(@"\\", @"\");
                webBrowser1.Url = new Uri(path_textBox.Text);
            }
            catch (UnauthorizedAccessException)
            {
                dirsTreeView.SelectedNode.ImageIndex = 7;    //display a locked folder icon
                dirsTreeView.SelectedNode.SelectedImageIndex = 7;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FileExplorerXD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "WebBrowserView"

        private void back_button_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
            dirsTreeView.Focus();
        }

        private void forward_button_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
            dirsTreeView.Focus();
        }

        private void up_button_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(path_textBox.Text);

            if (di.Parent != null)
            {
                string parent = di.Parent.FullName;
                webBrowser1.Url = new Uri(parent);
            }
            dirsTreeView.Focus();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            dirsTreeView.Focus();
        }

        private void path_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string path = path_textBox.Text;

                if (Directory.Exists(path))
                {
                    if (path[path.Length - 1] == ':')
                    {
                        path += '/'; // C: can exist but not as a valid Uri
                    }
                    webBrowser1.Url = new Uri(path);
                }
                else
                {
                    // this allows %temp% etc
                    string urlToNavigate = Environment.ExpandEnvironmentVariables(path);
                    if (Directory.Exists(urlToNavigate))
                    {
                        webBrowser1.Url = new Uri(urlToNavigate);
                        path_textBox.Text = urlToNavigate;
                    }
                    else
                    {
                        string message = "Can't find '" + path + "' check the path and try again";
                        MessageBox.Show(message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Now suppress the 'ding' sound
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            path_textBox.Text = DecodeUrl(webBrowser1.Url.AbsolutePath);
            updateTreeViewWithSelection();
            updateItemCountStatusLabel();
        }

        private string DecodeUrl(string url)
        {
            string decoded_Url;

            while ((decoded_Url = Uri.UnescapeDataString(url)) != url)
            {
                url = decoded_Url;
            }

            return decoded_Url;
        }


        private void updateItemCountStatusLabel()
        {
            string path = DecodeUrl(webBrowser1.Url.AbsolutePath);

            var directoryInfo = new System.IO.DirectoryInfo(path);
            try
            {
                int item_count = directoryInfo.GetDirectories().Length + directoryInfo.GetFiles().Length;

                if (item_count == 1)
                {
                    itemCountStatusLabel.Text = item_count + " item";
                }
                else
                {
                    itemCountStatusLabel.Text = item_count + " items";
                }
            }
            catch (UnauthorizedAccessException)
            {
                dirsTreeView.SelectedNode.ImageIndex = 7;    //display a locked folder icon
                dirsTreeView.SelectedNode.SelectedImageIndex = 7;
            }
        }


        #endregion

        // ///////////////////////////////////////////////////////////////////////////////
        // //////////// IN PROGRESS //////////////////////////////////////////////////////
        // ///////////////////////////////////////////////////////////////////////////////


    }
}
