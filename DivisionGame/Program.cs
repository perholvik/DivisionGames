using StructureMap;
using System.Collections.Generic;

namespace DivisionGame
{
    class Program
    {
        static void Main()
        {
            foreach (var game in GetGames())
            {
                game.Run();
            }
        }

        private static IEnumerable<ChildrensDivisionGame> GetGames()
        {
            var container = Container.For<ConsoleRegistry>();
            return container.GetAllInstances<ChildrensDivisionGame>();
        }
    }
}
