using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordy.Types;

namespace Wordy.Data.Transliteration
{
    internal class TransliterationStore
    {
        private static TransliterationRule[] EnglishToRussianRules = new TransliterationRule[]
        {

            // 5 letters
            new TransliterationRule.Builder()
                    .SetReplaceable("aught")
                    .SetReplacement("от")
                    .Build(),

            // 4 letters
            new TransliterationRule.Builder()
                    .SetReplaceable("ould")
                    .SetReplacement("уд")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ound")
                    .SetReplacement("аунд")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("eigh")
                    .SetReplacement("эй")
                    .Build(),

            // 3 letters
            new TransliterationRule.Builder()
                    .SetReplaceable("igh")
                    .SetReplacement("ай")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("eer")
                    .SetReplacement("иа")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("our")
                    .SetReplacement("ауэ")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("oor")
                    .SetReplacement("о")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("wor")
                    .SetReplacement("ё")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("air")
                    .SetReplacement("эа")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("oar")
                    .SetReplacement("о")
                    .Build(),

            // 2 letters
            new TransliterationRule.Builder()
                    .SetReplaceable("ee")
                    .SetReplacement("и")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ea")
                    .SetReplacement("и")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("oo")
                    .SetReplacement("у")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("th")
                    .SetReplacement("т")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("sh")
                    .SetReplacement("ш")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ch")
                    .SetReplacement("ч")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ph")
                    .SetReplacement("ф")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ck")
                    .SetReplacement("к")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ng")
                    .SetReplacement("нг")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("wh")
                    .SetReplacement("в")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("wr")
                    .SetReplacement("р")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("qu")
                    .SetReplacement("кв")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("all")
                    .SetReplacement("ол")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ai")
                    .SetReplacement("эй")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ay")
                    .SetReplacement("эй")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("oi")
                    .SetReplacement("ой")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("oy")
                    .SetReplacement("ой")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ow")
                    .SetReplacement("оу")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ou")
                    .SetReplacement("оу")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ew")
                    .SetReplacement("ю")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("aw")
                    .SetReplacement("о")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("wa")
                    .SetReplacement("во")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("au")
                    .SetReplacement("о")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("gh")
                    .SetReplacement("ф")
                    .Build(),

            // 1 letter
            new TransliterationRule.Builder()
                    .SetReplaceable("a")
                    .SetReplacement("э")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("b")
                    .SetReplacement("б")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("c")
                    .SetReplacement("к")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("d")
                    .SetReplacement("д")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("e")
                    .SetReplacement("э")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("f")
                    .SetReplacement("ф")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("g")
                    .SetReplacement("г")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("h")
                    .SetReplacement("х")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("i")
                    .SetReplacement("и")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("j")
                    .SetReplacement("дж")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("k")
                    .SetReplacement("к")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("l")
                    .SetReplacement("л")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("m")
                    .SetReplacement("м")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("n")
                    .SetReplacement("н")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("o")
                    .SetReplacement("о")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("p")
                    .SetReplacement("п")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("r")
                    .SetReplacement("р")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("s")
                    .SetReplacement("с")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("t")
                    .SetReplacement("т")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("u")
                    .SetReplacement("а")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("v")
                    .SetReplacement("в")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("w")
                    .SetReplacement("в")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("x")
                    .SetReplacement("кс")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("y")
                    .SetReplacement("и")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("z")
                    .SetReplacement("з")
                    .Build()

        };

        private static TransliterationRule[] RussianToEnglishRules = new TransliterationRule[]
        {

            // 1 letter
            new TransliterationRule.Builder()
                    .SetReplaceable("а")
                    .SetReplacement("a")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("б")
                    .SetReplacement("b")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("в")
                    .SetReplacement("v")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("г")
                    .SetReplacement("g")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("д")
                    .SetReplacement("d")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("е")
                    .SetReplacement("e")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ё")
                    .SetReplacement("yo")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ж")
                    .SetReplacement("zh")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("з")
                    .SetReplacement("z")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("и")
                    .SetReplacement("i")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("й")
                    .SetReplacement("y")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("к")
                    .SetReplacement("k")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("л")
                    .SetReplacement("l")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("м")
                    .SetReplacement("m")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("н")
                    .SetReplacement("n")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("о")
                    .SetReplacement("o")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("п")
                    .SetReplacement("p")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("р")
                    .SetReplacement("r")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("с")
                    .SetReplacement("s")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("т")
                    .SetReplacement("t")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("у")
                    .SetReplacement("u")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ф")
                    .SetReplacement("f")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("х")
                    .SetReplacement("kh")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ц")
                    .SetReplacement("ts")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ч")
                    .SetReplacement("ch")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ш")
                    .SetReplacement("sh")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("щ")
                    .SetReplacement("sch")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ъ")
                    .SetReplacement("")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ы")
                    .SetReplacement("y")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ь")
                    .SetReplacement("'")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("э")
                    .SetReplacement("e")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("ю")
                    .SetReplacement("yu")
                    .Build(),
            new TransliterationRule.Builder()
                    .SetReplaceable("я")
                    .SetReplacement("ya")
                    .Build()

        };

        public TransliterationStore()
        {
        }

        public TransliterationRule[] GetRules(Language sourceLanguage, Language targetLanguage)
        {
            switch (sourceLanguage)
            {
                case Language.English:
                    switch (targetLanguage)
                    {
                        case Language.English:
                            return new TransliterationRule[] { };
                        case Language.Russian:
                            return EnglishToRussianRules;
                        default:
                            return new TransliterationRule[] { };
                    }
                case Language.Russian:
                    switch (targetLanguage)
                    {
                        case Language.English:
                            return RussianToEnglishRules;
                        case Language.Russian:
                            return new TransliterationRule[] { };
                        default:
                            return new TransliterationRule[] { };
                    }
                default:
                    return new TransliterationRule[] { };
            }
        }
    }
}
