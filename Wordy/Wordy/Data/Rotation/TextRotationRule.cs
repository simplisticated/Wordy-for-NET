using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordy.Data.Rotation
{
    internal class TextRotationRule
    {
        public string Normal { get; private set; }

        public string Rotated { get; private set; }

        private TextRotationRule(string normal, string rotated)
        {
            this.Normal = normal;
            this.Rotated = rotated;
        }

        public class Builder
        {
            private string Normal;

            public Builder SetNormal(string normal)
            {
                this.Normal = normal;
                return this;
            }

            private string Rotated;

            public Builder SetRotated(string rotated)
            {
                this.Rotated = rotated;
                return this;
            }

            public Builder()
            {
            }

            public TextRotationRule Build()
            {
                return new TextRotationRule(this.Normal, this.Rotated);
            }
        }
    }
}
