using System;
using System.Collections.Generic;

namespace Aplios.Core.Values {

    public class Default {

        private static readonly Dictionary<Type, object> defaults;

        static Default() {
            defaults = new Dictionary<Type, object> {
                { Type.GetType("System.Object"), null },
                { Type.GetType("System.Boolean"), false },
                { Type.GetType("System.String"), String.Empty },
                { Type.GetType("System.Char"), Char.MinValue },
                { Type.GetType("System.Decimal"), Decimal.Zero },
                { Type.GetType("System.Double"), (double)0 },
                { Type.GetType("System.Single"), (float)0 },
                { Type.GetType("System.Int64"), (long)0 },
                { Type.GetType("System.UInt64"), (ulong)0 },
                { Type.GetType("System.Int32"), (int)0 },
                { Type.GetType("System.UInt32"), (uint)0 },
                { Type.GetType("System.Int16"), (short)0 },
                { Type.GetType("System.UInt16"), (ushort)0 },
                { Type.GetType("System.Byte"), (byte)0 },
                { Type.GetType("System.SByte"), (sbyte)0 },
            };
        }

        public static void ZeroOf<T>(ref T instance) {
            instance = (T)defaults[typeof(T)];
        }

        public static T ZeroOf<T>(T instance) {
            return (T)defaults[typeof(T)];
        }

        public static T ZeroOf<T>() {
            return (T)defaults[typeof(T)];
        }

        private Default() { }
    }
}
