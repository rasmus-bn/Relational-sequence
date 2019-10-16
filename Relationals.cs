using System;
using System.Collections;

namespace Rational_sequence
{
    public class Relationals : IEnumerable {

        private readonly uint _startIndex;
        private readonly uint _endIndex;

        public Relationals(uint startIndex, uint endIndex)
        {
            this._startIndex = startIndex;
            this._endIndex = endIndex;
        }

        public IEnumerator GetEnumerator()
        {
            for(uint i = this._startIndex; i <= this._endIndex; i++)
            {
                yield return Relationals.GetRational(i);
            }
        }

        public static Fraction GetRational(uint index)
        {
            double diagonalLine = ((Math.Sqrt(8 * (index + 1)) - 1) / 2) + 1;
            uint diagonalNo = (uint) diagonalLine;

            uint numerator = (uint) Math.Ceiling(diagonalNo * (diagonalLine - diagonalNo));
            uint denominator = diagonalNo - numerator + 1;

            return new Fraction{ Numerator = numerator, Denominator = denominator };
        }
    }
}