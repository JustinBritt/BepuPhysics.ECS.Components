namespace BepuPhysics.ECS.Components.Factories.Collidables
{
    using BepuPhysics.Collidables;
    using BepuPhysics.ECS.Components.InterfacesFactories.Collidables;
    using BepuPhysics.ECS.Components.Structs.Collidables;

    internal sealed class CollidableMobilityComponentFactory : ICollidableMobilityComponentFactory
    {
        public CollidableMobilityComponentFactory()
        {
        }

        public CollidableMobilityComponent Create(
            CollidableMobility value)
        {
            CollidableMobilityComponent component = default;

            try
            {
                component = new CollidableMobilityComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}