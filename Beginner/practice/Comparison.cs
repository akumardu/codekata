using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    public struct CalorieCount: IComparable<CalorieCount>
    {
        public int CompareTo(CalorieCount other)
        {
            return this._valueCompareTo(other._value);
        }

        private int _valueCompareTo(float _value)
        {
            if (this._value == _value)
                return 0;
            else if (this._value > _value)
                return 1;
            else
                return -1;
        }

        private float _value;
        public float Value
        {
            get
            {
                return _value;
            }
        }
        public CalorieCount(float value)
        {
            this._value = value;
        }
        public override string ToString()
        {
            return _value + "cal";
        }
    }
}
