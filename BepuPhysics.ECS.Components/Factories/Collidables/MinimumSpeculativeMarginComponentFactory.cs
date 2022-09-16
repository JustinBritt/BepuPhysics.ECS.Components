namespace BepuPhysics.ECS.Components.Factories.Collidables
{
    using BepuPhysics.ECS.Components.InterfacesFactories.Collidables;
    using BepuPhysics.ECS.Components.Structs.Collidables;

    internal sealed class MinimumSpeculativeMarginComponentFactory : IMinimumSpeculativeMarginComponentFactory
    {
        public MinimumSpeculativeMarginComponentFactory()
        {
        }

        public MinimumSpeculativeMarginComponent Create(
            float value)
        {
            MinimumSpeculativeMarginComponent component = default;

            try
            {
                component = new MinimumSpeculativeMarginComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}