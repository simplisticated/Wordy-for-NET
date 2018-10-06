using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordy.Data.Transliteration
{
    internal class TransliterationRule
    {
        public string Replaceable { get; private set; }

        public string Replacement { get; private set; }

        public TransliterationRule(string replaceable, string replacement)
        {
            this.Replaceable = replaceable;
            this.Replacement = replacement;
        }

        public class Builder
        {
            private string Replaceable;

            public Builder SetReplaceable(string replaceable)
            {
                this.Replaceable = replaceable;
                return this;
            }

            private string Replacement;

            public Builder SetReplacement(string replacement)
            {
                this.Replacement = replacement;
                return this;
            }

            public Builder()
            {
            }

            public TransliterationRule Build()
            {
                return new TransliterationRule(this.Replaceable, this.Replacement);
            }
        }
    }
}
