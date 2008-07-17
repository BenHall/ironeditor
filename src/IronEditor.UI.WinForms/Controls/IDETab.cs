using System.Windows.Forms;
using IronEditor.Engine;

namespace IronEditor.UI.WinForms.Controls
{
    public class IDETab : TabPage
    {
        public IDEInput Input { get; set; }
        public ActiveCodeFile ActiveFile { get; set; }

        public IDETab(ActiveCodeFile file) : this()
        {
            UpdateFileName(file);
            ActiveFile = file;
        }

        internal void UpdateFileName(ActiveCodeFile file)
        {
            Text = file.FileName;
        }

        public IDETab()
        {
            Text = "NewFile";
            IIDETextBox textBox;
            
            if (MonoEnvironment.IsRunningOnMono())
                textBox = new StandardIDETextBox();
            else
                textBox = new CodeEditorIDETextBox();

            textBox.TextChanged += textBox_TextChanged;
            Input = new IDEInput(textBox);
            Controls.Add(textBox as Control);
        }

        void textBox_TextChanged(object sender, System.EventArgs e)
        {
            ActiveFile.Unsaved = true;
            UpdateSaveStatus();
        }

        public void UpdateSaveStatus()
        {
            bool endsWith = Text.EndsWith(" *");
            if(endsWith && ActiveFile.Unsaved)
                return;

            if (!endsWith && ActiveFile.Unsaved)
                Text = Text + " *";
            else
                RemoveSaveStatus();
        }

        public void SetInitialText(string text)
        {
            Input.Text = text;
            RemoveSaveStatus();
            
        }

        private void RemoveSaveStatus()
        {
            bool endsWith = Text.EndsWith(" *");
            if(endsWith)
            {
                Text = Text.Remove(Text.Length - 2, 2);                
            }
        }
    }
}