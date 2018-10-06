using System.Collections.Generic;
using Wordy.Effects;
using Wordy.Types;

namespace Wordy.Tools
{
    public class EffectManager
    {
        protected string SourceText { get; private set; }

        protected List<TextChange> Changes { get; private set; }

        public EffectManager(string sourceText)
        {
            this.SourceText = sourceText;
            this.Changes = new List<TextChange>();
        }

        public EffectManager Apply(Effect effect)
        {
            var location = new SubstringLocation(0, this.SourceText.Length - 1);
            var change = new TextChange(effect, location);
            this.Changes.Add(change);
            return this;
        }

        public EffectManager Apply(Effect effect, int startIndex, int endIndex)
        {
            var location = new SubstringLocation(startIndex, endIndex);
            var change = new TextChange(effect, location);
            this.Changes.Add(change);
            return this;
        }

        public string GetResult()
        {
            var resultText = string.Copy(this.SourceText);

            foreach (var change in this.Changes)
            {
                var substringFinder = new SubstringFinder(resultText);

                var substringBeforeSelectedLocation = substringFinder.GetSubstringBefore(change.Location);
                var substringFromSelectedLocation = substringFinder.GetSubstringFrom(change.Location);
                var substringAfterSelectedLocation = substringFinder.GetSubstringAfter(change.Location);

                var filteredSubstringFromSelectedLocation = change.Effect.GetFilteredText(substringFromSelectedLocation);

                resultText = substringBeforeSelectedLocation
                    + filteredSubstringFromSelectedLocation
                    + substringAfterSelectedLocation;
            }

            return resultText;
        }
    }
}
