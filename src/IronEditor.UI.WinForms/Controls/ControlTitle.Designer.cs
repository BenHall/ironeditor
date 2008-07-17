namespace IronEditor.UI.WinForms.Controls
{
    partial class ControlTitle
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
            this.titleBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar.MinimumSize = new System.Drawing.Size(0, 21);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(150, 21);
            this.titleBar.TabIndex = 1;
            this.titleBar.Text = "Control Title";
            this.titleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ControlTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.titleBar);
            this.MinimumSize = new System.Drawing.Size(0, 21);
            this.Name = "ControlTitle";
            this.Size = new System.Drawing.Size(150, 21);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleBar;
    }
}
