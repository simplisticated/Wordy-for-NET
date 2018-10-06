using System.Windows.Forms;
using Wordy.Bridge;
using Wordy.Effects;
using Wordy.Types;

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
                .Apply(new RotationEffect(TextRotation.UpsideDown, true))
                .GetResult();
        }
    }
}
