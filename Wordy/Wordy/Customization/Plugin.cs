using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordy.Customization
{
    public abstract class Plugin
    {
        public string SourceText { get; private set; }

        public Plugin(string sourceText)
        {
            this.SourceText = sourceText;
        }

        public abstract string GetResult();
    }
}
