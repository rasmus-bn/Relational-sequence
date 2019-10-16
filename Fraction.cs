using System;

namespace Rational_sequence
{
    public class Fraction
    {
        private uint _numerator = 1;
        public uint Numerator
        {
            get { return this._numerator; }
            set
            {
                if (value <= 0) throw new ArgumentException($"{nameof(this.Numerator)} must be greater than zero");
                this._numerator = value;
            }
        }
        private uint _denominator = 1;
        public uint Denominator
        {
            get { return this._denominator; }
            set
            {
                if (value <= 0) throw new ArgumentException($"{nameof(this.Denominator)} must be greater than zero");
                this._denominator = value;
            }
        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }

        public double GetValue()
        {
            return (double) Numerator / (double) Denominator;
        }
    }
}