namespace BepuPhysics.ECS.Components.Extensions
{
    using System.Linq;

    using DefaultEcs;

    using BepuPhysics.ECS.Components.Structs;

    public static class WorldExtensions
    {
        public static ref SimulationComponent GetSimulationComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<SimulationComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<SimulationComponent>();
        }

        public static Simulation GetSimulationLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<SimulationComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<SimulationComponent>().Value)
                .Last();
        }
    }
}