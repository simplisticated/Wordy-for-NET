using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordy.Effects
{
    public abstract class Effect
    {
        public Effect()
        {
        }

        public abstract string GetFilteredText(string sourceText);
    }
}
