using Wordy.Tools;
using Wordy.Types;

namespace Wordy.Bridge
{
    public class UseWordyTo
    {
        public static EffectManager MakeEffects(string sourceText)
        {
            return new EffectManager(sourceText);
        }

        public static TransliterationManager Transliterate(Language from, Language to)
        {
            return new TransliterationManager(from, to);
        }
    }
}
