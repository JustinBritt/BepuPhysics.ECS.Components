namespace BepuPhysics.ECS.Components.InterfacesFactories.Collidables
{
    using BepuPhysics.Collidables;
    using BepuPhysics.ECS.Components.Structs.Collidables;

    public interface IShapeComponentFactory
    {
        ShapeComponent Create(
            IShape value);
    }
}