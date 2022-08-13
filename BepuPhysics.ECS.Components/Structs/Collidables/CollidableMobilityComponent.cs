namespace BepuPhysics.ECS.Components.Structs.Collidables
{
    using BepuPhysics.Collidables;

    public struct CollidableMobilityComponent
    {
        public CollidableMobilityComponent(
            CollidableMobility value)
        {
            this.Value = value;
        }

        public CollidableMobility Value { get; }
    }
}