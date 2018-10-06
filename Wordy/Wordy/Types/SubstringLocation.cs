using System;

namespace Wordy.Types
{
    public class SubstringLocation
    {
        public int StartIndex { get; private set; }

        public int EndIndex { get; private set; }

        /// <summary>
        /// Creates new substring location.
        /// 
        /// Start index should be less than or equal to end index. Otherwise, <see cref="WrongIndexException"/> will be thrown.
        /// </summary>
        /// <param name="startIndex">Start index.</param>
        /// <param name="endIndex">End index.</param>
        /// <exception cref="WrongIndexException"></exception>
        public SubstringLocation(int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                throw new WrongIndexException();
            }

            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        public class WrongIndexException : Exception
        {
        }
    }
}
