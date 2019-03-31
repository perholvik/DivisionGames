using StructureMap;

namespace DivisionGame
{
    public class ConsoleRegistry : Registry
    {
        public ConsoleRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();

                // custom registrations, not following convention
                scan.AddAllTypesOf<ChildrensDivisionGame>();
            });
        }
    }
}