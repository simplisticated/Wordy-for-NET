using System.Text;
using Wordy.Data.Rotation;
using Wordy.Types;

namespace Wordy.Effects
{
    public class RotationEffect : Effect
    {
        protected TextRotation Rotation { get; private set; }

        protected bool CaseSensitive { get; private set; }

        public RotationEffect(TextRotation rotation) : base()
        {
            this.Rotation = rotation;
            this.CaseSensitive = true;
        }

        public RotationEffect(TextRotation rotation, bool caseSensitive)
        {
            this.Rotation = rotation;
            this.CaseSensitive = caseSensitive;
        }

        public override string GetFilteredText(string sourceText)
        {
            var filteredTextBuilder = new StringBuilder();
            var textLength = sourceText.Length;

            var rotationStore = new RotationStore();
            var ruleCount = rotationStore.Count;

            for (int letterIndex = 0; letterIndex < textLength; letterIndex++)
            {
                var sourceLetter = sourceText.Substring(letterIndex, 1);
                var isUppercase = char.IsUpper(sourceLetter[0]);
                var filteredLetter = string.Copy(sourceLetter);

                for (int ruleIndex = 0; ruleIndex < ruleCount; ruleIndex++)
                {
                    var rule = rotationStore[ruleIndex];
                    var isNormal = string.Equals(sourceLetter.ToLower(), rule.Normal.ToLower());
                    var isRotated = string.Equals(sourceLetter.ToLower(), rule.Rotated.ToLower());

                    switch (this.Rotation)
                    {
                        case TextRotation.Normal:
                            if (isRotated)
                            {
                                filteredLetter = rule.Normal;
                            }
                            break;
                        case TextRotation.UpsideDown:
                            if (isNormal)
                            {
                                filteredLetter = rule.Rotated;
                            }
                            break;
                        case TextRotation.Inverted:
                            if (isNormal)
                            {
                                filteredLetter = rule.Rotated;
                            }
                            else
                            {
                                filteredLetter = rule.Normal;
                            }
                            break;
                    }

                    var foundAppropriateRule = isNormal || isRotated;

                    if (foundAppropriateRule)
                    {
                        break;
                    }
                }

                if (this.CaseSensitive)
                {
                    filteredLetter = isUppercase
                        ? filteredLetter.ToUpper()
                        : filteredLetter.ToLower();
                }

                filteredTextBuilder.Append(filteredLetter);
            }

            return filteredTextBuilder.ToString();
        }
    }
}
