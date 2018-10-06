namespace Wordy.Effects
{
    public abstract class Effect
    {
        public Effect()
        {
        }

        public abstract string GetFilteredText(string sourceText);
    }
}
