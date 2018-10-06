using Wordy.Effects;

namespace Wordy.Types
{
    public class TextChange
    {
        public Effect Effect { get; private set; }

        public SubstringLocation Location { get; private set; }

        public TextChange(Effect effect, SubstringLocation location)
        {
            this.Effect = effect;
            this.Location = location;
        }
    }
}
