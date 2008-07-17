namespace IronEditor.UI.WinForms.Controls
{
    partial class ProjectTree
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.projectList = new System.Windows.Forms.TreeView();
            this.fileOptions = new System.Windows.Forms.Panel();
            this.controlTitle1 = new IronEditor.UI.WinForms.Controls.ControlTitle();
            this.properties = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.newFile = new System.Windows.Forms.Button();
            this.fileOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectList
            // 
            this.projectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectList.Indent = 16;
            this.projectList.Location = new System.Drawing.Point(0, 21);
            this.projectList.Name = "projectList";
            this.projectList.ShowNodeToolTips = true;
            this.projectList.Size = new System.Drawing.Size(301, 572);
            this.projectList.TabIndex = 0;
            this.projectList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.projectList_NodeMouseDoubleClick);
            this.projectList.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.projectList_BeforeExpand);
            this.projectList.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.projectList_BeforeCollapse);
            // 
            // fileOptions
            // 
            this.fileOptions.AutoSize = true;
            this.fileOptions.Controls.Add(this.properties);
            this.fileOptions.Controls.Add(this.delete);
            this.fileOptions.Controls.Add(this.newFile);
            this.fileOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fileOptions.Location = new System.Drawing.Point(0, 570);
            this.fileOptions.Margin = new System.Windows.Forms.Padding(0);
            this.fileOptions.Name = "fileOptions";
            this.fileOptions.Size = new System.Drawing.Size(301, 23);
            this.fileOptions.TabIndex = 2;
            // 
            // controlTitle1
            // 
            this.controlTitle1.AutoSize = true;
            this.controlTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlTitle1.Location = new System.Drawing.Point(0, 0);
            this.controlTitle1.MinimumSize = new System.Drawing.Size(0, 21);
            this.controlTitle1.Name = "controlTitle1";
            this.controlTitle1.Size = new System.Drawing.Size(301, 21);
            this.controlTitle1.TabIndex = 3;
            this.controlTitle1.Title = "Directory Listing";
            // 
            // properties
            // 
            this.properties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.properties.Image = global::IronEditor.UI.WinForms.Properties.Resources.PropertiesHS;
            this.properties.Location = new System.Drawing.Point(27, 1);
            this.properties.Margin = new System.Windows.Forms.Padding(0);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(24, 23);
            this.properties.TabIndex = 2;
            this.properties.UseVisualStyleBackColor = true;
            this.properties.Click += new System.EventHandler(this.properties_Click);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Image = global::IronEditor.UI.WinForms.Properties.Resources.DeleteHS;
            this.delete.Location = new System.Drawing.Point(280, 1);
            this.delete.Margin = new System.Windows.Forms.Padding(0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(21, 22);
            this.delete.TabIndex = 1;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // newFile
            // 
            this.newFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newFile.Image = global::IronEditor.UI.WinForms.Properties.Resources.NewDocumentHS;
            this.newFile.Location = new System.Drawing.Point(0, 0);
            this.newFile.Margin = new System.Windows.Forms.Padding(0);
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(27, 24);
            this.newFile.TabIndex = 0;
            this.newFile.UseVisualStyleBackColor = true;
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // ProjectTree
            // 
            this.Controls.Add(this.fileOptions);
            this.Controls.Add(this.projectList);
            this.Controls.Add(this.controlTitle1);
            this.Name = "ProjectTree";
            this.Size = new System.Drawing.Size(301, 593);
            this.fileOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView projectList;
        private System.Windows.Forms.Panel fileOptions;
        private System.Windows.Forms.Button properties;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button newFile;
        private ControlTitle controlTitle1;
    }
}
