using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public sealed class Rational
    {
        private readonly int _numerator;
        private readonly int _denomenator;

        public Rational(int numerator, int denomenator)
        {
            _numerator = numerator;
            _denomenator = denomenator;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Rational m = obj as Rational;
            if (m as Rational == null)
                return false;

            if (m._denomenator != this._denomenator)
            {
                return (this._numerator * m._denomenator == m._numerator * this._denomenator);
            }
            return (this._numerator == m._numerator);

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_numerator, _denomenator);

        }

        public static Rational operator +(Rational rational1, Rational rational2)
        {
            if (rational1._denomenator != rational2._denomenator)
            {
                return new Rational(rational1._numerator * rational2._denomenator + rational2._numerator * rational1._denomenator, rational1._denomenator * rational2._denomenator);
            }
            return new Rational(rational1._numerator + rational2._numerator, rational1._denomenator);
        }

        public static Rational operator -(Rational rational1, Rational rational2)
        {
            if (rational1._denomenator != rational2._denomenator)
            {
                return new Rational(rational1._numerator * rational2._denomenator - rational2._numerator * rational1._denomenator, rational1._denomenator * rational2._denomenator);
            }
            return new Rational(rational1._numerator - rational2._numerator, rational1._denomenator);
        }

        public static Rational operator *(Rational rational1, Rational rational2)
        { 
            return new Rational(rational1._numerator * rational2._numerator, rational1._denomenator * rational2._denomenator);
        }

        public static Rational operator /(Rational rational1, Rational rational2)
        {
           
            return new Rational(rational1._numerator * rational2._denomenator, rational1._denomenator * rational2._numerator);
        }

        public static bool operator >(Rational rational1, Rational rational2)
        {
            if (rational1._denomenator != rational2._denomenator)
            {
                return rational1._numerator * rational2._denomenator > rational2._numerator * rational1._denomenator;
            }
            return rational1._numerator > rational2._numerator;
        }

        public static bool operator >=(Rational rational1, Rational rational2)
        {
            if (rational1._denomenator != rational2._denomenator)
            {
                return rational1._numerator * rational2._denomenator >= rational2._numerator * rational1._denomenator;
            }
            return rational1._numerator >= rational2._numerator;
        }

        public static bool operator <(Rational rational1, Rational rational2)
        {
            if (rational1._denomenator != rational2._denomenator)
            {
                return rational1._numerator * rational2._denomenator < rational2._numerator * rational1._denomenator;
            }
            return rational1._numerator < rational2._numerator;
        }

        public static bool operator <=(Rational rational1, Rational rational2)
        {

            if (rational1._denomenator != rational2._denomenator)
            {
                return rational1._numerator * rational2._denomenator <= rational2._numerator * rational1._denomenator;
            }
            return rational1._numerator < rational2._numerator;
        }

        public static Rational operator ++(Rational rational1)
        {
            return new Rational(rational1._numerator + rational1._denomenator, rational1._denomenator);
        }


        public  static Rational operator --(Rational rational1)
        {
            return new Rational(rational1._numerator - rational1._denomenator, rational1._denomenator);
        }

        public override string? ToString()
        {
            return string.Concat(_numerator, '/', _denomenator);
        }

        public static implicit operator int(Rational rational1)
        {
            return Convert.ToInt32(rational1._numerator/ rational1._denomenator);
        }

        public static implicit operator float(Rational rational1)
        {
            return (float)rational1._numerator / rational1._denomenator;
        }



    }
}
