using System;
using Wordy.Customization;
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

        public static T IntegratePlugin<T>(string sourceText) where T : Plugin
        {
            try
            {
                var constructorTypes = new Type[]
                {
                    typeof(string)
                };
                var constructor = typeof(T).GetConstructor(constructorTypes);
                var constructorParameters = new object[]
                {
                    sourceText
                };
                var plugin = constructor.Invoke(constructorParameters);

                if (plugin != null && plugin.GetType() == typeof(T))
                {
                    return (T) plugin;
                }
            }
            catch
            {
            }

            return null;
        }
    }
}
