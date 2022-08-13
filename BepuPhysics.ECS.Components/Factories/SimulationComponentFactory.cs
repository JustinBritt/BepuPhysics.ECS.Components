namespace BepuPhysics.ECS.Components.Factories
{
    using BepuPhysics.ECS.Components.InterfacesFactories;
    using BepuPhysics.ECS.Components.Structs;

    internal sealed class SimulationComponentFactory : ISimulationComponentFactory
    {
        public SimulationComponentFactory()
        {
        }

        public SimulationComponent Create(
            Simulation value)
        {
            SimulationComponent component = default;

            try
            {
                component = new SimulationComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}