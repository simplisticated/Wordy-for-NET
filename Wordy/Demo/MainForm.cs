using System.Windows.Forms;
using Wordy.Bridge;

namespace Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
            this.InitializeTitleLabel();
        }

        private void InitializeTitleLabel()
        {
            this.titleLabel.Text = UseWordyTo.MakeEffects("Wordy Demo")
                .GetResult();
        }
    }
}
