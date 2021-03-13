using System;

namespace Aplios.Core.Values {

    /// <summary>
    /// Operator realizuje mechanizm przypisywania wartości domyślnej w przypadku gdy jest null
    /// </summary>
    public class Valuable {

        /// <summary>
        /// The method verifies does reference of object is assigned
        /// </summary>
        /// <param name="instance">Referencja instancji obiektu</param>
        /// <returns></returns>
        public static bool IsNull(object instance) {
            return null == instance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">Typ parametru metody generycznej</typeparam>
        /// <param name="instance">Referencja instancji obiektu</param>
        /// <param name="defaultInstance">Domyślna wartość obiektu gdy wartość null</param>        
        public static void IsNull<T>(ref T instance, T defaultInstance = default(T)) {
            instance = IsNull(instance) ? defaultInstance : instance;
        }

        /// <summary>
        /// Metoda resetuje wartość obiektu, przypisując wartość domyślną obowiązującą dla danego typu
        /// </summary>
        /// <typeparam name="T">Typ parametru metody generycznej</typeparam>
        /// <param name="instance">Referencja instancji obiektu</param>
        public static void ResetValue<T>(ref T instance) {
            instance = Default.ZeroOf<T>(instance);
        }

        public static T ResetValue<T>() {
            return Default.ZeroOf<T>();
        }

        /// <summary>
        /// Metoda podejmuje próbę konwersji istancji obiektu do typu T   
        /// </summary>
        /// <typeparam name="T">Typ parametru metody generycznej</typeparam>
        /// <param name="instance">Referencja obiektu typu generycznego</param>
        /// <returns></returns>
        public static T CastOf<T>(object instance) {
            return (instance is T) ? (T)(instance) : throw new InvalidCastException("Błąd konwersji typu!");
        }
    }
}

