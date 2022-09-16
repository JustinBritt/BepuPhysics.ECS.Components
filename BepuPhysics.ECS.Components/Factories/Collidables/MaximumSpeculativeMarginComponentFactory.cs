namespace BepuPhysics.ECS.Components.Factories.Collidables
{
    using BepuPhysics.ECS.Components.InterfacesFactories.Collidables;
    using BepuPhysics.ECS.Components.Structs.Collidables;

    internal sealed class MaximumSpeculativeMarginComponentFactory : IMaximumSpeculativeMarginComponentFactory
    {
        public MaximumSpeculativeMarginComponentFactory()
        {
        }

        public MaximumSpeculativeMarginComponent Create(
            float value)
        {
            MaximumSpeculativeMarginComponent component = default;

            try
            {
                component = new MaximumSpeculativeMarginComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}