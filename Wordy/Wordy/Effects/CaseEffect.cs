using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordy.Types;

namespace Wordy.Effects
{
    public class CaseEffect : Effect
    {
        protected TextCase TextCase { get; private set; }

        public CaseEffect(TextCase textCase)
        {
            this.TextCase = TextCase;
        }

        public override string GetFilteredText(string sourceText)
        {
            switch (this.TextCase)
            {
                case TextCase.AllUpper:
                    return this.GetAllUpper(sourceText);
                case TextCase.AllLower:
                    return this.GetAllLower(sourceText);
                case TextCase.FirstUpperNextLower:
                    return this.GetFirstUpperNextLower(sourceText);
                case TextCase.FirstLowerNextUpper:
                    return this.GetFirstLowerNextUpper(sourceText);
                case TextCase.AlternatingFirstUpperCase:
                    return this.GetAlternatingFirstUpperCase(sourceText);
                case TextCase.AlternatingFirstLowerCase:
                    return this.GetAlternatingFirstLowerCase(sourceText);
                default:
                    return string.Copy(sourceText);
            }
        }

        private string GetAllUpper(string sourceText)
        {
            return sourceText.ToUpper();
        }

        private string GetAllLower(string sourceText)
        {
            return sourceText.ToLower();
        }

        private string GetFirstUpperNextLower(string sourceText)
        {
            if (string.IsNullOrEmpty(sourceText))
            {
                return string.Empty;
            }
            else
            {
                var firstLetter = sourceText.Substring(0, 1);
                var otherText = sourceText.Length > 1 ? sourceText.Substring(1) : string.Empty;
                return firstLetter.ToUpper()
                    + otherText.ToLower();
            }
        }

        private string GetFirstLowerNextUpper(string sourceText)
        {
            if (string.IsNullOrEmpty(sourceText))
            {
                return string.Empty;
            }
            else
            {
                var firstLetter = sourceText.Substring(0, 1);
                var otherText = sourceText.Length > 1 ? sourceText.Substring(1) : string.Empty;
                return firstLetter.ToLower()
                    + otherText.ToUpper();
            }
        }

        private string GetAlternating(string sourceText, bool firstSymbolUppercased)
        {
            var sourceSymbols = sourceText.ToCharArray();
            var resultBuilder = new StringBuilder();

            for (int symbolIndex = 0; symbolIndex < sourceSymbols.Length; symbolIndex++)
            {
                var sourceSymbol = sourceSymbols[symbolIndex];
                var isEvenSymbolIndex = symbolIndex % 2 == 0;
                var shouldMakeSymbolUppercased = (isEvenSymbolIndex && firstSymbolUppercased)
                    || (!isEvenSymbolIndex && !firstSymbolUppercased);
                var resultSymbol = shouldMakeSymbolUppercased
                    ? char.ToUpper(sourceSymbol)
                    : char.ToLower(sourceSymbol);
                resultBuilder.Append(resultSymbol);
            }

            return resultBuilder.ToString();
        }

        private string GetAlternatingFirstUpperCase(string sourceText)
        {
            return this.GetAlternating(sourceText, true);
        }

        private string GetAlternatingFirstLowerCase(string sourceText)
        {
            return this.GetAlternating(sourceText, false);
        }
    }
}
