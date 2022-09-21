namespace BepuPhysics.ECS.Components.Factories.Collidables
{
    using System;

    using BepuPhysics.ECS.Components.InterfacesFactories.Collidables;
    using BepuPhysics.ECS.Components.Structs.Collidables;

    internal sealed class TShapeComponentFactory : ITShapeComponentFactory
    {
        public TShapeComponentFactory()
        {
        }

        public TShapeComponent Create(
            Type value)
        {
            TShapeComponent component = default;

            try
            {
                component = new TShapeComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}