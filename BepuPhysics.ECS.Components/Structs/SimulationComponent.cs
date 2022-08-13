namespace BepuPhysics.ECS.Components.Structs
{
    using BepuPhysics;

    public struct SimulationComponent
    {
        public SimulationComponent(
            Simulation value)
        {
            this.Value = value;
        }

        public Simulation Value { get; }
    }
}