using Wordy.Types;

namespace Wordy.Tools
{
    internal class SubstringFinder
    {
        protected string SourceText { get; private set; }

        public SubstringFinder(string sourceText)
        {
            this.SourceText = sourceText;
        }

        public string GetSubstringBefore(SubstringLocation location)
        {
            const int startIndex = 0;

            if (startIndex >= location.StartIndex)
            {
                return string.Empty;
            }

            var endIndex = location.StartIndex - 1;
            var length = endIndex - startIndex + 1;
            return this.SourceText.Substring(startIndex, length);
        }

        public string GetSubstringFrom(SubstringLocation location)
        {
            var startIndex = location.StartIndex;
            var length = location.EndIndex - location.StartIndex + 1;
            return this.SourceText.Substring(startIndex, length);
        }

        public string GetSubstringAfter(SubstringLocation location)
        {
            var startIndex = location.EndIndex + 1;

            if (startIndex >= this.SourceText.Length)
            {
                return string.Empty;
            }

            return this.SourceText.Substring(startIndex);
        }
    }
}
