using System;

namespace Aplios.Core.Randomize {

    public sealed class RandomProportional : Random {

        /// <summary>
        /// Podstawowy konstruktor obiektu klasy
        /// </summary>
        /// <param name="Seed"></param>
        public RandomProportional(int Seed = 1) : base(Seed) {

        }

        // The Sample method generates a distribution proportional to the value
        // of the random numbers, in the range [0.0, 1.0].
        protected override double Sample() => Math.Sqrt(base.Sample());


        public override int Next() => (int)(this.Sample() * int.MaxValue);
    }
}
