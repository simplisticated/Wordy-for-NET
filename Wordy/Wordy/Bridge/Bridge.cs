using Wordy.Tools;

namespace Wordy.Bridge
{
    public class UseWordyTo
    {
        public static EffectManager MakeEffects(string sourceText)
        {
            return new EffectManager(sourceText);
        }
    }
}
