namespace BepuPhysics.ECS.Components.Factories.Collidables
{
    using BepuPhysics.ECS.Components.InterfacesFactories.Collidables;
    using BepuPhysics.ECS.Components.Structs.Collidables;

    internal sealed class SpeculativeMarginComponentFactory : ISpeculativeMarginComponentFactory
    {
        public SpeculativeMarginComponentFactory()
        {
        }

        public SpeculativeMarginComponent Create(
            float value)
        {
            SpeculativeMarginComponent component = default;

            try
            {
                component = new SpeculativeMarginComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}