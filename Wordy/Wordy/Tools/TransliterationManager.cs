using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordy.Data.Transliteration;
using Wordy.Effects;
using Wordy.Types;

namespace Wordy.Tools
{
    public class TransliterationManager
    {
        protected Language SourceLanguage { get; private set; }

        protected Language TargetLanguage { get; private set; }

        public TransliterationManager(Language sourceLanguage, Language targetLanguage)
        {
            this.SourceLanguage = sourceLanguage;
            this.TargetLanguage = targetLanguage;
        }

        public string GetText(string sourceText)
        {
            var rules = new TransliterationStore()
                .GetRules(this.SourceLanguage, this.TargetLanguage);
            var resultText = string.Copy(sourceText);

            foreach (var rule in rules)
            {
                if (rule.Replaceable.Length == 1)
                {
                    resultText = resultText.Replace
                    (
                        new EffectManager(rule.Replaceable)
                            .Apply(new CaseEffect(TextCase.AllUpper))
                            .GetResult(),
                        new EffectManager(rule.Replacement)
                            .Apply(new CaseEffect(TextCase.FirstUpperNextLower))
                            .GetResult()
                    );
                }
                else
                {
                    resultText = resultText.Replace
                    (
                        new EffectManager(rule.Replaceable)
                            .Apply(new CaseEffect(TextCase.AllUpper))
                            .GetResult(),
                        new EffectManager(rule.Replacement)
                            .Apply(new CaseEffect(TextCase.AllUpper))
                            .GetResult()
                    );

                    resultText = resultText.Replace
                    (
                        new EffectManager(rule.Replaceable)
                            .Apply(new CaseEffect(TextCase.FirstUpperNextLower))
                            .GetResult(),
                        new EffectManager(rule.Replacement)
                            .Apply(new CaseEffect(TextCase.FirstUpperNextLower))
                            .GetResult()
                    );

                    resultText = resultText.Replace
                    (
                        new EffectManager(rule.Replaceable)
                            .Apply(new CaseEffect(TextCase.FirstLowerNextUpper))
                            .GetResult(),
                        new EffectManager(rule.Replacement)
                            .Apply(new CaseEffect(TextCase.FirstLowerNextUpper))
                            .GetResult()
                    );
                }

                resultText = resultText.Replace
                (
                    new EffectManager(rule.Replaceable)
                        .Apply(new CaseEffect(TextCase.AllLower))
                        .GetResult(),
                    new EffectManager(rule.Replacement)
                        .Apply(new CaseEffect(TextCase.AllLower))
                        .GetResult()
                );
            }

            return resultText;
        }
    }
}
