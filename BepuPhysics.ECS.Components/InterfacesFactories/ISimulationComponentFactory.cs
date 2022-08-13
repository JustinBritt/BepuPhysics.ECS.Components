namespace BepuPhysics.ECS.Components.InterfacesFactories
{
    using BepuPhysics.ECS.Components.Structs;

    public interface ISimulationComponentFactory
    {
        SimulationComponent Create(
            Simulation value);
    }
}