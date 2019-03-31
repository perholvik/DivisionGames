using System;
using System.Collections.Generic;

namespace DivisionGame
{
    public abstract class ChildrensDivisionGame : IChildrensDivisionGame

    {
        protected abstract string Description();

        public void Run()
        {
            Console.WriteLine(Description());
            foreach (var turn in Turns())
            {
                Console.WriteLine(TurnProcessor().Process(turn));
            }
            Console.WriteLine();
        }

        protected abstract IEnumerable<int> Turns();

        protected abstract ITurnProcessor TurnProcessor();
    }
}