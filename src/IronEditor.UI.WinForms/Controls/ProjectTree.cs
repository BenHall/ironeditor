using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using IronEditor.Engine;
using IronEditor.UI.WinForms.Dialogs;

namespace IronEditor.UI.WinForms.Controls
{
    public partial class ProjectTree : UserControl
    {
        public delegate void OpenFileEventHandler(object sender, OpenFileEventArgs e);
        public event OpenFileEventHandler OpenFileRequest;   

        public ProjectTree()
        {
            InitializeComponent();
            ImageList list = new ImageList();
            list.Images.Add(GetImageFromEmbeddedResource("IronEditor.UI.WinForms.Resources.Folder_Closed.png"));
            list.Images.Add(GetImageFromEmbeddedResource("IronEditor.UI.WinForms.Resources.Folder_Open.png"));
            list.Images.Add(GetImageFromEmbeddedResource("IronEditor.UI.WinForms.Resources.Generic_Document.png"));

            projectList.ImageList = list;
        }

        public Image GetImageFromEmbeddedResource(string path)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path);
            return Image.FromStream(stream);
        }

        public void PopulateDirectoryTree(string projectPath)
        {
            DirectoryTreePopulator projectPathPopulator = new DirectoryTreePopulator();
            DirectoryTree root = projectPathPopulator.GetTree(projectPath);
            CreateTreeView(root);
        }

        private void CreateTreeView(DirectoryTree rootNode)
        {
            TreeNode root = CreateNode(rootNode);

            foreach (DirectoryTree directory in rootNode.Directories)
            {
                TreeNode node = CreateNode(directory);
                foreach (FileLeaf file in directory.Files)
                {
                    TreeNode leaf = CreateNode(file);

                    node.Nodes.Add(leaf);
                }

                root.Nodes.Add(node);
            }

            foreach (FileLeaf file in rootNode.Files)
            {
                TreeNode leaf = CreateNode(file);

                root.Nodes.Add(leaf);
            }

            projectList.Nodes.Add(root);
        }

        private TreeNode CreateNode(DirectoryTree directory)
        {
            TreeNode node = new TreeNode(directory.Name);
            node.ImageIndex = node.SelectedImageIndex = 0;
            node.ToolTipText = directory.Location;
            node.Tag = new ActiveCodeFile(directory.Location);
            return node;
        }

        private TreeNode CreateNode(FileLeaf file)
        {
            TreeNode node = new TreeNode(file.Name);
            node.Tag = new ActiveCodeFile(file.Location);
            node.ImageIndex = node.SelectedImageIndex = 2;
            node.ToolTipText = file.Location;
            return node;
        }

        private void projectList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count != 0)
                return;

            OnOpenFileRequest(e.Node.Tag as ActiveCodeFile);
        }

        private void OnOpenFileRequest(ActiveCodeFile file)
        {
            if(OpenFileRequest != null)
            {
                OpenFileEventArgs e = new OpenFileEventArgs();
                e.File = file;
                OpenFileRequest(this, e);
            }
        }

        private void projectList_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
            e.Node.SelectedImageIndex = e.Node.ImageIndex;
        }

        private void projectList_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 1;
            e.Node.SelectedImageIndex = e.Node.ImageIndex;
        }

        public void Clear()
        {
            projectList.Nodes.Clear();
        }

        private void newFile_Click(object sender, System.EventArgs e)
        {
            NewFileDialog newFileDialog = new NewFileDialog();
            if(newFileDialog.ShowDialog() == DialogResult.OK)
            {
                
            }

        }

        private void properties_Click(object sender, System.EventArgs e)
        {

        }

        private void delete_Click(object sender, System.EventArgs e)
        {

        }
    }
}
