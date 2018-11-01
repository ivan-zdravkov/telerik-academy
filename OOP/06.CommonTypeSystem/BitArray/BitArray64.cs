using System;
using System.Collections;
using System.Collections.Generic;

namespace BitArray
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong bits;

        public BitArray64(ulong bits)
        {
            this.bits = bits;
        }

        public BitArray64(BitArray64 number)
        {
            this.bits = number.bits;
        }

        public int this[int key]
        {
            get
            {
                return GetValue(key);
            }
            set
            {
                SetValue(key, value);
            }
        }

        private int GetValue(int key)
        {
            ulong mask = 1;
            mask <<= key;
            if ((this.bits & mask) != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void SetValue(int key, int value)
        {
            ulong mask = 1;
            mask <<= key;
            if (value == 0)
            {
                if ((this.bits & mask) == 0)
                {
                    return;
                }
                else 
                {
                    this.bits &= ~mask;
                    return;
                }
            }
            else
            {
                if ((this.bits & mask) == 0)
                {
                    this.bits |= mask;
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (this.bits == ((BitArray64)obj).bits)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            if (BitArray64.Equals(first, second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            if (!(BitArray64.Equals(first, second)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return this.bits.GetHashCode();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this.GetValue(i);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
