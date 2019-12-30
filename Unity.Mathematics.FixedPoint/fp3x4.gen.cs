//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics.FixedPoint
{
    [System.Serializable]
    public partial struct fp3x4 : System.IEquatable<fp3x4>, IFormattable
    {
        public fp3 c0;
        public fp3 c1;
        public fp3 c2;
        public fp3 c3;

        /// <summary>fp3x4 zero value.</summary>
        public static readonly fp3x4 zero;

        /// <summary>Constructs a fp3x4 matrix from four fp3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp3x4(fp3 c0, fp3 c1, fp3 c2, fp3 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a fp3x4 matrix from 12 fp values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp3x4(fp m00, fp m01, fp m02, fp m03,
                     fp m10, fp m11, fp m12, fp m13,
                     fp m20, fp m21, fp m22, fp m23)
        { 
            this.c0 = new fp3(m00, m10, m20);
            this.c1 = new fp3(m01, m11, m21);
            this.c2 = new fp3(m02, m12, m22);
            this.c3 = new fp3(m03, m13, m23);
        }

        /// <summary>Constructs a fp3x4 matrix from a single fp value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp3x4(fp v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        /// <summary>Constructs a fp3x4 matrix from a single int value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp3x4(int v)
        {
            this.c0 = (fp3)v;
            this.c1 = (fp3)v;
            this.c2 = (fp3)v;
            this.c3 = (fp3)v;
        }

        /// <summary>Constructs a fp3x4 matrix from a int3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp3x4(int3x4 v)
        {
            this.c0 = (fp3)v.c0;
            this.c1 = (fp3)v.c1;
            this.c2 = (fp3)v.c2;
            this.c3 = (fp3)v.c3;
        }

        /// <summary>Constructs a fp3x4 matrix from a single uint value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp3x4(uint v)
        {
            this.c0 = (fp3)v;
            this.c1 = (fp3)v;
            this.c2 = (fp3)v;
            this.c3 = (fp3)v;
        }

        /// <summary>Constructs a fp3x4 matrix from a uint3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp3x4(uint3x4 v)
        {
            this.c0 = (fp3)v.c0;
            this.c1 = (fp3)v.c1;
            this.c2 = (fp3)v.c2;
            this.c3 = (fp3)v.c3;
        }


        /// <summary>Implicitly converts a single fp value to a fp3x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator fp3x4(fp v) { return new fp3x4(v); }

        /// <summary>Explicitly converts a single int value to a fp3x4 matrix by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp3x4(int v) { return new fp3x4(v); }

        /// <summary>Explicitly converts a int3x4 matrix to a fp3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp3x4(int3x4 v) { return new fp3x4(v); }

        /// <summary>Explicitly converts a single uint value to a fp3x4 matrix by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp3x4(uint v) { return new fp3x4(v); }

        /// <summary>Explicitly converts a uint3x4 matrix to a fp3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp3x4(uint3x4 v) { return new fp3x4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two fp3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator * (fp3x4 lhs, fp3x4 rhs) { return new fp3x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }

        /// <summary>Returns the result of a componentwise multiplication operation on a fp3x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator * (fp3x4 lhs, fp rhs) { return new fp3x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a fp value and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator * (fp lhs, fp3x4 rhs) { return new fp3x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }


        /// <summary>Returns the result of a componentwise addition operation on two fp3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator + (fp3x4 lhs, fp3x4 rhs) { return new fp3x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }

        /// <summary>Returns the result of a componentwise addition operation on a fp3x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator + (fp3x4 lhs, fp rhs) { return new fp3x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a fp value and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator + (fp lhs, fp3x4 rhs) { return new fp3x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }


        /// <summary>Returns the result of a componentwise subtraction operation on two fp3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator - (fp3x4 lhs, fp3x4 rhs) { return new fp3x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }

        /// <summary>Returns the result of a componentwise subtraction operation on a fp3x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator - (fp3x4 lhs, fp rhs) { return new fp3x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a fp value and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator - (fp lhs, fp3x4 rhs) { return new fp3x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }


        /// <summary>Returns the result of a componentwise division operation on two fp3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator / (fp3x4 lhs, fp3x4 rhs) { return new fp3x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }

        /// <summary>Returns the result of a componentwise division operation on a fp3x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator / (fp3x4 lhs, fp rhs) { return new fp3x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a fp value and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator / (fp lhs, fp3x4 rhs) { return new fp3x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }


        /// <summary>Returns the result of a componentwise modulus operation on two fp3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator % (fp3x4 lhs, fp3x4 rhs) { return new fp3x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }

        /// <summary>Returns the result of a componentwise modulus operation on a fp3x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator % (fp3x4 lhs, fp rhs) { return new fp3x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a fp value and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator % (fp lhs, fp3x4 rhs) { return new fp3x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }


        /// <summary>Returns the result of a componentwise increment operation on a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator ++ (fp3x4 val) { return new fp3x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        /// <summary>Returns the result of a componentwise decrement operation on a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator -- (fp3x4 val) { return new fp3x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        /// <summary>Returns the result of a componentwise less than operation on two fp3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (fp3x4 lhs, fp3x4 rhs) { return new bool3x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }

        /// <summary>Returns the result of a componentwise less than operation on a fp3x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (fp3x4 lhs, fp rhs) { return new bool3x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a fp value and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (fp lhs, fp3x4 rhs) { return new bool3x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }


        /// <summary>Returns the result of a componentwise less or equal operation on two fp3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (fp3x4 lhs, fp3x4 rhs) { return new bool3x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }

        /// <summary>Returns the result of a componentwise less or equal operation on a fp3x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (fp3x4 lhs, fp rhs) { return new bool3x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a fp value and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (fp lhs, fp3x4 rhs) { return new bool3x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }


        /// <summary>Returns the result of a componentwise greater than operation on two fp3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (fp3x4 lhs, fp3x4 rhs) { return new bool3x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }

        /// <summary>Returns the result of a componentwise greater than operation on a fp3x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (fp3x4 lhs, fp rhs) { return new bool3x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a fp value and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (fp lhs, fp3x4 rhs) { return new bool3x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two fp3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (fp3x4 lhs, fp3x4 rhs) { return new bool3x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a fp3x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (fp3x4 lhs, fp rhs) { return new bool3x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a fp value and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (fp lhs, fp3x4 rhs) { return new bool3x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }


        /// <summary>Returns the result of a componentwise unary minus operation on a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator - (fp3x4 val) { return new fp3x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        /// <summary>Returns the result of a componentwise unary plus operation on a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 operator + (fp3x4 val) { return new fp3x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        /// <summary>Returns the result of a componentwise equality operation on two fp3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (fp3x4 lhs, fp3x4 rhs) { return new bool3x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on a fp3x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (fp3x4 lhs, fp rhs) { return new bool3x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a fp value and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (fp lhs, fp3x4 rhs) { return new bool3x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two fp3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (fp3x4 lhs, fp3x4 rhs) { return new bool3x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on a fp3x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (fp3x4 lhs, fp rhs) { return new bool3x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a fp value and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (fp lhs, fp3x4 rhs) { return new bool3x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }



        /// <summary>Returns the fp3 element at a specified index.</summary>
        unsafe public ref fp3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (fp3x4* array = &this) { return ref ((fp3*)array)[index]; }
            }
        }

        /// <summary>Returns true if the fp3x4 is equal to a given fp3x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(fp3x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the fp3x4 is equal to a given fp3x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((fp3x4)o); }


        /// <summary>Returns a hash code for the fp3x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)fpmath.hash(this); }


        /// <summary>Returns a string representation of the fp3x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("fp3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z);
        }

        /// <summary>Returns a string representation of the fp3x4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("fp3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider));
        }

    }

    public static partial class fpmath
    {
        /// <summary>Returns a fp3x4 matrix constructed from four fp3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 fp3x4(fp3 c0, fp3 c1, fp3 c2, fp3 c3) { return new fp3x4(c0, c1, c2, c3); }

        /// <summary>Returns a fp3x4 matrix constructed from from 12 fp values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 fp3x4(fp m00, fp m01, fp m02, fp m03,
                                  fp m10, fp m11, fp m12, fp m13,
                                  fp m20, fp m21, fp m22, fp m23)
        {
            return new fp3x4(m00, m01, m02, m03,
                             m10, m11, m12, m13,
                             m20, m21, m22, m23);
        }

        /// <summary>Returns a fp3x4 matrix constructed from a single fp value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 fp3x4(fp v) { return new fp3x4(v); }

        /// <summary>Returns a fp3x4 matrix constructed from a single int value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 fp3x4(int v) { return new fp3x4(v); }

        /// <summary>Return a fp3x4 matrix constructed from a int3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 fp3x4(int3x4 v) { return new fp3x4(v); }

        /// <summary>Returns a fp3x4 matrix constructed from a single uint value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 fp3x4(uint v) { return new fp3x4(v); }

        /// <summary>Return a fp3x4 matrix constructed from a uint3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 fp3x4(uint3x4 v) { return new fp3x4(v); }

        /// <summary>Return the fp4x3 transpose of a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 transpose(fp3x4 v)
        {
            return fp4x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z,
                v.c3.x, v.c3.y, v.c3.z);
        }

        /// <summary>Returns a uint hash code of a fp3x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(fp3x4 v)
        {
            return math.csum(fpmath.asuint(v.c0) * uint3(0x48125549u, 0xEEE2123Bu, 0xE3AD9FE5u) + 
                        fpmath.asuint(v.c1) * uint3(0xCE1CF8BFu, 0x7BE39F3Bu, 0xFAB9913Fu) + 
                        fpmath.asuint(v.c2) * uint3(0xB4501269u, 0xE04B89FDu, 0xDB3DE101u) + 
                        fpmath.asuint(v.c3) * uint3(0x7B6D1B4Bu, 0x58399E77u, 0x5EAC29C9u)) + 0xFC6014F9u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a fp3x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hashwide(fp3x4 v)
        {
            return (fpmath.asuint(v.c0) * uint3(0x6BF6693Fu, 0x9D1B1D9Bu, 0xF842F5C1u) + 
                    fpmath.asuint(v.c1) * uint3(0xA47EC335u, 0xA477DF57u, 0xC4B1493Fu) + 
                    fpmath.asuint(v.c2) * uint3(0xBA0966D3u, 0xAFBEE253u, 0x5B419C01u) + 
                    fpmath.asuint(v.c3) * uint3(0x515D90F5u, 0xEC9F68F3u, 0xF9EA92D5u)) + 0xC2FAFCB9u;
        }

    }
}