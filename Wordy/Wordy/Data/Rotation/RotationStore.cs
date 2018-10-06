using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordy.Data.Rotation
{
    internal class RotationStore
    {
        protected TextRotationRule[] Rules { get; private set; }

        public int Count
        {
            get
            {
                return this.Rules.Length;
            }
        }

        public TextRotationRule this[int index]
        {
            get
            {
                return this.Rules[index];
            }
        }

        public RotationStore()
        {
            var mergedRules = new List<TextRotationRule>();
            mergedRules.AddRange(this.GenerateRulesForEnglish());
            mergedRules.AddRange(this.GenerateRulesForRussian());
            mergedRules.AddRange(this.GenerateRulesForSigns());

            this.Rules = mergedRules.ToArray();
        }

        private TextRotationRule[] GenerateRulesForEnglish()
        {
            return new TextRotationRule[]
            {
                new TextRotationRule.Builder()
                        .SetNormal("a")
                        .SetRotated("ɐ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("b")
                        .SetRotated("q")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("c")
                        .SetRotated("ɔ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("d")
                        .SetRotated("р")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("e")
                        .SetRotated("ǝ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("f")
                        .SetRotated("ɟ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("g")
                        .SetRotated("ƃ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("h")
                        .SetRotated("ɥ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("i")
                        .SetRotated("ı")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("j")
                        .SetRotated("ɾ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("k")
                        .SetRotated("ʞ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("l")
                        .SetRotated("l")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("m")
                        .SetRotated("ш")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("n")
                        .SetRotated("u")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("o")
                        .SetRotated("о")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("p")
                        .SetRotated("d")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("q")
                        .SetRotated("ь")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("r")
                        .SetRotated("ɹ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("s")
                        .SetRotated("s")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("t")
                        .SetRotated("ʇ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("u")
                        .SetRotated("п")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("v")
                        .SetRotated("л")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("w")
                        .SetRotated("м")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("x")
                        .SetRotated("x")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("y")
                        .SetRotated("ʎ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("z")
                        .SetRotated("z")
                        .Build()
            };
        }

        private TextRotationRule[] GenerateRulesForRussian()
        {
            return new TextRotationRule[]
            {
                new TextRotationRule.Builder()
                        .SetNormal("а")
                        .SetRotated("ɐ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("б")
                        .SetRotated("ƍ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("в")
                        .SetRotated("ʚ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("г")
                        .SetRotated("ɹ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("д")
                        .SetRotated("ɓ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("е")
                        .SetRotated("ǝ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("ё")
                        .SetRotated("ǝ̤")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("ж")
                        .SetRotated("ж")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("з")
                        .SetRotated("ε")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("и")
                        .SetRotated("и")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("й")
                        .SetRotated("n̯")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("к")
                        .SetRotated("ʞ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("л")
                        .SetRotated("v")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("м")
                        .SetRotated("w")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("н")
                        .SetRotated("н")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("о")
                        .SetRotated("o")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("п")
                        .SetRotated("u")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("р")
                        .SetRotated("d")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("с")
                        .SetRotated("ɔ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("т")
                        .SetRotated("ɯ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("у")
                        .SetRotated("ʎ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("ф")
                        .SetRotated("ȸ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("х")
                        .SetRotated("х")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("ц")
                        .SetRotated("ǹ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("ч")
                        .SetRotated("Һ")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("ш")
                        .SetRotated("m")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("щ")
                        .SetRotated("m")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("ъ")
                        .SetRotated("q")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("ы")
                        .SetRotated("ıq")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("ь")
                        .SetRotated("q")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("э")
                        .SetRotated("є")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("ю")
                        .SetRotated("oı")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("я")
                        .SetRotated("ʁ")
                        .Build()
            };
        }

        private TextRotationRule[] GenerateRulesForSigns()
        {
            return new TextRotationRule[]
            {
                new TextRotationRule.Builder()
                        .SetNormal(".")
                        .SetRotated("˙")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal(",")
                        .SetRotated("‘")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("'")
                        .SetRotated(",")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("!")
                        .SetRotated("¡")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("?")
                        .SetRotated("¿")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("/")
                        .SetRotated("/")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("\\")
                        .SetRotated("\\")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("<")
                        .SetRotated(">")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal(">")
                        .SetRotated("<")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("(")
                        .SetRotated(")")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal(")")
                        .SetRotated("(")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("[")
                        .SetRotated("]")
                        .Build(),
                new TextRotationRule.Builder()
                        .SetNormal("]")
                        .SetRotated("[")
                        .Build()
            };
        }
    }
}
