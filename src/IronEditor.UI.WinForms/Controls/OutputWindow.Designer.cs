namespace IronEditor.UI.WinForms.Controls
{
    partial class OutputWindow
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
            this.output = new System.Windows.Forms.TextBox();
            this.controlTitle = new IronEditor.UI.WinForms.Controls.ControlTitle();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.WindowText;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Cursor = System.Windows.Forms.Cursors.Default;
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.ForeColor = System.Drawing.SystemColors.Window;
            this.output.Location = new System.Drawing.Point(0, 21);
            this.output.Margin = new System.Windows.Forms.Padding(0);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(300, 279);
            this.output.TabIndex = 1;
            // 
            // controlTitle
            // 
            this.controlTitle.AutoSize = true;
            this.controlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlTitle.Location = new System.Drawing.Point(0, 0);
            this.controlTitle.MinimumSize = new System.Drawing.Size(0, 21);
            this.controlTitle.Name = "controlTitle";
            this.controlTitle.Size = new System.Drawing.Size(300, 21);
            this.controlTitle.TabIndex = 2;
            this.controlTitle.Title = "Output Window";
            // 
            // OutputWindow
            // 
            this.Controls.Add(this.output);
            this.Controls.Add(this.controlTitle);
            this.Name = "OutputWindow";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private ControlTitle controlTitle;

    }
}
