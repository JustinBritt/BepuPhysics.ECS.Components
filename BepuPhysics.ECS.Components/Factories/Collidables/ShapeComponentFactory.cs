namespace BepuPhysics.ECS.Components.Factories.Collidables
{
    using BepuPhysics.Collidables;
    using BepuPhysics.ECS.Components.InterfacesFactories.Collidables;
    using BepuPhysics.ECS.Components.Structs.Collidables;

    internal sealed class ShapeComponentFactory : IShapeComponentFactory
    {
        public ShapeComponentFactory()
        {
        }

        public ShapeComponent Create(
            IShape value)
        {
            ShapeComponent component = default;

            try
            {
                component = new ShapeComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}