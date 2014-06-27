using System;

namespace Ims.Core
{
    public static class Extensions
    {
        public static byte[] ToByteArray(this byte[] ids, bool ignoreEndianess = true)
        {
            byte[] binaryIds = new byte[ids.Length];
            bool isLittleEndian = BitConverter.IsLittleEndian;

            for (int i = 0; i < ids.Length; i++)
            {
                byte[] converted = BitConverter.GetBytes(ids[i]);

                if (isLittleEndian && !ignoreEndianess)
                    Array.Reverse(converted);

                converted.CopyTo(binaryIds, i);
            }

            return binaryIds;
        }

        public static byte[] ToByteArray(this short[] ids, bool ignoreEndianess = true)
        {
            byte[] binaryIds = new byte[ids.Length * 2];
            bool isLittleEndian = BitConverter.IsLittleEndian;

            for (int i = 0; i < ids.Length; i++)
            {
                byte[] converted = BitConverter.GetBytes(ids[i]);

                if (isLittleEndian && !ignoreEndianess)
                    Array.Reverse(converted);

                converted.CopyTo(binaryIds, i * 2);
            }

            return binaryIds;
        }

        public static byte[] ToByteArray(this int[] ids, bool ignoreEndianess = true)
        {
            byte[] binaryIds = new byte[ids.Length * 4];
            bool isLittleEndian = BitConverter.IsLittleEndian;

            for (int i = 0; i < ids.Length; i++)
            {
                byte[] converted = BitConverter.GetBytes(ids[i]);

                if (isLittleEndian && !ignoreEndianess)
                    Array.Reverse(converted);

                converted.CopyTo(binaryIds, i * 4);
            }

            return binaryIds;
        }

        public static byte[] ToByteArray(this long[] ids, bool ignoreEndianess = true)
        {
            byte[] binaryIds = new byte[ids.Length * 8];
            bool isLittleEndian = BitConverter.IsLittleEndian;

            for (int i = 0; i < ids.Length; i++)
            {
                byte[] converted = BitConverter.GetBytes(ids[i]);

                if (isLittleEndian && !ignoreEndianess)
                    Array.Reverse(converted);

                converted.CopyTo(binaryIds, i * 8);
            }

            return binaryIds;
        }
    }
}
