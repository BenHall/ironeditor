using System.Windows.Forms;

namespace IronEditor.UI.WinForms.Controls
{
    public partial class ControlTitle : UserControl
    {
        public ControlTitle()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return titleBar.Text;
            }
            set
            {
                titleBar.Text = value;
            }
        }
    }
}
