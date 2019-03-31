using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace DivisionGame
{
    [UsedImplicitly]
    public class FuzzJazzGame : ChildrensDivisionGame
    {
        protected override string Description()
        {
            return "FuzzJazz, fra 100 til 1\n" +
                   "Regler: Fizz dersom delelig med 3, Buzz dersom delelig med 5, og FizzBuzz " +
                   "dersom delelig med begge.\n";
        }

        protected override IEnumerable<int> Turns()
        {
            return Enumerable.Range(1, 100).Reverse();
        }

        protected override ITurnProcessor TurnProcessor()
        {
            return new FuzzJazzer();
        }
    }
}