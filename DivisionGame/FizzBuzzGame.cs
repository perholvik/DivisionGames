using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace DivisionGame
{
    [UsedImplicitly]
    public class FizzBuzzGame : ChildrensDivisionGame
    {
        protected override string Description()
        {
            return "FizzBuzz, fra 1 til 100\n" +
                   "Regler: Fizz dersom delelig med 3, Buzz dersom delelig med 5, og FizzBuzz " +
                   "dersom delelig med begge.\n";
        }

        protected override IEnumerable<int> Turns()
        {
            return Enumerable.Range(1, 100);
        }

        protected override ITurnProcessor TurnProcessor()
        {
            return new FizzBuzzer();
        }
    }
}