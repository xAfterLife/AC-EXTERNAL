using System;

namespace AC_External
{
    public class Maths
    {
        public const Double MagicNumber = 180 / Math.PI;

        #region Structs

        public struct SVector<T>
        {
            public T x, y, z;

            public SVector(T _x, T _y, T _z)
            {
                x = _x;
                y = _y;
                z = _z;
            }

            public T[] ToArray()
            {
                return new T[] { this.x, this.y, this.z };
            }

            public int GetMagnitudeInt()
            {
                long ix = Convert.ToInt64(x);
                long iy = Convert.ToInt64(y);
                long iz = Convert.ToInt64(z);

                return Convert.ToInt32(Math.Sqrt((ix * ix) + (iy * iy) + (iz * iz)));
            }

            public float GetMagnitudeFloat()
            {
                float ix = Convert.ToSingle(x);
                float iy = Convert.ToSingle(y);
                float iz = Convert.ToSingle(z);

                return Convert.ToSingle(Math.Sqrt(ix * ix + iy * iy + iz * iz));
            }

            public double GetMagnitudeDouble()
            {
                double ix = Convert.ToDouble(x);
                double iy = Convert.ToDouble(y);
                double iz = Convert.ToDouble(z);

                return Convert.ToDouble(Math.Sqrt(ix * ix + iy * iy + iz * iz));
            }
        }
        #endregion

        #region Methods

        #region VectorSubtract
        public static SVector<int> VectorSubtractInt(SVector<int> a, SVector<int> b)
        {
            return new SVector<int>(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static SVector<float> VectorSubtcractFloat(SVector<float> a, SVector<float> b)
        {
            return new SVector<float>(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static SVector<double> VectorSubtractDouble(SVector<double> a, SVector<double> b)
        {
            return new SVector<double>(a.x - b.x, a.y - b.y, a.z - b.z);
        }
        #endregion

        #region Jaw
        public static int GetJawInt(SVector<int> vec)
        {
            return (int)(Math.Atan2(vec.y, vec.x) * MagicNumber) + 90;
        }

        public static float GetJawFloat(SVector<float> vec)
        {
            return (float)(Math.Atan2(vec.y, vec.x) * MagicNumber) + 90f;
        }

        public static double GetJawDouble(SVector<float> vec)
        {
            return Math.Atan2(vec.y, vec.x) * MagicNumber + 90d;
        }
        #endregion  

        #region Pitch
        public static int GetPitchInt(SVector<int> vec)
        {
            return (int)(Math.Atan2(vec.z, Math.Sqrt(vec.x * vec.x + vec.y * vec.y)) * MagicNumber);
        }

        public static float GetPitchFloat(SVector<float> vec)
        {
            return (float)(Math.Atan2(vec.z, Math.Sqrt(vec.x * vec.x + vec.y * vec.y)) * MagicNumber);
        }

        public static double GetPitchDouble(SVector<float> vec)
        {
            return Math.Atan2(vec.z, Math.Sqrt(vec.x * vec.x + vec.y * vec.y)) * MagicNumber;
        }
        #endregion

        #endregion
    }
}
