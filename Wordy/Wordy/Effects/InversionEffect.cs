using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordy.Effects
{
    public class InversionEffect : Effect
    {
        public InversionEffect() : base()
        {
        }

        public override string GetFilteredText(string sourceText)
        {
            var invertedSymbols = sourceText.ToCharArray().Reverse().ToArray();
            return new string(invertedSymbols);
        }
    }
}
